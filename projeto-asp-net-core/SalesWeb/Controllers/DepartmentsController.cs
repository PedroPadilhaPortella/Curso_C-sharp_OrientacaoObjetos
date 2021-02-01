using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Data;
using SalesWeb.Models;
using SalesWeb.Models.ViewModels;
using SalesWeb.Services;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly DepartmentService DepartmentService;

        public DepartmentsController(DepartmentService departmentService)
        {
            DepartmentService = departmentService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var departments = await DepartmentService.FindAllAsync();
            return View(departments);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Department department)
        {
            if (!ModelState.IsValid)
                return View(department);

            await DepartmentService.InsertAsync(department);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var department = await DepartmentService.FindByIdAsync(id.Value);

            if (department == null)
                return NotFound();

            return View(department);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await DepartmentService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var department = await DepartmentService.FindByIdAsync(id.Value);

            if(department == null)
                return RedirectToAction(nameof(Error), new { message = "Id not found"});

            return View(department);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
                return RedirectToAction(nameof(Error), new { message = "Id not provided"});

            var department = await DepartmentService.FindByIdAsync(id.Value);

            if(department == null)
                return RedirectToAction(nameof(Error), new { message = "Id not found"});

            return View(department);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Department department)
        {
            if(!ModelState.IsValid) {
                return View(department);
            }

            if(id != department.Id)
                return RedirectToAction(nameof(Error), new { message = "Id mismatch"});

            try {
                await DepartmentService.UpdateAsync(department);
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