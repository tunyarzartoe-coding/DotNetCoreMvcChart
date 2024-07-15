namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class FullStackedColumnChartModel
    {
        public List<FullSeriesData> SeriesData { get; set; }
        public List<string> Categories { get; set; }
    }
    public class FullSeriesData
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
