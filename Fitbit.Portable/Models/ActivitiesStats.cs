using Newtonsoft.Json;

namespace FitbitSNHP.Models
{
    public class ActivitiesStats
    {
        [JsonProperty("best")]
        public BestStats Best { get; set; }

        [JsonProperty("lifetime")]
        public LifetimeStats Lifetime { get; set; }
    }
}