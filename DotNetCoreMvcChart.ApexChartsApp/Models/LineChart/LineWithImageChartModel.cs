namespace DotNetCoreMvcChart.ApexChartsApp.Models.LineChart
{
    public class LineWithImageChartModel
    {
        public List<string> Categories { get; set; }
        public List<LineDatas> Series { get; set; }
    }
    public class LineDatas
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
