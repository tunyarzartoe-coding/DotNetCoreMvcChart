using DotNetCoreMvcChart.ApexChartsApp.Models;
using DotNetCoreMvcChart.ApexChartsApp.Models.BarChart;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcChart.ApexChartsApp.Controllers
{
    public class BarChartController : Controller
    {
        public IActionResult BasicBarChart()
        {
            BasicBarChartModel model = new BasicBarChartModel();
            model.Categories = new List<string>() 
            {
                    "South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan",
                    "United States", "China", "Germany" 
            };
            model.Datas = new List<int>() { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
            return View(model);
        }
        public IActionResult GroupedBarChart()
        {
            GroupedBarChartModel model = new GroupedBarChartModel();
            model.Categories = new List<int>() { 2001, 2002, 2003, 2004, 2005, 2006, 2007};
            model.Data1 = new List<int>() { 44, 55, 41, 64, 22, 43, 21 };
            model.Data2 = new List<int>() { 53, 32, 33, 52, 13, 44, 32 };
            return View(model);
        }
        public IActionResult GroupedStackedBarChart()
        {
            GroupedStackedBarChartModel model = new GroupedStackedBarChartModel();
            model.Series = new List<SeriesData>
            { 
                new SeriesData()
                {
                    Name = "Q1 Budget",
                    Group = "budget",
                    Datas = new List<int>() { 44000, 55000, 41000, 67000, 22000 }
                },
                new SeriesData()
                {
                    Name = "Q1 Actual",
                    Group = "actual",
                    Datas = new List<int>() { 48000, 50000, 40000, 65000, 25000 }
                },
                new SeriesData()
                {
                    Name = "Q2 Budget",
                    Group = "budget",
                    Datas = new List<int>() { 13000, 36000, 20000, 8000, 13000 }
                },
                new SeriesData()
                {
                    Name = "Q2 Actual",
                    Group = "actual",
                    Datas = new List<int>() { 20000, 40000, 25000, 10000, 12000 }
                }
            };
            return View(model);
        }
        public IActionResult PatternedBarChart()
        {
            PatternedBarChartModel model = new PatternedBarChartModel();
            model.PatternedData = new List<PatternedData>
            {
                new PatternedData()
                {
                    Name= "Marine Sprite",
                    Data= new List<int> { 44, 55, 41, 37, 22, 43, 21 }
                },
                 new PatternedData()
                {
                    Name= "Striking Calf",
                    Data= new List<int> { 53, 32, 33, 52, 13, 43, 32 }
                },
                  new PatternedData()
                {
                    Name= "Tank Picture",
                    Data= new List<int> { 12, 17, 11, 9, 15, 11, 20 }
                },
                   new PatternedData()
                {
                    Name= "Bucket Slope",
                    Data= new List<int> { 9, 7, 5, 8, 6, 9, 4 }
                }
            };
            model.Categories = new List<int>()
            {
                2008, 2009, 2010, 2011, 2012, 2013, 2014
            };
            return View(model);
        }
        public IActionResult ReversedBarChart()
        {
            ReversedBarChartModel model = new ReversedBarChartModel();
            model.Data = new List<ReversedBarData> 
            { 
                new ReversedBarData()
                {
                    Data= new List<int> { 400, 430, 448, 470, 540, 580, 690 }
                }
            };
            model.Categories = new List<string>() { "June", "July", "August", "September", "October", "November", "December" };
            return View(model);
        }
        public IActionResult StackedBarChart()
        {
            StackedBarChartModel model = new StackedBarChartModel();
            model.StackedDatas = new List<StackedData> 
            { 
                new StackedData()
                {
                    Name = "'Marine Sprite",
                    Data = new List<int> { 44, 55, 41, 37, 22, 43, 21 }
                },
                new StackedData()
                {
                    Name = "Striking Calf",
                    Data = new List<int> { 53, 32, 33, 52, 13, 43, 32 }
                },
                new StackedData()
                {
                    Name = "Tank Picture",
                    Data = new List<int> { 12, 17, 11, 9, 15, 11, 20 }
                },
                new StackedData()
                {
                    Name = "Bucket Slope",
                    Data = new List<int> { 9, 7, 5, 8, 6, 9, 4 }
                },
                new StackedData()
                {
                    Name = "Reborn Kid",
                    Data = new List<int> { 25, 12, 19, 32, 25, 24, 10 }
                }

            };
            model.Categories = new List<int>() { 2008, 2009, 2010, 2011, 2012, 2013, 2014 };
            return View(model);
        }
        public IActionResult FullStackedBarChart()
        {
            FullStackedBarChartModel model = new FullStackedBarChartModel();
            model.FullStackedDatas = new List<FullStackedData>
            {
                new FullStackedData()
                {
                    Name = "'Marine Sprite",
                    Data = new List<int> { 44, 55, 41, 37, 22, 43, 21 }
                },
                new FullStackedData()
                {
                    Name = "Striking Calf",
                    Data = new List<int> { 53, 32, 33, 52, 13, 43, 32 }
                },
                new FullStackedData()
                {
                    Name = "Tank Picture",
                    Data = new List<int> { 12, 17, 11, 9, 15, 11, 20 }
                },
                new FullStackedData()
                {
                    Name = "Bucket Slope",
                    Data = new List<int> { 9, 7, 5, 8, 6, 9, 4 }
                },
                new FullStackedData()
                {
                    Name = "Reborn Kid",
                    Data = new List<int> { 25, 12, 19, 32, 25, 24, 10 }
                }

            };
            model.Categories = new List<int>() { 2008, 2009, 2010, 2011, 2012, 2013, 2014 };
            return View(model);
        }
    }
}
