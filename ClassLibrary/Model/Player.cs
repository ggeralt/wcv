using Newtonsoft.Json;

namespace ClassLibrary.Model
{
    public class Player
    {
        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long? ShirtNumber { get; set; }

        [JsonProperty("position")]
        public String Position { get; set; }
        public int Goals { get; set; }
        public int Cards { get; set; }
        public String Image { get; set; }
        public bool Favorite { get; set; }
    }
}
