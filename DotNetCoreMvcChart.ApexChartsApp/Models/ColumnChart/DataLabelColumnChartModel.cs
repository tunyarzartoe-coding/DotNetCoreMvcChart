namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class DataLabelColumnChartModel
    {
        public List<string> Categories { get; set; }
        public List<DataLabelColumnData> DataLabelColumnData { get; set; }
    }
    public class DataLabelColumnData
    {
        public string Name { get; set; }
        public List<double> ColumnDatas { get; set; }
    }
}
