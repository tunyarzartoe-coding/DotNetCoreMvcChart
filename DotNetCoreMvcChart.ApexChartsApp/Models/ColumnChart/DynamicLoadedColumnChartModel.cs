namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class DynamicLoadedColumnChartModel
    {
        public List<string> Colors { get; set; }
        public List<ArrayData> Data { get; set; }
    }
    public class ArrayData
    {
        public int Y { get; set; }
        public List<QuarterData> Quarter { get; set; }
    }
    public class QuarterData
    {
        public string QuarterX { get; set; }
        public int QuarterY { get; set; }

    }
}
