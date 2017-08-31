using System;
using Newtonsoft.Json;

namespace FitbitSNHP.Models
{
    public class DistanceStats
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}