using System.Collections.Generic;

namespace ConsoleAPI.Models
{
    public class Publications
    {
        public Aggregations aggregations { get; set; }
        public List<ResultPublication> results { get; set; }
        public Headers headers { get; set; }
    }
}
