using System.Collections.Generic;

namespace ConsoleAPI.Models
{
    public class Shippings
    {
        public List<Header> headers { get; set; }
        public AggregationsShipping aggregations { get; set; }
    }
}
