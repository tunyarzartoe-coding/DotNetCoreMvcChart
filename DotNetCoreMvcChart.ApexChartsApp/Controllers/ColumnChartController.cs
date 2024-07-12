using DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class ColumnChartController : Controller
    {
        public IActionResult BasicColumnChart()
        {
            BasicColumnChartModel model = new BasicColumnChartModel();
            model.Categories = new List<string>() { "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct" };
            model.ColumnData = new List<ColumnData>
            {
                new ColumnData()
                {
                    Name = "Net Profit",
                    ColumnDatas = new List<int> { 44, 55, 57, 56, 61, 58, 63, 60, 66 }

                },
                new ColumnData()
                {
                    Name = "Revenue",
                    ColumnDatas = new List<int> { 76, 85, 101, 98, 87, 105, 91, 114, 94 }

                },
                new ColumnData()
                {
                    Name = "Free Cash Flow",
                    ColumnDatas = new List<int> { 35, 41, 36, 26, 45, 48, 52, 53, 41 }

                }
            };
            return View(model);
        }
    }
}
