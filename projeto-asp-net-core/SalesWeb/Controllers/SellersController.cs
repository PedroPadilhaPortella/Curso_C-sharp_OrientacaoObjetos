using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        public IActionResult Index() {
            var sellers = SellerService.FindAll();
            return View(sellers);
        }

        [HttpGet]
        public IActionResult Create() {
            var departments = DepartmentService.FindAll();
            var sellerForm = new SellerForm() { Departments = departments };
            return View(sellerForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            if(!ModelState.IsValid) {
                var departments = DepartmentService.FindAll();
                var sellerForm = new SellerForm() { Seller = seller, Departments = departments };
                return View(sellerForm);
            }

            SellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int? id) 
        {
            if(id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var seller = SellerService.FindById(id.Value);

            if(seller == null)
                return RedirectToAction(nameof(Error), new { message = "Id not found"});

            return View(seller);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id) 
        {
            SellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if(id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var seller = SellerService.FindById(id.Value);

            if(seller == null)
                return RedirectToAction(nameof(Error), new { message = "Id not found"});

            return View(seller);
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if(id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var seller = SellerService.FindById(id.Value);

            if(seller == null)
                return RedirectToAction(nameof(Error), new { message = "Id not found"});

            List<Department> departments = DepartmentService.FindAll();
            SellerForm sellerForm = new SellerForm() {Seller = seller, Departments = departments };

            return View(sellerForm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            if(!ModelState.IsValid) {
                var departments = DepartmentService.FindAll();
                var sellerForm = new SellerForm() { Seller = seller, Departments = departments };
                return View(sellerForm);
            }

            if(id != seller.Id)
                return RedirectToAction(nameof(Error), new { message = "Id mismatch"});

            try {
                SellerService.Update(seller);
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