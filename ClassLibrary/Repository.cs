﻿using ClassLibrary.Model;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;

namespace ClassLibrary
{
    public class Repository
    {
        private static string PATH = "../../../";
        private static string SETTINGS_PATH = PATH + "settings.txt";
        private static string TEAM_PATH = PATH + "team.txt";
        private static string PLAYERS_PATH = PATH + "players.txt";

        private static string GENDER;
        private static string LANGUAGE;
        private static string PICKED_CHAMPIONSHIP;
        private static string PICKED_FIFA_CODE;

        private static string MALE_CHAMPIONSHIP_URL = "https://worldcup-vua.nullbit.hr/men/teams/results";
        private static string FEMALE_CHAMPIONSHIP_URL = "https://worldcup-vua.nullbit.hr/women/teams/results";
        private static string FEMALE_MATCH_FILE = PATH + "JsonData/women/matches.json";

        private static string MALE_MATCH_DETAILS_URL = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=";
        private static string FEMALE_MATCH_DETAILS_URL = "https://worldcup-vua.nullbit.hr/women/matches/country?fifa_code=";

        private static string WPF_PICKED_GENDER;
        private static string WPF_PICKED_LANGUAGE;
        private static string WPF_PICKED_SCREENSIZE;

        private static string WPF_FAVORITE_TEAM;

        private static string WPF_SETTINGS_PATH = PATH + "wpfsettings.txt";
        private static string WPF_FAVORITETEAM_PATH = PATH + "wpffavoriteteam.txt";

        public static void SaveSettings(Settings settings)
        {
            using (StreamWriter writer = new StreamWriter(SETTINGS_PATH))
            {
                writer.Write(settings.Gender);
                writer.Write(Environment.NewLine);
                writer.Write(settings.Language);
            }

            GENDER = settings.Gender.ToString();
            LANGUAGE = settings.Language.ToString();
        }

        public static string LoadSettings()
        {
            if (!File.Exists(SETTINGS_PATH))
                File.AppendAllText(SETTINGS_PATH, "");

            if (!File.Exists(TEAM_PATH))
                File.AppendAllText(TEAM_PATH, "");

            List<string> settings = new List<string>();

            if (string.IsNullOrEmpty(GENDER) || string.IsNullOrEmpty(LANGUAGE))
            {
                using (StreamReader reader = new StreamReader(SETTINGS_PATH))
                {
                    while (!reader.EndOfStream)
                        settings.Add(reader.ReadLine());

                    if (settings.Count > 0)
                    {
                        GENDER = settings[0];
                        LANGUAGE = settings[1];
                    }
                }
            }

            if (String.IsNullOrEmpty(PICKED_FIFA_CODE))
            {
                List<string> info = new List<string>();
                using (StreamReader reader = new StreamReader(TEAM_PATH))
                {
                    while (!reader.EndOfStream)
                        info.Add(reader.ReadLine());
                }

                if (info.Count != 0)
                {
                    string[] details = info[0].Split('(');
                    string code = details[1].Substring(0, 3);
                    PICKED_FIFA_CODE = code;
                }
            }

            if (GENDER == null || LANGUAGE == null)
            {
                return "input_settings";
            }
            else if (string.IsNullOrEmpty(PICKED_FIFA_CODE))
            {
                return "input_favorite_team";
            }

            return "no_input_needed";
        }

        public static async Task<List<Team>> GetTeams()
        {
            LoadSettings();
            string path;

            if (PICKED_CHAMPIONSHIP == "Male")
                path = MALE_CHAMPIONSHIP_URL;
            else
                path = FEMALE_CHAMPIONSHIP_URL;

            RestResponse<Team> restResponse = await GetTeamData(path);
            List<Team> teams = DeserialiseData(restResponse);
            return teams;
        }

        public static async Task<List<Model.Match>> GetMatch()
        {
            string pickedPath;

            if (PICKED_CHAMPIONSHIP == "Male")
                pickedPath = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=";
            else
                pickedPath = "https://worldcup-vua.nullbit.hr/women/matches/country?fifa_code=";

            RestResponse<Model.Match> restResponse = await GetMatchData(pickedPath + PICKED_FIFA_CODE);
            List<Model.Match> matches = DeserialiseData(restResponse);

            return matches;
        }

        private static Task<RestResponse<Model.Match>> GetMatchData(string match)
        {
            RestClient restClient = new RestClient(match);
            return restClient.ExecuteAsync<Model.Match>(new RestRequest());
        }

        public static void SaveFavoritePlayers(List<string> favorites)
        {
            using (StreamWriter writter = new StreamWriter(PLAYERS_PATH))
            {
                foreach (string favorite in favorites)
                {
                    writter.Write(favorite);
                    writter.Write(Environment.NewLine);
                }
            }
        }

        public static List<string> LoadFavoritePlayers()
        {
            List<string> favoritePlayers = new List<string>();

            if (!File.Exists(PLAYERS_PATH))
                File.AppendAllText(PLAYERS_PATH, "");

            using (StreamReader reader = new StreamReader(PLAYERS_PATH))
            {
                while (!reader.EndOfStream)
                    favoritePlayers.Add(reader.ReadLine());
            }

            return favoritePlayers;
        }

        private static Task<RestResponse<Team>> GetTeamData(string path)
        {
            RestClient restClient = new RestClient(path);
            return restClient.ExecuteAsync<Team>(new RestRequest());
        }

        private static List<T> DeserialiseData<T>(RestResponse<T> restResponse)
        {
            return JsonConvert.DeserializeObject<List<T>>(restResponse.Content);
        }

        public static void SaveFavoriteTeam(Team favoriteTeam)
        {
            PICKED_FIFA_CODE = favoriteTeam.FifaCode;
            using (StreamWriter writter = new StreamWriter(TEAM_PATH))
                writter.Write(favoriteTeam);
        }

        public static void SaveWPFFavoriteTeam(WPFSettings wpfSettings)
        {
            WPF_FAVORITE_TEAM = wpfSettings.favoriteTeam;
            using (StreamWriter writter = new StreamWriter(WPF_FAVORITETEAM_PATH))
                writter.WriteLine(WPF_FAVORITE_TEAM);
        }

        public static Task<HashSet<Match>> LoadMatches(string fifa_code)
        {
            if (WPF_PICKED_GENDER == "Male")
            {
                return Task.Run(() =>
                {
                    var apiClient = new RestClient(MALE_MATCH_DETAILS_URL + fifa_code);
                    var response = apiClient.Execute<HashSet<Match>>(new RestRequest());
                    return JsonConvert.DeserializeObject<HashSet<Match>>(response.Content);
                });
            }
            else
            {
                return Task.Run(() =>
                {
                    var apiClient = new RestClient(FEMALE_MATCH_DETAILS_URL + fifa_code);
                    var response = apiClient.Execute<HashSet<Match>>(new RestRequest());
                    return JsonConvert.DeserializeObject<HashSet<Match>>(response.Content);

                    /*using (StreamReader reader = new StreamReader(FEMALE_MATCH_FILE))
                    {
                        string json = reader.ReadToEnd();
                        return JsonConvert.DeserializeObject<HashSet<Match>>(json);
                    }*/
                });
            }
        }

        public static Task<HashSet<Result>> LoadMatchResults()
        {
            LoadWPFSettings();

            if (WPF_PICKED_GENDER == "Male")
            {
                return Task.Run(() =>
                {
                    var apiClient = new RestClient(MALE_CHAMPIONSHIP_URL);
                    var response = apiClient.Execute<HashSet<Result>>(new RestRequest());
                    return JsonConvert.DeserializeObject<HashSet<Result>>(response.Content);
                });
            }
            else
            {
                return Task.Run(() =>
                {
                    var apiClient = new RestClient(FEMALE_CHAMPIONSHIP_URL);
                    var response = apiClient.Execute<HashSet<Result>>(new RestRequest());
                    return JsonConvert.DeserializeObject<HashSet<Result>>(response.Content);
                });
            }
        }

        public static void SaveWPFSettings(WPFSettings wpfSettings)
        {
            WPF_PICKED_GENDER = wpfSettings.selectedGender;
            WPF_PICKED_LANGUAGE = wpfSettings.selectedLanguage;
            WPF_PICKED_SCREENSIZE = wpfSettings.selectedScreenSize;

            using (StreamWriter writter = new StreamWriter(WPF_SETTINGS_PATH))
            {
                writter.WriteLine(WPF_PICKED_GENDER);
                writter.WriteLine(WPF_PICKED_LANGUAGE);
                writter.WriteLine(WPF_PICKED_SCREENSIZE);
            }
        }

        public static void LoadWPFSettings()
        {
            List<string> wpfsettings = new List<string>();
            using (StreamReader reader = new StreamReader(WPF_SETTINGS_PATH))
            {
                while (!reader.EndOfStream)
                    wpfsettings.Add(reader.ReadLine());

                if (wpfsettings.Count > 0)
                {
                    WPF_PICKED_GENDER = wpfsettings[0];
                    WPF_PICKED_LANGUAGE = wpfsettings[1];
                    WPF_PICKED_SCREENSIZE = wpfsettings[2];
                }
            }
        }

        public static string GetWPFResolution()
        {
            using (StreamReader reader = new StreamReader(WPF_SETTINGS_PATH))
            {
                List<string> wpfsettings = new List<string>();

                while (!reader.EndOfStream)
                    wpfsettings.Add(reader.ReadLine());

                if (wpfsettings.Count > 0)
                    WPF_PICKED_SCREENSIZE = wpfsettings[2];
            }

            return WPF_PICKED_SCREENSIZE;
        }
    }
}