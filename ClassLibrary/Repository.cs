using ClassLibrary.Model;
using Newtonsoft.Json;
using RestSharp;

namespace ClassLibrary
{
    public class Repository
    {
        private static string PATH = "../../../";
        private static string SETTINGS_PATH = PATH + "settings.txt";
        private static string TEAM_PATH = PATH + "team.txt";
        private static string PLAYERS_PATH = PATH + "players.txt";

        private static string? GENDER;
        private static string? LANGUAGE;
        private static string? PICKED_CHAMPIONSHIP;
        private static string? PICKED_FIFA_CODE;


        private static string MALE_CHAMPIONSHIP_URL = "https://worldcup-vua.nullbit.hr/men/teams/results";
        private static string FEMALE_CHAMPIONSHIP_URL = "https://worldcup-vua.nullbit.hr/women/teams/results";

        public static void SaveSettings(Settings settings)
        {
            using (StreamWriter writter = new StreamWriter(SETTINGS_PATH))
            {
                writter.Write(settings.Gender);
                writter.Write(Environment.NewLine);
                writter.Write(settings.Language);
            }

            GENDER = settings.Gender.ToString();
            LANGUAGE = settings.Language.ToString();
        }

        public static string LoadSettings()
        {
            if (!File.Exists(SETTINGS_PATH))
                File.AppendAllText(SETTINGS_PATH, "");

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

            if (GENDER == null || LANGUAGE == null)
            {
                return "load_settings";
            }

            return "load_favorite_team";
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

        private static Task<RestResponse<Team>> GetTeamData(string path)
        {
            RestClient restClient = new RestClient(path);
            return restClient.ExecuteAsync<Team>(new RestRequest());
        }

        private static List<T> DeserialiseData<T>(RestResponse<T> restResponse)
        {
            return
                JsonConvert.DeserializeObject(restResponse.Content, typeof(List<T>), new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }) as List<T>;
        }

        public static void SaveFavoriteTeam(Team favoriteTeam)
        {
            PICKED_FIFA_CODE = favoriteTeam.FifaCode;
            using (StreamWriter writter = new StreamWriter(TEAM_PATH)) 
                writter.Write(favoriteTeam);
        }
    }
}