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
    }
}
