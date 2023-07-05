namespace ConsoleAPI.Models
{
    public class CompanyPublication
    {
        public int id { get; set; }
        public string legal_name { get; set; }
        public string collector_type { get; set; }
        public bool enable_for_editing_prices { get; set; }
    }
}
