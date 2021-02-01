using Microsoft.AspNetCore.Mvc;
using SalesWeb.Data;
using SalesWeb.Models;
using SalesWeb.Models.ViewModels;
using SalesWeb.Services;

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
    }
}