using DotNetCoreMvcChart.ApexChartsApp.Models;
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
        public IActionResult GroupedStackedBarChart()
        {
            GroupedStackedBarChartModel model = new GroupedStackedBarChartModel();
            model.Series = new List<SeriesData>
            { 
                new SeriesData()
                {
                    Name = "Q1 Budget",
                    Group = "budget",
                    Datas = new List<int>() { 44000, 55000, 41000, 67000, 22000 }
                },
                new SeriesData()
                {
                    Name = "Q1 Actual",
                    Group = "actual",
                    Datas = new List<int>() { 48000, 50000, 40000, 65000, 25000 }
                },
                new SeriesData()
                {
                    Name = "Q2 Budget",
                    Group = "budget",
                    Datas = new List<int>() { 13000, 36000, 20000, 8000, 13000 }
                },
                new SeriesData()
                {
                    Name = "Q2 Actual",
                    Group = "actual",
                    Datas = new List<int>() { 20000, 40000, 25000, 10000, 12000 }
                }
            };
            return View(model);
        }
    }
}
