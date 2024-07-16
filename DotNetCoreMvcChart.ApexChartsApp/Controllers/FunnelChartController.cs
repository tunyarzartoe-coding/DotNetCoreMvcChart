using DotNetCoreMvcChart.ApexChartsApp.Models.FunnelChart;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class FunnelChartController : Controller
    {
        public IActionResult SimpleFunnelChart()
        {
            SimpleFunnelChartModel model = new SimpleFunnelChartModel();
            model.Categories = new List<string>() 
            {
                    "Sourced",
                    "Screened",
                    "Assessed",
                    "HR Interview",
                    "Technical",
                    "Verify",
                    "Offered",
                    "Hired"
            };
            model.SeriesData = new List<SeriesData> 
            { 
                new SeriesData()
                {
                    Name = "Funnel Series",
                    Data = new List<int> {1380, 1100, 990, 880, 740, 548, 330, 200},
                }
            };
            return View(model);
        }
        public IActionResult  PyramidChart()
        {
            PyramidChartModel model = new PyramidChartModel();
            model.Categories = new List<string>() 
            { 
                "Sweets", "Processed Foods", "Healthy Fats", "Meat", "Beans & Legumes",
                "Dairy", "Fruits & Vegetables", "Grains" 
            };
            model.Colors = new List<string>()
            {
                "#F44F5E",
                "#E55A89",
                "#D863B1",
                "#CA6CD8",
                "#B57BED",
                "#8D95EB",
                "#62ACEA",
                "#4BC3E6"
            };
            model.SeriesData = new List<SeriesDatas>()
            {
                new SeriesDatas()
                {
                    Name = "Funnel Series",
                    Data = new List<int> {1380, 1100, 990, 880, 740, 548, 330, 200},
                }
            };
            return View(model);
        }
    }
}
