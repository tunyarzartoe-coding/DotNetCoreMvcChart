using DotNetCoreMvcChart.ApexChartsApp.Models.LineChart;
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

        public IActionResult DashedLineChart()
        {
            DashedLineChartModel model = new DashedLineChartModel();
            model.SeriesData = new List<SeriesData>()
            {
                new SeriesData()
                {
                    Name = "Session Duration",
                    Datas = new List<int> { 45, 52, 38, 24, 33, 26, 21, 20, 6, 8, 15, 10 }

                },
                new SeriesData()
                {
                    Name = "Page View",
                    Datas = new List<int> { 35, 41, 62, 42, 13, 18, 29, 37, 36, 51, 32, 35 }

                },
                new SeriesData()
                {
                    Name = "Total Visits",
                    Datas = new List<int> { 87, 57, 74, 99, 75, 38, 62, 47, 82, 56, 45, 47 }

                }
            };
            model.Categories = new List<string>() {
                "01 Jan", "02 Jan", "03 Jan", "04 Jan", "05 Jan", "06 Jan", "07 Jan",
                "08 Jan", "09 Jan","10 Jan", "11 Jan", "12 Jan"
                                                   };
            return View(model);
        }

        public  IActionResult GradientLineChart()
        {
            GradientLineChartModel model = new GradientLineChartModel();
            model.Categories = new List<string>() { "1/11/2000", "2/11/2000", "3/11/2000", "4/11/2000", "5/11/2000", "6/11/2000", "7/11/2000", "8/11/2000", "9/11/2000", "10/11/2000", "11/11/2000", "12/11/2000", "1/11/2001", "2/11/2001", "3/11/2001", "4/11/2001", "5/11/2001", "6/11/2001" };
            model.Data = new List<int>() { 4, 3, 10, 9, 29, 19, 22, 9, 12, 7, 19, 5, 13, 9, 17, 2, 7, 5 };
            return View(model);  
        }
        public IActionResult DataLabelLineChart()
        {
            DataLabelLineChartModel model = new DataLabelLineChartModel();
            model.Categories = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            model.Series = new List<Datas> ()
            { 
                new Datas()
                {
                    Name = "High - 2013",
                    Data =new List<int> { 28, 29, 33, 36, 32, 32, 33 }
                },
                new Datas()
                {
                    Name = "Low - 2013",
                    Data =new List<int> { 12, 11, 14, 18, 17, 13, 13 }
                }
            };
            return View(model);
        }
    }
}
