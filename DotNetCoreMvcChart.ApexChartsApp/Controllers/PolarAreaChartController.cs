using DotNetCoreMvcChart.ApexChartsApp.Models.PolarAreaChart;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class PolarAreaChartController : Controller
    {
        public IActionResult BasicPolarAreaChart()
        {
            BasicPolarAreaChartModel model = new BasicPolarAreaChartModel();
            model.Series = new List<int>() { 14, 23, 21, 17, 15, 10, 12, 17, 21 };
            return View(model);
        }
        public IActionResult MonochromePolarAreaChart()
        {
            MonochromePolarAreaChartModel model= new MonochromePolarAreaChartModel();
            model.SerieDatas = new List<int>() { 42, 47, 52, 58, 65 };
            model.Labels = new List<string>() { "Rose A", "Rose B", "Rose C", "Rose D", "Rose E" };
            return View(model);
        }
    }
}
