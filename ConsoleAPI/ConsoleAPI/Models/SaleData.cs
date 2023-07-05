namespace ConsoleAPI.Models
{
    public class SaleData
    {
        public int cart_id { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public double unit_price { get; set; }
        public double total_price { get; set; }
        public string sku_garbarino { get; set; }
        public string sku_seller { get; set; }
        public bool warehousing { get; set; }
    }
}
