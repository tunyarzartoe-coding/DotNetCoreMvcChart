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
        public IActionResult GroupedBarChart()
        {
            GroupedBarChartModel model = new GroupedBarChartModel();
            model.Categories = new List<int>() { 2001, 2002, 2003, 2004, 2005, 2006, 2007};
            model.Data1 = new List<int>() { 44, 55, 41, 64, 22, 43, 21 };
            model.Data2 = new List<int>() { 53, 32, 33, 52, 13, 44, 32 };
            return View(model);
        }
    }
}
