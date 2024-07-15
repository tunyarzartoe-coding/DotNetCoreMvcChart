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
        public IActionResult GroupedColumnChart()
        {
            GroupedColumnChartModel model = new GroupedColumnChartModel();
            model.Name = "Sales";
            model.GroupedData = new List<GroupedData>
            {
                new GroupedData() { X = "2019/01/01", Y = 400 },
                new GroupedData() { X = "2019/04/01", Y = 430 },
                new GroupedData() { X = "2019/07/01", Y = 448 },
                new GroupedData() { X = "2019/10/01", Y = 470 },
                new GroupedData() { X = "2020/01/01", Y = 540 },
                new GroupedData() { X = "2020/04/01", Y = 580 },
                new GroupedData() { X = "2020/07/01", Y = 690 },
                new GroupedData() { X = "2020/10/01", Y = 590 }
            };
            return View(model);
        }
        public IActionResult MakerColumnChart()
        {
            MakerColumnChartModel model = new MakerColumnChartModel();
            model.Name = "Actual";
            model.Data = new List<MakerData>
            {
                new MakerData()
                {
                    X = "2011",
                    Y=1292,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 1400,
                            StrokeHeight= 5,
                            //StrokeLineCap="",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2012",
                    Y=4432,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 5400,
                            StrokeHeight= 5,
                            //StrokeDashArray= 10,
                            //StrokeLineCap="",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2013",
                    Y=5423,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 5200,
                            StrokeHeight= 5,
                            //StrokeDashArray= 0,
                            //StrokeLineCap="round",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2014",
                    Y=6653,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 6500,
                            StrokeHeight= 5,
                            //StrokeDashArray= 0,
                            //StrokeLineCap="round",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2015",
                    Y=8133,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 6600,
                            StrokeHeight= 13,
                            StrokeWidth= 0,
                            //StrokeDashArray= 0,
                            StrokeLineCap="round",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2016",
                    Y=7132,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 7500,
                            StrokeHeight= 5,
                            //StrokeDashArray= 10,
                            //StrokeLineCap="",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2017",
                    Y=7332,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 8700,
                            StrokeHeight= 5,
                            //StrokeDashArray= 10,
                            //StrokeLineCap="",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
                new MakerData()
                {
                    X = "2018",
                    Y=6553,
                    Goals = new List<Goals>
                    {
                        new Goals()
                        {
                            Name= "Expected",
                            Value= 7300,
                            StrokeHeight= 2,
                            StrokeDashArray= 2,
                            //StrokeLineCap="",
                            StrokeColor= "#775DD0"
                        }
                    }

                },
            };
            return View(model);
        }
        public IActionResult NegativeColumnChart()
        {
            NegativeColumnChartModel model = new NegativeColumnChartModel();
            model.Categories = new List<string>() 
            {
                    "2011-01-01", "2011-02-01", "2011-03-01", "2011-04-01", "2011-05-01", "2011-06-01",
                    "2011-07-01", "2011-08-01", "2011-09-01", "2011-10-01", "2011-11-01", "2011-12-01",
                    "2012-01-01", "2012-02-01", "2012-03-01", "2012-04-01", "2012-05-01", "2012-06-01",
                    "2012-07-01", "2012-08-01", "2012-09-01", "2012-10-01", "2012-11-01", "2012-12-01",
                    "2013-01-01", "2013-02-01", "2013-03-01", "2013-04-01", "2013-05-01", "2013-06-01",
                    "2013-07-01", "2013-08-01", "2013-09-01" 
            };
            model.Name = "Cash Flow";
            model.Data = new List<double>()
            {       
                    1.45, 5.42, 5.9, -0.42, -12.6, -18.1, -18.2, -14.16, -11.1, -6.09, 0.34, 3.88, 13.07,
                    5.8, 2, 7.37, 8.1, 13.57, 15.75, 17.1, 19.8, -27.03, -54.4, -47.2, -43.3, -18.6, -
                    48.6, -41.1, -39.6, -37.6, -29.4, -21.4, -2.4
            };
            return View(model);
        }
        public IActionResult RotatedDataLabelsColumnChart()
        {
            RotatedDataLabelsColumnChartModel model = new RotatedDataLabelsColumnChartModel();
            model.Name = "Cash Flow";
            model.Datas = new List<double>() 
            {
                    1.45, 5.42, 5.9, -0.42, -12.6, -18.1, -18.2, -14.16, -11.1, -6.09, 0.34, 3.88, 13.07,
                    5.8, 2, 7.37, 8.1, 13.57, 15.75, 17.1, 19.8, -27.03, -54.4, -47.2, -43.3, -18.6, -
                    48.6, -41.1, -39.6, -37.6, -29.4, -21.4, -2.4
            };
            model.Categories = new List<string>() 
            {
                    "2011-01-01", "2011-02-01", "2011-03-01", "2011-04-01", "2011-05-01", "2011-06-01",
                    "2011-07-01", "2011-08-01", "2011-09-01", "2011-10-01", "2011-11-01", "2011-12-01",
                    "2012-01-01", "2012-02-01", "2012-03-01", "2012-04-01", "2012-05-01", "2012-06-01",
                    "2012-07-01", "2012-08-01", "2012-09-01", "2012-10-01", "2012-11-01", "2012-12-01",
                    "2013-01-01", "2013-02-01", "2013-03-01", "2013-04-01", "2013-05-01", "2013-06-01",
                    "2013-07-01", "2013-08-01", "2013-09-01" 
            };
            return View(model);
        }
        public IActionResult RotatedLabelsColumnChart()
        {
            RotatedLabelsColumnChartModel model = new RotatedLabelsColumnChartModel();
            model.Name = "Servings";
            model.Labels = new List<string>() 
            {
                    "Apples", "Oranges", "Strawberries", "Pineapples", "Mangoes", "Bananas",
                    "Blackberries", "Pears", "Watermelons", "Cherries", "Pomegranates", "Tangerines", "Papayas"
            };
            model.Datas = new List<int>() 
            {
                    44, 55, 41, 67, 22, 43, 21, 33, 45, 31, 87, 65, 35
            };
            return View(model);
        }
        public IActionResult DataColorColumnChart()
        {
            DataColorColumnChartModel model = new DataColorColumnChartModel();
            model.Name = "Yearly Profit";
            model.Datas = new List<ColumnDataColors> 
            { 
                new ColumnDataColors()
                {
                    X= "2011",
                    Y=1292

                },
                new ColumnDataColors()
                {
                    X= "2012",
                    Y=4432

                },
                new ColumnDataColors()
                {
                    X= "2013",
                    Y=5423

                },
                new ColumnDataColors()
                {
                    X= "2014",
                    Y=6653

                },
                new ColumnDataColors()
                {
                    X= "2015",
                    Y=8133,
                    FillColor="#EB8C87",
                    StrokeColor ="#C23829"
                },
                new ColumnDataColors()
                {
                    X= "2016",
                    Y=7132

                },
                new ColumnDataColors()
                {
                    X= "2017",
                    Y=7332

                },
                new ColumnDataColors()
                {
                    X= "2018",
                    Y=6553

                },
            };
            return View(model);
        }
        public IActionResult DistributedColumnChart()
        {
            DistributedColumnChartModel model = new DistributedColumnChartModel();
            model.Colors = new List<string>() 
            {
                    "#008FFB",
                    "#00E396",
                    "#FEB019",
                    "#FF4560",
                    "#775DD0",
                    "#546E7A",
                    "#26a69a",
                    "#D10CE8" 
            };
            model.Datas = new List<int>() { 21, 22, 10, 28, 16, 21, 13, 30 };
            model.Categories = new List<Category> 
            {
                    new Category()
                    {
                        FirstName = "John",
                        LastName =  "Doe"
                    },
                    new Category()
                    {
                        FirstName = "Joe",
                        LastName =  "Smith"
                    }, 
                    new Category()
                    {
                        FirstName = "Jake",
                        LastName =  "Williams"
                    }, 
                    new Category()
                    {
                        FirstName = "Amber"
                    },
                    new Category()
                    {
                        FirstName = "Peter",
                        LastName =  "Brown"
                    },
                    new Category()
                    {
                        FirstName = "Mary",
                        LastName =  "Evans"
                    },
                    new Category()
                    {
                        FirstName = "David",
                        LastName =  "Wilson"
                    },
                    new Category()
                    {
                        FirstName = "Lily",
                        LastName =  "Roberts"
                    }
            };
            return View(model);
        }
    }
}
