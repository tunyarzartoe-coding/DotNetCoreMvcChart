namespace DotNetCoreMvcChart.ApexChartsApp.Models.LineChart
{
    public class MissingDataLineChartModel
    {
        public List<int> Labels { get; set; }
        public List<MissingData> Series { get; set; }
    }
    public class MissingData 
    {
        public string Name { get; set; }
        public List<int?> Datas { get; set; }
    }
}
