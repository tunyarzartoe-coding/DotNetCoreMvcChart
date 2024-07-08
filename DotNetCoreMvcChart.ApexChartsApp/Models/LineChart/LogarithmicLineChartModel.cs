namespace DotNetCoreMvcChart.ApexChartsApp.Models.LineChart
{
    public class LogarithmicLineChartModel
    {
        public List<LineData> Datas { get; set; }
    }
    public class LineData
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
