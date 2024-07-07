namespace DotNetCoreMvcChart.ApexChartsApp.Models.LineChart
{
    public class DashedLineChartModel
    {
        public List<SeriesData> SeriesData { get; set; }
        public List<string> Categories { get; set; }
    }
    public class SeriesData
    {
        public string Name { get; set; }
        public List<int> Datas { get; set;}
    }
}
