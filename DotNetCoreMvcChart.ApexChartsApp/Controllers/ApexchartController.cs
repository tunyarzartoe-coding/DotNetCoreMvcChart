using DotNetCoreMvcChart.ApexChartsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class ApexchartController : Controller
    {
        public IActionResult SimplePieChart()
        {
            SimplePieChartModel model = new SimplePieChartModel();
            model.Labels = new List<string>() {"Team A", "Team B", "Team C", "Team D", "Team E" };
            model.Series = new List<int>() {44, 55, 13, 43, 22 };
            return View(model);
        }
    }
}
