namespace DotNetCoreMvcChart.ApexChartsApp.Models.BarChart
{
    public class PatternedBarChartModel
    {
        public List<PatternedData> PatternedData { get; set; }
        public List<int> Categories { get; set; }
    }
    public class PatternedData
    {
        public string Name { get; set;}
        public List<int> Data { get; set;}
    }
}
