using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

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
