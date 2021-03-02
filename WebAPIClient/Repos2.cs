using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAPIClient
{
    class Repos2
    {
        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("team1goals")]
        public string Team1Goals { get; set; }

        [JsonPropertyName("team2goals")]
        public string Team2Goals { get; set; }
        /* try to bring in object like in the other model
        then convert using lambda to get parameter of what's needed
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        */

    }
}
