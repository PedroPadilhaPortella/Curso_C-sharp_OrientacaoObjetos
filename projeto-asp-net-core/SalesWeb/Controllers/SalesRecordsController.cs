using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Services;

namespace SalesWeb.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService SalesRecordService;
        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            SalesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if(!minDate.HasValue)
                minDate = new DateTime(DateTime.Now.Year, 1, 1);

            if(!maxDate.HasValue)
                maxDate = new DateTime(DateTime.Now.Year, 1, 1);

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var sales = await SalesRecordService.FindByDateAsync(minDate, maxDate);
            return View(sales);
        }


        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if(!minDate.HasValue)
                minDate = new DateTime(DateTime.Now.Year, 1, 1);

            if(!maxDate.HasValue)
                maxDate = new DateTime(DateTime.Now.Year, 1, 1);

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var sales = await SalesRecordService.FindByDateGroupingAsync(minDate, maxDate);
            return View(sales);
        }
    }
}