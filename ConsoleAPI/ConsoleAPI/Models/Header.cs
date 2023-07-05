using System;

namespace ConsoleAPI.Models
{
    public class Header
    {
        public string trackingId { get; set; }
        public string customerTrackingId { get; set; }
        public string productDescription { get; set; }
        public DateTime deliveryDate { get; set; }
        public DateTime receptionDateFrom { get; set; }
        public DateTime receptionDateTo { get; set; }
        public DateTime? committedDate { get; set; }
        public int warehouseId { get; set; }
        public string warehouseDescription { get; set; }
    }
}
