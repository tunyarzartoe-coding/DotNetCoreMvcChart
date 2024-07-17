namespace DotNetCoreMvcChart.ApexChartsApp.Models.RadarChart
{
    public class MultipleRadarChartModel
    {
        public List<SeriesDatas> SeriesDatas { get; set; }
        public List<string> Categories { get; set; }
    }
    public class SeriesDatas
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
