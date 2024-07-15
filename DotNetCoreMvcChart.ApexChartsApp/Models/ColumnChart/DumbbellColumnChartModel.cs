namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class DumbbellColumnChartModel
    {
     public List<DumbbellColumnDatas>  Datas { get; set; }
    }
    public class DumbbellColumnDatas
    {
        public string X { get; set; }
        public List<int> Y { get; set; }
    }
}
