using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarWars
{
    public class Planet
    {
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rotation_period")]
        public string RotationPeriod { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("diameter")]
        public string Diameter { get; set; }

        [JsonProperty("climate")]
        public string Climate { get; set; }

        [JsonProperty("gravity")]
        public string Gravity { get; set; }

        [JsonProperty("terrain")]
        public string Terrain { get; set; }

        [JsonProperty("surface_water")]
        public string SurfaceWater { get; set; }

        [JsonProperty("population")]
        public string Population { get; set; }

        [JsonProperty("residents")]
        public IList<string> Residents { get; set; }

        [JsonProperty("films")]
        public IList<string> Films { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public void SetId()
        {
            string idstring = Regex.Match(Url, @"\d+").Value;
            int id = Int32.Parse(idstring);
            Id = id;
        }
    }


}
