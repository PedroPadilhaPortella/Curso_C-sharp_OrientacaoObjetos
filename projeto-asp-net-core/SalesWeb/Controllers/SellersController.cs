using Microsoft.AspNetCore.Mvc;
using SalesWeb.Data;

namespace SalesWeb.Controllers
{
    public class SellersController : Controller
    {
        private readonly SalesWebContext Database;
        public SellersController(SalesWebContext database) {
            Database = database;
        }

        public IActionResult Index() {
            return View();
        }
    }
}