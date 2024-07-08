namespace DotNetCoreMvcChart.ApexChartsApp.Models.LineChart
{
    public class DataLabelLineChartModel
    {
        public List<string> Categories { get; set; }
        public List<Datas> Series { get; set; }
    }
    public class Datas
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
