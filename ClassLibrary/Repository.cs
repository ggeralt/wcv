using ClassLibrary.Model;

namespace ClassLibrary
{
    public class Repository
    {
        private static string PATH = "../../../";
        private static string SETTINGS_PATH = PATH + "settings.txt";

        private static string? GENDER;
        private static string? LANGUAGE;

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
            {
                File.AppendAllText(SETTINGS_PATH, "");
            }

            List<string> settings = new List<string>();

            if (string.IsNullOrEmpty(GENDER) || string.IsNullOrEmpty(LANGUAGE))
            {
                using (StreamReader reader = new StreamReader(SETTINGS_PATH))
                {
                    while (!reader.EndOfStream)
                    {
                        settings.Add(reader.ReadLine());
                    }

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
    }
}