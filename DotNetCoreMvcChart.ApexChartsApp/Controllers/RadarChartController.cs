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
        public IActionResult MultipleRadarChart()
        {
            MultipleRadarChartModel model = new MultipleRadarChartModel();
            model.Categories = new List<string>() { "2011", "2012", "2013", "2014", "2015", "2016" };
            model.SeriesDatas = new List<SeriesDatas>()
            {
                new SeriesDatas()
                {
                    Name = "Series 1",
                    Data = new List<int> { 80, 50, 30, 40, 100, 20 }
                },
                new SeriesDatas()
                {
                    Name = "Series 2",
                    Data = new List<int> { 20, 30, 40, 80, 20, 80 }
                },
                new SeriesDatas()
                {
                    Name = "Series 3",
                    Data = new List<int> { 44, 76, 78, 13, 43, 10 }
                }
            };
            return View(model);
        }
        public IActionResult PolygonRadarChart()
        {
            PolygonRadarChartModel model = new PolygonRadarChartModel();
            model.Categories = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            model.SeriesData = new List<Series>()
            {
                new Series()
                {
                    Name = "Series 1",
                    Data = new List<int> { 20, 100, 40, 30, 50, 80, 33 }
                }
            };
            return View(model);
        }
    }
}
