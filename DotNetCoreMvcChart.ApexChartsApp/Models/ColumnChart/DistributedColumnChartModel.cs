namespace DotNetCoreMvcChart.ApexChartsApp.Models.ColumnChart
{
    public class DistributedColumnChartModel
    {
        public List<string> Colors { get; set; }
        public List<int> Datas { get; set; }
        public List<Category> Categories { get; set; }
    }
    public class Category
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
