namespace DotNetCoreMvcChart.ApexChartsApp.Models.BarChart
{
    public class NegativeBarChartModel
    {
        public List<NegativeBarChartData> NegativeBarChartDatas { get; set; }
        public List<string> Categories { get; set; }
    }
    public class NegativeBarChartData
    {
        public string Name { get; set; }
        public List<double> Data { get; set; }
    }
}
