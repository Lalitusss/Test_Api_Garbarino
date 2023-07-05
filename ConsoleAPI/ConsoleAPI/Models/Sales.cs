using System.Collections.Generic;

namespace ConsoleAPI.Models
{
    public class Sales
    {
        public AggregationsSale aggregations { get; set; }
        public List<ResultSale> results { get; set; }
        public Headers headers { get; set; }
    }
}
