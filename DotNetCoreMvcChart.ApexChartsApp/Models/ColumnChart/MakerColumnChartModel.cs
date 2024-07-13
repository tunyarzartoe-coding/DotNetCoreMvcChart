namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class MakerColumnChartModel
    {
        public string Name { get; set; }
        public List<MakerData> Data { get; set; }
    }
    public class MakerData
    {
        public string X { get; set; }
        public int Y { get; set; }
        public List<Goals> Goals { get; set; }

    }
    public class Goals
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int StrokeHeight { get; set; }
        public int StrokeWidth { get; set; }
        public int StrokeDashArray { get; set; }
        public string StrokeLineCap { get; set; }
        public string StrokeColor { get; set; }
    }
}

