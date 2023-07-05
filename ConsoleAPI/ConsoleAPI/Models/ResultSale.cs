using System.Collections.Generic;

namespace ConsoleAPI.Models
{
    public class ResultSale
    {
        public int id { get; set; }
        public int cart_id { get; set; }
        public string created { get; set; }
        public CompanySale company { get; set; }
        public string bill_note_identifier { get; set; }
        public object credit_note_identifier { get; set; }
        public string shipping_type { get; set; }
        public string billing_address { get; set; }
        public string type { get; set; }
        public object reference_sale { get; set; }
        public Customer customer { get; set; }
        public BillingAddressDetails billing_address_details { get; set; }
        public string status { get; set; }
        public TotalsSale totals_sale { get; set; }
        public List<SoldItem> sold_items { get; set; }
        public DeliveryAddressDetails delivery_address_details { get; set; }
    }
}
