using System.Collections.Generic;

namespace ConsoleAPI.Models
{
    public class Publication
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public string salable_sha { get; set; }
        public string title { get; set; }
        public string sku { get; set; }
        public Category category { get; set; }
        public Brand brand { get; set; }
        public string model { get; set; }
        public Price price { get; set; }
        public string quantity { get; set; }
        public string created { get; set; }
        public string status { get; set; }
        public string rejection_details { get; set; }
        public string origin { get; set; }
        public string identifier_value { get; set; }
        public string identifier_type { get; set; }
        public string purchase_type { get; set; }
        public int manufacturer_warranty { get; set; }
        public SaleTaxType sale_tax_type { get; set; }
        public InternalTaxType internal_tax_type { get; set; }
        public string provider_error_response { get; set; }
        public string shipping_type { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public double grossWeight { get; set; }
        public double depth { get; set; }
        public List<Feature> features { get; set; }
        public List<VariantFeature> variant_features { get; set; }
        public List<Resource> resources { get; set; }
    }
}
