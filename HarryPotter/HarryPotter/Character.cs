using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 namespace HarryPotter
{
    public class Character
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = "unknown";

        [JsonProperty("role")]
        public string Role { get; set; } = "unknown";

        [JsonProperty("house")]
        public string House { get; set; } = "unknown";

        [JsonProperty("school")]
        public string School { get; set; } = "unknown";

        [JsonProperty("__v")]
        public int V { get; set; }

        [JsonProperty("ministryOfMagic")]
        public bool MinistryOfMagic { get; set; }

        [JsonProperty("orderOfThePhoenix")]
        public bool OrderOfThePhoenix { get; set; }

        [JsonProperty("dumbledoresArmy")]
        public bool DumbledoresArmy { get; set; }

        [JsonProperty("deathEater")]
        public bool DeathEater { get; set; }

        [JsonProperty("bloodStatus")]
        public string BloodStatus { get; set; } = "unknown";

        [JsonProperty("species")]
        public string Species { get; set; } = "unknown";
    }
}
