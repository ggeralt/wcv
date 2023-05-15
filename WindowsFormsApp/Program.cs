using ClassLibrary;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            switch (Repository.LoadSettings())
            {
                case "input_settings":
                    Application.Run(new Form1());
                    break;
                case "input_favorite_team":
                    Application.Run(new FavoriteTeam());
                    break;
                case "no_input_needed":
                    Application.Run(new MainForm());
                    break;
                default:
                    break;
            }
        }
    }
}