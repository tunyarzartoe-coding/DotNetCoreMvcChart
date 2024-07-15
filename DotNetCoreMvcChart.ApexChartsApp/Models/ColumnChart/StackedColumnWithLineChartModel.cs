namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class StackedColumnWithLineChartModel
    {
        public List<string> Colors { get; set; }
        public List<SeriesDatas> SeriesDatas { get; set; }
    }
    public class SeriesDatas
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<double> Data { get; set; }
    }
}
