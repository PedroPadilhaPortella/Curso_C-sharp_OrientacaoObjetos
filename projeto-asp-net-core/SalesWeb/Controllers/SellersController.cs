using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Data;
using SalesWeb.Models;
using SalesWeb.Models.ViewModels;
using SalesWeb.Services;
using SalesWeb.Services.Exceptions;

namespace SalesWeb.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService SellerService;
        private readonly DepartmentService DepartmentService;
        public SellersController(SellerService sellerService, DepartmentService departmentService) {
            SellerService = sellerService;
            DepartmentService = departmentService;
        }


        public async Task<IActionResult> Index()
        {
            var sellers = await SellerService.FindAllAsync();
            return View(sellers);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var departments = await DepartmentService.FindAllAsync();
            var sellerForm = new SellerForm() { Departments = departments };
            return View(sellerForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            if(!ModelState.IsValid) {
                var departments = await DepartmentService.FindAllAsync();
                var sellerForm = new SellerForm() { Seller = seller, Departments = departments };
                return View(sellerForm);
            }

            await SellerService.InsertAsync(seller);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id) 
        {
            if(id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var seller = await SellerService.FindByIdAsync(id.Value);

            if(seller == null)
                return RedirectToAction(nameof(Error), new { message = "Id not found"});

            return View(seller);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id) 
        {
            await SellerService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var seller = await SellerService.FindByIdAsync(id.Value);

            if(seller == null)
                return RedirectToAction(nameof(Error), new { message = "Id not found"});

            return View(seller);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id) 
        {
            if(id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var seller = await SellerService.FindByIdAsync(id.Value);

            if(seller == null)
                return RedirectToAction(nameof(Error), new { message = "Id not found"});

            List<Department> departments = await DepartmentService.FindAllAsync();
            SellerForm sellerForm = new SellerForm() {Seller = seller, Departments = departments };

            return View(sellerForm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Seller seller)
        {
            if(!ModelState.IsValid) {
                var departments = await DepartmentService.FindAllAsync();
                var sellerForm = new SellerForm() { Seller = seller, Departments = departments };
                return View(sellerForm);
            }

            if(id != seller.Id)
                return RedirectToAction(nameof(Error), new { message = "Id mismatch"});

            try {
                await SellerService.UpdateAsync(seller);
                return RedirectToAction(nameof(Index));
            }
            catch(ApplicationException e) {
                return RedirectToAction(nameof(Error), new { message = e.Message});
            }
        }

        public IActionResult Error(string message)
        {
            var error = new ErrorViewModel 
            { 
                Message = message, 
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            };
            return View(error);
        }
    }
}