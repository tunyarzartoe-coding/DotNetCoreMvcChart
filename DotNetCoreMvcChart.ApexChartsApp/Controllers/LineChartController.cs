using DotNetCoreMvcChart.ApexChartsApp.Models.LieChart;
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
    }
}
