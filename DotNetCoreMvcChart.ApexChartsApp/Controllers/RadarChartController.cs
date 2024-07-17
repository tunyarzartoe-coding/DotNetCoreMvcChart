using DotNetCoreMvcChart.ApexChartsApp.Models.RadarChart;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class RadarChartController : Controller
    {
        public IActionResult BasicRadarChart()
        {
            BasicRadarChartModel model = new BasicRadarChartModel();
            model.Categories = new List<string>() { "January", "February", "March", "April", "May", "June" };
            model.SeriesData = new List<SeriesData>() 
            { 
                new SeriesData()
                {
                    Name = "Series 1",
                    Data = new List<int> { 80, 50, 30, 40, 100, 20 }
                }
            };
            return View(model);
        }
    }
}
