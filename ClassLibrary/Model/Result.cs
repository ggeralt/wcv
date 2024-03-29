﻿using Newtonsoft.Json;

namespace ClassLibrary.Model
{
    public class Result
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("draws")]
        public long Draws { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        [JsonProperty("goals_scored")]
        public long GoalsScored { get; set; }

        [JsonProperty("goals_taken")]
        public long GoalsTaken { get; set; }

        [JsonProperty("goal_differential")]
        public long GoalDifferential { get; set; }

        public override string ToString() => Country + " (" + FifaCode + ")";
    }
}
