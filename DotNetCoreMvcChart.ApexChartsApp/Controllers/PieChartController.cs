using DotNetCoreMvcChart.ApexChartsApp.Models.PieChart;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class PieChartController : Controller
    {
        public IActionResult SimplePieChart()
        {
            SimplePieChartModel model = new SimplePieChartModel();
            model.Labels = new List<string>() {"Team A", "Team B", "Team C", "Team D", "Team E" };
            model.Series = new List<int>() {44, 55, 13, 43, 22 };
            return View(model);
        }
        public IActionResult SimpleDonutChart() 
        { 
            SimpleDonutModel model = new SimpleDonutModel();
            model.Series = new List<int>() { 44, 55, 41, 17, 15 };
            return View(model);
        }

        public IActionResult SemiDonutChart()
        {
            SemiDonutModel model = new SemiDonutModel();
            model.Series = new List<int>() { 44, 55, 41, 17, 15 };
            return View(model);
        }
    }
}
