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
        public IActionResult DataLabelColumnChart()
        {
            DataLabelColumnChartModel model = new DataLabelColumnChartModel();
            model.Categories = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            model.DataLabelColumnData = new List<DataLabelColumnData>
            {
                new DataLabelColumnData()
                {
                    Name= "Inflation",
                    ColumnDatas = new List<double> { 2.3, 3.1, 4.0, 10.1, 4.0, 3.6, 3.2, 2.3, 1.4, 0.8, 0.5, 0.2 }
                }
            };
            return View(model);
        }
    }
}
