using DotNetCoreMvcChart.ApexChartsApp.Models.LineChart;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class LineChartController : Controller
    {
        public IActionResult BasicLineChart()
        {
            BasicLineChartModel model = new BasicLineChartModel();
            model.Datas = new List<int>() { 10, 41, 35, 51, 49, 62, 69, 91, 148 };
            model.Categories = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" };
            return View(model);
        }

        public IActionResult DashedLineChart()
        {
            DashedLineChartModel model = new DashedLineChartModel();
            model.SeriesData = new List<SeriesData>()
            {
                new SeriesData()
                {
                    Name = "Session Duration",
                    Datas = new List<int> { 45, 52, 38, 24, 33, 26, 21, 20, 6, 8, 15, 10 }

                },
                new SeriesData()
                {
                    Name = "Page View",
                    Datas = new List<int> { 35, 41, 62, 42, 13, 18, 29, 37, 36, 51, 32, 35 }

                },
                new SeriesData()
                {
                    Name = "Total Visits",
                    Datas = new List<int> { 87, 57, 74, 99, 75, 38, 62, 47, 82, 56, 45, 47 }

                }
            };
            model.Categories = new List<string>() {
                "01 Jan", "02 Jan", "03 Jan", "04 Jan", "05 Jan", "06 Jan", "07 Jan",
                "08 Jan", "09 Jan","10 Jan", "11 Jan", "12 Jan"
                                                   };
            return View(model);
        }
    }
}
