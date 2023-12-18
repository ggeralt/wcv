using Newtonsoft.Json;

namespace ClassLibrary.Model
{
    public class TeamEvent
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("type_of_event")]
        public String TypeOfEvent { get; set; }

        [JsonProperty("player")]
        public String Player { get; set; }

        [JsonProperty("time")]
        public String Time { get; set; }
    }
}
