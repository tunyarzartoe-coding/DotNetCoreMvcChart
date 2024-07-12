namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class BasicColumnChartModel
    {
        public List<string> Categories { get; set; }
        public List<ColumnData> ColumnData { get; set; }
    }
    public class ColumnData
    {
        public string Name { get; set; }
        public List<int> ColumnDatas { get; set; }
    }
}
