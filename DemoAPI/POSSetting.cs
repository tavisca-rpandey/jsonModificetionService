using Newtonsoft.Json;

namespace DemoAPI
{
   
    [Serializable]
    public class POSSetting
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dedupeStrategy")]
        public string DedupeStrategy { get; set; }

        [JsonProperty("scheduleChangeCancel")]
        public ScheduleChangeCancel ScheduleChangeCancel { get; set; }

       
        [JsonProperty("isScheduleChangeDuringBookEnabled")]
        public bool IsScheduleChangeDuringBookEnabled { get; set; }
    }
    [Serializable]
    public class ScheduleChangeCancel
    {
        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("cancelTimeWindow")]
        public string CancelTimeWindow { get; set; }

        [JsonProperty("airlinesAllowed")]
        public List<string> AirlinesAllowed { get; set; }
    }
}
