namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class DataColorColumnChartModel
    {
        public string Name { get; set; }
        public List<ColumnDataColors> Datas { get; set; }
        
    }
    public class ColumnDataColors
    {
        public string X { get; set; }
        public int Y { get; set; }
        public string FillColor { get; set; }
        public string StrokeColor { get; set; }

    }
}
