namespace ConsoleAPI.Models
{
    public class BillingAddressDetails
    {
        public string zip_code { get; set; }
        public int city_id { get; set; }
        public string street_number { get; set; }
        public string street_name { get; set; }
        public string phone { get; set; }
        public object city_name { get; set; }
        public object state_name { get; set; }
        public object building_floor { get; set; }
        public object building_room { get; set; }
    }
}
