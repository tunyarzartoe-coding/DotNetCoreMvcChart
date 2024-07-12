namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class GroupedColumnChartModel
    {
        public string  Name { get; set; }
        public List<GroupedData> GroupedData { get; set; }
    }
    public class GroupedData
    {
        public string X { get; set; }
        public int Y { get; set; }
    }
}
