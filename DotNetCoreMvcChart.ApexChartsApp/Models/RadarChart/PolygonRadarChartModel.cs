namespace DotNetCoreMvcChart.ApexChartsApp.Models.RadarChart
{
    public class PolygonRadarChartModel
    {
        public List<Series> SeriesData { get; set; }
        public List<string> Categories { get; set; }
    }
    public class Series
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
