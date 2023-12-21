using Newtonsoft.Json;

namespace ClassLibrary.Model
{
    public class Player
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long? ShirtNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
        public int Goals { get; set; }
        public int Cards { get; set; }
        public string Image { get; set; }
        public bool Favorite { get; set; }
    }
}
