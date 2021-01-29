using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;

namespace SalesWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();

            list.Add(new Department { Id = 1, Name = "Design" });
            list.Add(new Department { Id = 2, Name = "Gestão" });
            list.Add(new Department { Id = 3, Name = "Desenvolvimento" });
            list.Add(new Department { Id = 4, Name = "Banco de Dados" });

            return View(list);
        }
    }
}