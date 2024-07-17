using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class ChartDemoController : Controller
    {
        public IActionResult LineChart()
        {
            return View();
        }
    }
}
