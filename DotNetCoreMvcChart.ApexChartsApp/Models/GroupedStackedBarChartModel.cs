namespace DotNetCoreMvcChart.ApexChartsApp.Models
{
    public class GroupedStackedBarChartModel
    {
        public List<SeriesData> Series { get; set; }
    }
    public class SeriesData
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public List<int> Datas { get; set; }
    }
}
