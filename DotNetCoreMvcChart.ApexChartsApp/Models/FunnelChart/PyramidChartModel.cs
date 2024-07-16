namespace DotNetCoreMvcChart.ApexChartsApp.Models.FunnelChart
{
    public class PyramidChartModel
    {
        public List<SeriesDatas> SeriesData { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Colors { get; set; }
    }
    public class SeriesDatas
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
