using DotNetCoreMvcChart.ApexChartsApp.Models.BarChart;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class BarChartController : Controller
    {
        public IActionResult BasicBarChart()
        {
            BasicBarChartModel model = new BasicBarChartModel();
            model.Categories = new List<string>() 
            {
                    "South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan",
                    "United States", "China", "Germany" 
            };
            model.Datas = new List<int>() { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
            return View(model);
        }
    }
}
