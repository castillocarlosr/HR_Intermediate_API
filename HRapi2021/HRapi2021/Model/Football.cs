using System;
using System.Collections.Generic;
using System.Text;
using Nest;
using Newtonsoft.Json;

namespace HRapi2021.Model
{
    public class Football
    {
        [JsonProperty(PropertyName = "total_pages")]
        public string TotalPages { get; set; }

        [JsonProperty(PropertyName = "team1goals")]
        public string Team1Goals { get; set; }

        [JsonProperty(PropertyName = "team1")]
        public string Team1 { get; set; }
    }
}
