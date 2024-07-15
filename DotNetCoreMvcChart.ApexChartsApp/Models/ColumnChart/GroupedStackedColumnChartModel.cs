namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class GroupedStackedColumnChartModel
    {
        public List<GroupedSeriesData> SeriesData { get; set; }
        public List<string> Categories { get; set; }
    }
    public class GroupedSeriesData
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public List<int> Data { get; set; }
    }
}
