namespace SampleMvccApiClient.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        public string StockName { get; set; }
        public string StockDescription { get; set; }
        public double UnitPrice { get; set; }
    }
}
