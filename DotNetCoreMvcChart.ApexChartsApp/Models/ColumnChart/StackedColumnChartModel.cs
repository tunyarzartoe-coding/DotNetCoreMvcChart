namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class StackedColumnChartModel
    {
        public List<SeriesData> SeriesData { get; set; }
        public List<string> Categories { get; set; }    
    }
    public class SeriesData
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
