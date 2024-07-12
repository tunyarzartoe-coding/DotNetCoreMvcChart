using DotNetCoreMvcChart.ApexChartsApp.Models;
using DotNetCoreMvcChart.ApexChartsApp.Models.BarChart;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

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
            model.Categories = new List<int>() { 2001, 2002, 2003, 2004, 2005, 2006, 2007 };
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
                    Name = "Marine Sprite",
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
                    Name = "Marine Sprite",
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
        public IActionResult NegativeBarChart()
        {
            NegativeBarChartModel model = new NegativeBarChartModel();
            model.NegativeBarChartDatas = new List<NegativeBarChartData>
            {
                new NegativeBarChartData()
                {
                   Name ="Males",
                   Data = new List<double> ()
                   {
                       0.4, 0.65, 0.76, 0.88, 1.5, 2.1, 2.9, 3.8, 3.9, 4.2, 4, 4.3, 4.1, 4.2, 4.5,
                       3.9, 3.5, 3
                   }
                },
                new NegativeBarChartData()
                {
                   Name ="Females",
                   Data = new List<double> ()
                   {
                       -0.8, -1.05, -1.06, -1.18, -1.4, -2.2, -2.85, -3.7, -3.96, -4.22, -4.3, -4.4,
                       -4.1, -4, -4.1, -3.4, -3.1, -2.8
                   }
                },
            };
            model.Categories = new List<string>()
            {
                    "85+", "80-84", "75-79", "70-74", "65-69", "60-64", "55-59", "50-54", "45-49",
                    "40-44", "35-39", "30-34", "25-29", "20-24", "15-19", "10-14","5-9","0-4"
            };
            return View(model);
        }
        public IActionResult MakerBarChart()
        {
            MakerBarChartModel model = new MakerBarChartModel();
            model.Name = "Actual";
            model.Data = new List<MakerData>
            {
                new MakerData()
                {
                    X = "2011",
                    Y=12,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 14,
                            StrokeWidth= 2,
                            StrokeDashArray= 2,
                            //StrokeLineCap="",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2012",
                    Y=44,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 54,
                            StrokeWidth= 5,
                            StrokeDashArray= 10,
                            //StrokeLineCap="",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2013",
                    Y=54,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 52,
                            StrokeWidth= 10,
                            StrokeDashArray= 0,
                            StrokeLineCap="round",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2014",
                    Y=66,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 61,
                            StrokeWidth= 10,
                            StrokeDashArray= 0,
                            StrokeLineCap="round",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2015",
                    Y=81,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 66,
                            StrokeWidth= 10,
                            StrokeDashArray= 0,
                            StrokeLineCap="round",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2016",
                    Y=67,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 70,
                            StrokeWidth= 5,
                            StrokeDashArray= 10,
                            //StrokeLineCap="",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
            };
            return View(model);
        }
        public IActionResult ImageBarChart()
        {
            ImageBarChartModel model = new ImageBarChartModel();
            model.Name = "coins";
            model.Datas = new List<double>()
            {
                2, 4, 3, 4, 3, 5, 5, 6.5, 6, 5, 4, 5, 8, 7, 7, 8, 8, 10, 9, 9, 12, 12,
                11, 12, 13, 14, 16, 14, 15, 17, 19, 21
            };
            return View(model);
        }
        public IActionResult DataLabelBarChart()
        {
            DataLabelChartModel model = new DataLabelChartModel();
            model.Datas = new List<int>() { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
            model.Colors = new List<string>()
            {
                "#33b2df", "#546E7A", "#d4526e", "#13d8aa", "#A5978B", "#2b908f", "#f9a3a4", "#90ee7e",
                "#f48024", "#69d2e7"
            };
            model.Categories = new List<string>()
            {
                "South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan",
                "United States", "China", "India"
            };
            return View(model);
        }
    }
}
