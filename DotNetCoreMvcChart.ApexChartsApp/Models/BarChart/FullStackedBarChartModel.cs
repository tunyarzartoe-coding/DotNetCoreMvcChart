namespace DotNetCoreMvcChart.ApexChartsApp.Models.BarChart
{
    public class FullStackedBarChartModel
    {
        public List<FullStackedData> FullStackedDatas { get; set; }
        public List<int> Categories { get; set; }
    }
    public class FullStackedData
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
