﻿using DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart;
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
        public IActionResult DumbbellColumnChart()
        {
            DumbbellColumnChartModel model = new DumbbellColumnChartModel();
            model.Datas = new List<DumbbellColumnDatas>()
            {
                new DumbbellColumnDatas()
                {
                    X = "2008",
                    Y = new List<int>(){ 2800, 4500 }
                },
                new DumbbellColumnDatas()
                {
                    X = "2009",
                    Y = new List<int>(){ 3200, 4100 }
                },
                new DumbbellColumnDatas()
                {
                    X = "2010",
                    Y = new List<int>(){ 2950, 7800 }
                },
                new DumbbellColumnDatas()
                {
                    X = "2011",
                    Y = new List<int>(){ 3000, 4600 }
                },
                new DumbbellColumnDatas()
                {
                    X = "2012",
                    Y = new List<int>(){ 3500, 4100 }
                },
                new DumbbellColumnDatas()
                {
                    X = "2013",
                    Y = new List<int>(){ 4500, 6500 }
                },
                new DumbbellColumnDatas()
                {
                    X = "2014",
                    Y = new List<int>(){ 4100, 5600 }
                }
            };
            return View(model);
        }
        public IActionResult DynamicLoadedColumnChart()
        {
            DynamicLoadedColumnChartModel model = new DynamicLoadedColumnChartModel();
            model.Colors = new List<string>()
            {
                    "#008FFB", "#00E396", "#FEB019", "#FF4560", "#775DD0", "#00D9E9", "#FF66C3"
            };
            model.Data = new List<ArrayData>
            {
                new ArrayData()
                {
                    Y = 400,
                    Quarter = new List<QuarterData>()
                    {
                        new QuarterData()
                        {
                            QuarterX ="Q1",
                            QuarterY =120
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q2",
                            QuarterY =90
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q3",
                            QuarterY =100
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q4",
                            QuarterY =90
                        }
                    }

                },
                new ArrayData()
                {
                    Y = 430,
                    Quarter = new List<QuarterData>()
                    {
                        new QuarterData()
                        {
                            QuarterX ="Q1",
                            QuarterY =120
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q2",
                            QuarterY =110
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q3",
                            QuarterY =90
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q4",
                            QuarterY =110
                        }
                    }

                },
                new ArrayData()
                {
                    Y = 448,
                    Quarter = new List<QuarterData>()
                    {
                        new QuarterData()
                        {
                            QuarterX ="Q1",
                            QuarterY =70
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q2",
                            QuarterY =100
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q3",
                            QuarterY =140
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q4",
                            QuarterY =138
                        }
                    }

                },
                new ArrayData()
                {
                    Y = 470,
                    Quarter = new List<QuarterData>()
                    {
                        new QuarterData()
                        {
                            QuarterX ="Q1",
                            QuarterY =150
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q2",
                            QuarterY =60
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q3",
                            QuarterY =190
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q4",
                            QuarterY =70
                        }
                    }

                },
                new ArrayData()
                {
                    Y = 540,
                    Quarter = new List<QuarterData>()
                    {
                        new QuarterData()
                        {
                            QuarterX ="Q1",
                            QuarterY =120
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q2",
                            QuarterY =120
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q3",
                            QuarterY =130
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q4",
                            QuarterY =170
                        }
                    }

                },
                new ArrayData()
                {
                    Y = 580,
                    Quarter = new List<QuarterData>()
                    {
                        new QuarterData()
                        {
                            QuarterX ="Q1",
                            QuarterY =170
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q2",
                            QuarterY =130
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q3",
                            QuarterY =120
                        },
                        new QuarterData()
                        {
                            QuarterX ="Q4",
                            QuarterY =160
                        }
                    }

                },
            };
            return View(model);
        }
        public IActionResult GroupedStackedColumnChart()
        {
            GroupedStackedColumnChartModel model = new GroupedStackedColumnChartModel();
            model.Categories = new List<string>()
            {
                    "Online advertising",
                    "Sales Training",
                    "Print advertising",
                    "Catalogs",
                    "Meetings",
                    "Public relations"
            };
            model.SeriesData = new List<GroupedSeriesData>
            {
                new GroupedSeriesData()
                {
                    Name = "Q1 Budget",
                    Group = "budget",
                    Data = new List<int> (){ 44000, 55000, 41000, 67000, 22000, 43000 }
                },
                new GroupedSeriesData()
                {
                    Name = "Q1 Actual",
                    Group = "actual",
                    Data = new List<int> (){ 48000, 50000, 40000, 65000, 25000, 40000 }
                },
                new GroupedSeriesData()
                {
                    Name = "Q2 Budget",
                    Group = "budget",
                    Data = new List<int> (){ 13000, 36000, 20000, 8000, 13000, 27000 }
                },
                new GroupedSeriesData()
                {
                    Name = "Q2 Actual",
                    Group = "actual",
                    Data = new List<int> (){ 20000, 40000, 25000, 10000, 12000, 28000 }
                },
            };
            return View(model);
        }
        public IActionResult RangeColumnChart()
        {
            RangeColumnChartModel model = new RangeColumnChartModel();
            model.SeriesData1 = new List<SeriesData1>
            {
                new SeriesData1()
                {
                    X="Team A",
                    Y= new List<int>(){ 1, 5 }
                },
                new SeriesData1()
                {
                    X="Team B",
                    Y= new List<int>(){4,6}
                },
                new SeriesData1()
                {
                    X="Team C",
                    Y= new List<int>(){5,8}
                },
                new SeriesData1()
                {
                    X="Team D",
                    Y= new List<int>(){3,11}
                },
            };
            model.SeriesData2 = new List<SeriesData2>
            {
                new SeriesData2()
                {
                    X="Team A",
                    Y= new List<int>(){ 2, 6 }
                },
                new SeriesData2()
                {
                    X="Team B",
                    Y= new List<int>(){1,3}
                },
                new SeriesData2()
                {
                    X="Team C",
                    Y= new List<int>(){7,8}
                },
                new SeriesData2()
                {
                    X="Team D",
                    Y= new List<int>(){5,9}
                },
            };
            return View(model);
        }
        public IActionResult StackedColumnChart()
        {
            StackedColumnChartModel model = new StackedColumnChartModel();
            model.Categories = new List<string>()
            {
                    "01/01/2011 GMT", "01/02/2011 GMT", "01/03/2011 GMT", "01/04/2011 GMT",
                    "01/05/2011 GMT", "01/06/2011 GMT"
            };
            model.SeriesData = new List<SeriesData>()
            {
                new SeriesData()
                {
                    Name = "PRODUCT A",
                    Data = new List<int>(){ 44, 55, 41, 67, 22, 43 }
                },
                new SeriesData()
                {
                    Name = "PRODUCT B",
                    Data = new List<int>(){ 13, 23, 20, 8, 13, 27 }
                },
                new SeriesData()
                {
                    Name = "PRODUCT C",
                    Data = new List<int>(){ 11, 17, 15, 15, 21, 14 }
                },
                new SeriesData()
                {
                    Name = "PRODUCT D",
                    Data = new List<int>(){ 21, 7, 25, 13, 22, 8 }
                },
            };
            return View(model);
        }
        public IActionResult FullStackedColumnChart()
        {
            FullStackedColumnChartModel model = new FullStackedColumnChartModel();
            model.Categories = new List<string>()
            {
                    "2011 Q1", "2011 Q2", "2011 Q3", "2011 Q4", "2012 Q1", "2012 Q2",
                    "2012 Q3", "2012 Q4"
            };
            model.SeriesData = new List<FullSeriesData>()
            {
                new FullSeriesData()
                {
                    Name = "PRODUCT A",
                    Data = new List<int>(){ 44, 55, 41, 67, 22, 43, 21, 49 }
                },
                new FullSeriesData()
                {
                    Name = "PRODUCT B",
                    Data = new List<int>(){ 13, 23, 20, 8, 13, 27, 33, 12 }
                },
                new FullSeriesData()
                {
                    Name = "PRODUCT C",
                    Data = new List<int>(){ 11, 17, 15, 15, 21, 14, 15, 13 }
                }
            };
            return View(model);
        }
        public IActionResult StackedColumnWithLineChart()
        {
            StackedColumnWithLineChartModel model = new StackedColumnWithLineChartModel();
            model.Colors = new List<string>()
            {
                "#6a6ba5",
                "#f9a867",
                "#2a6b9b",
                "#6c98b7",
                "#abc4d6",
                "#d5e2eb"
            };
            model.SeriesDatas = new List<SeriesDatas>()
            {
                new SeriesDatas()
                {
                    Name = "Line",
                    Type = "line",
                    Data = new List<double>()
                    { 
                        37,
                        38.3,
                        33.01,
                        30,
                        29.7,
                        30,
                        35.2,
                        44,
                        45,
                        41,
                        22,
                        22.5,
                        29.1,
                        25.5,
                        41.2,
                        43.8,
                        39,
                        23,
                        26,
                        22,
                        34,
                        37,
                        43,
                        41,
                        17
                    }
                },
                new SeriesDatas()
                {
                    Name = "Bar1",
                    Type = "bar",
                    Data = new List<double>()
                    {
                        -1.57,
                        -1.83,
                        -0.29,
                        2,
                        0.23,
                        3,
                        0,
                        -0.77,
                        0,
                        0,
                        0,
                        -0.16,
                        -0.5,
                        -0.75,
                        -0.93,
                        -0.93,
                        -0.45,
                        0,
                        0,
                        -0.23,
                        -0.95,
                        -1.12,
                        -0.51,
                        0.76
                    }
                },
                new SeriesDatas()
                {
                    Name = "Bar2",
                    Type = "bar",
                    Data = new List<double>()
                    {
                        -2.99,
                        -0.43,
                        0.39,
                        2.8,
                        0.23,
                        1.2,
                        -0.06,
                        -2.96,
                        -2.74,
                        -2.58,
                        -1.79,
                        -2.16,
                        -1.9,
                        -1.75,
                        -2,
                        -2.16,
                        -1.75,
                        -1.9,
                        -2.74,
                        -2.58,
                        -3.8,
                        -1.24,
                        -0.01,
                        1.89
                    }
                },
                new SeriesDatas()
                {
                    Name = "Bar3",
                    Type = "bar",
                    Data = new List<double>()
                    {
                        0.09,
                        4,
                        4.83,
                        6.86,
                        3.86,
                        5,
                        1.7,
                        -1.21,
                        0,
                        0.02,
                        0.07,
                        -0.15,
                        -0.09,
                        0,
                        -0.61,
                        -1.75,
                        0,
                        -0.43,
                        -1.5,
                        -0.66,
                        -3.06,
                        0.06,
                        0.15,
                        1.48
                    }
                },
                new SeriesDatas()
                {
                    Name = "bar4",
                    Type = "bar",
                    Data = new List<double>()
                    {
                        5.95,
                        5.86,
                        0.92,
                        -1.2,
                        -2.73,
                        -0.32,
                        0.12,
                        -0.55,
                        0.78,
                        0,
                        -1.73,
                        -2.52,
                        -1.26,
                        -0.8,
                        -0.75,
                        0,
                        -3,
                        0,
                        0.29,
                        0.3
                    }
                },
            };
            return View(model);
        }
    }
}
