namespace DotNetCoreMvcChart.ApexChartsApp.Models.BarChart
{
    public class ReversedBarChartModel
    {
        public List<string> Categories { get; set; }
        public List<ReversedBarData> Data { get; set; }
    }
    public class ReversedBarData
    {
        public List<int> Data { get; set; }
    }
}
