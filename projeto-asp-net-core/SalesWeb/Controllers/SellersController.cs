using System.Collections.Generic;
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
            SellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int? id) 
        {
            if(id == null)
                return NotFound();

            var seller = SellerService.FindById(id.Value);

            if(seller == null)
                return NotFound();

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
                return NotFound();

            var seller = SellerService.FindById(id.Value);

            if(seller == null)
                return NotFound();

            return View(seller);
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if(id == null)
                return NotFound();

            var seller = SellerService.FindById(id.Value);

            if(seller == null)
                return NotFound();

            List<Department> departments = DepartmentService.FindAll();
            SellerForm sellerForm = new SellerForm() {Seller = seller, Departments = departments };

            return View(sellerForm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            if(id != seller.Id)
                return BadRequest();

            try {
                SellerService.Update(seller);
                return RedirectToAction(nameof(Index));
            }
            catch(NotFoundException) {
                return NotFound();
            }
            catch(DbConcurrencyException) {
                return BadRequest();
            }
        }
    }
}