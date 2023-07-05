using System.Collections.Generic;

namespace ConsoleAPI.Models
{
    public class Result
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string title { get; set; }
        public int product_id { get; set; }
        public string provider_id { get; set; }
        public string salable_sha { get; set; }
        public Company company { get; set; }
        public Category category { get; set; }
        public Brand brand { get; set; }
        public string model { get; set; }
        public Price price { get; set; }
        public string quantity { get; set; }
        public string created { get; set; }
        public string status { get; set; }
        public string provider_error_response { get; set; }
        public bool paused { get; set; }
        public string rejection_details { get; set; }
        public string shipping_type { get; set; }
        public string logistic_group { get; set; }
        public List<object> variant_features { get; set; }
        public List<Resource> resources { get; set; }
    }
}
