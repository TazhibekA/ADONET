using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Faculty
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = "unknown";

        [JsonProperty("mascot")]
        public string Mascot { get; set; } = "unknown";

        [JsonProperty("headOfHouse")]
        public string HeadOfHouse { get; set; } = "unknown";

        [JsonProperty("houseGhost")]
        public string HouseGhost { get; set; } = "unknown";

        [JsonProperty("founder")]
        public string Founder { get; set; } = "unknown";

        [JsonProperty("__v")]
        public int V { get; set; }  

        [JsonProperty("school")]
        public string School { get; set; } = "unknown";

        [JsonProperty("members")]
        public IList<string> Members { get; set; }  

        [JsonProperty("values")]
        public IList<string> Values { get; set; }  

        [JsonProperty("colors")]
        public IList<string> Colors { get; set; }
    }
}
