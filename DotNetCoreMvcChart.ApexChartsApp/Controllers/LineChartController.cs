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

        public IActionResult GradientLineChart()
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
            model.Series = new List<Datas>()
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

        public IActionResult LineWithImageChart()
        {
            LineWithImageChartModel model = new LineWithImageChartModel();
            model.Categories = new List<string>() { "1990", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005" };
            model.Series = new List<LineDatas>()
            {
                new LineDatas()
                {
                    Name = "Dataset 2",
                    Data =new List<int> { 10, 5, 20, 13, 15, 12, 13, 24, 24, 34, 7, 15, 10, 9, 26 }
                }
            };
            return View(model);
        }

        public IActionResult MissingDataLineChart()
        {
            MissingDataLineChartModel model = new MissingDataLineChartModel();
            model.Series = new List<MissingData>
            {
                new MissingData()
                {
                    Name = "Peter",
                    Datas = new List<int?> { 5, 5, 10, 8, 7, 5, 4, null, null, null, 10, 10, 7, 8, 6, 9 }
                },
                new MissingData()
                {
                    Name = "Johnny",
                    Datas = new List<int?> { 10, 15, null, 12, null, 10, 12, 15, null, null, 12, null, 14, null, null, null }
                },
                new MissingData()
                {
                    Name = "David",
                    Datas = new List<int?> { null, null, null, null, 3, 4, 1, 3, 4, 6, 7, 9, 5, null, null, null }
                },
            };
            model.Labels = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            return View(model);
        }
        public IActionResult LogarithmicLineChart()
        {
            LogarithmicLineChartModel model = new LogarithmicLineChartModel();
            model.Datas = new List<LineData>()
            {
                new LineData()
                {
                    X = 1994,
                    Y = 2543763
                },
                new LineData()
                {
                    X = 1995,
                    Y = 4486659
                },
                new LineData()
                {
                    X = 1996,
                    Y = 7758386
                },
                new LineData()
                {
                    X = 1997,
                    Y = 12099221
                },
                new LineData()
                {
                    X = 1998,
                    Y = 18850762
                },
                new LineData()
                {
                    X = 1999,
                    Y = 28153765
                },
                new LineData()
                {
                    X = 2000,
                    Y = 41479495
                },
                new LineData()
                {
                    X = 2001,
                    Y = 50229224
                },
                new LineData()
                {
                    X = 2002,
                    Y = 2543763
                },
                new LineData()
                {
                    X = 2003,
                    Y = 78143598
                },
                new LineData()
                {
                    X = 2004,
                    Y = 91332777
                },
                new LineData()
                {
                    X = 2005,
                    Y = 103010128
                },
                new LineData()
                {
                    X = 2006,
                    Y = 116291681
                },
                new LineData()
                {
                    X = 2007,
                    Y = 137322698
                },
                new LineData()
                {
                    X = 2008,
                    Y = 157506752
                },
                new LineData()
                {
                    X = 2009,
                    Y = 176640381
                },
                new LineData()
                {
                    X = 2010,
                    Y = 202320297
                },
                new LineData()
                {
                    X = 2011,
                    Y = 223195735
                },
                new LineData()
                {
                    X = 2012,
                    Y = 249473624
                },
                new LineData()
                {
                    X = 2013,
                    Y = 272842810
                },
                new LineData()
                {
                    X = 2014,
                    Y = 295638556
                },
                new LineData()
                {
                    X = 2015,
                    Y = 318599615
                },
                new LineData()
                {
                    X = 2016,
                    Y = 342497123
                }
            };
            return View(model);
        }
        public IActionResult RealtimeLineChart()
        {
            return View();
        }
    }
}
