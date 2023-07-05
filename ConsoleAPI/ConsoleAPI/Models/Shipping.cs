using System.Collections.Generic;

namespace ConsoleAPI.Models
{
    public class Shipping
    {
        public Response response { get; set; }
        public string uri { get; set; }
        public List<Error> errors { get; set; }
        public long time_stamp { get; set; }
    }
}
