using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Spell
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("spell")]
        public string SpellName { get; set; } = "unknown";

        [JsonProperty("type")]
        public string Type { get; set; } = "unknown";

        [JsonProperty("effect")]
        public string Effect { get; set; } = "unknown";
    }
}
