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
                case "load_settings":
                    Application.Run(new Form1());
                    break;
                default:
                    Application.Run(new FavoriteTeam());
                    break;
            }
        }
    }
}