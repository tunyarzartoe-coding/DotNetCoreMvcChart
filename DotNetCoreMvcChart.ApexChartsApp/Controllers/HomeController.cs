using DotNetCoreMvcChart.ApexChartsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new ChartSelectionModel
            {
                SelectedChartType = "Column",
                ChartTypes = new List<string> { "Column", "Bar", "Pie", "Line" }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ChartSelectionModel model)
        {
            switch (model.SelectedChartType)
            {
                case "Column":
                    return RedirectToAction("Index", "ColumnChart");
                case "Bar":
                    return RedirectToAction("Index", "BarChart");
                case "Pie":
                    return RedirectToAction("Index", "PieChart");
                case "Line":
                    return RedirectToAction("Index", "LineChart");
                default:
                    return RedirectToAction("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
