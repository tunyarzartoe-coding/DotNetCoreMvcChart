namespace DotNetCoreMvcChart.ApexChartsApp.Models.BarChart
{
    public class StackedBarChartModel
    {
        public List<StackedData> StackedDatas { get; set; }
        public List<int> Categories { get; set; }
    }
    public class StackedData
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
