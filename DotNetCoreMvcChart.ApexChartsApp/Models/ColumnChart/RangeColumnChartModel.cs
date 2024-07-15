namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class RangeColumnChartModel
    {
        public List<SeriesData1> SeriesData1 { get; set; }
        public List<SeriesData2> SeriesData2 { get; set; }

    }
    public class SeriesData1
    {
        public string X { get; set; }
        public List<int> Y { get; set; }
    }
    public class SeriesData2
    {
        public string X { get; set; }
        public List<int> Y { get; set; }
    }
}
