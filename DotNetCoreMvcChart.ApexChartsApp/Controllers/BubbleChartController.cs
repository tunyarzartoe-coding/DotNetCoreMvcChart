using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class BubbleChartController : Controller
    {
        public IActionResult ThreeDBubbleChart()
        {
            return View();
        }
    }
}
