using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class WPFSettings
    {
        public WPFSettings(string selectedGender, string selectedLanguage, string selectedScreenSize)
        {
            this.selectedGender = selectedGender;
            this.selectedLanguage = selectedLanguage;
            this.selectedScreenSize = selectedScreenSize;
        }

        public WPFSettings(string team) { favoriteTeam = team; }

        public string selectedGender { get; set; }
        public string selectedLanguage { get; set; }
        public string selectedScreenSize { get; set; }
        public string favoriteTeam { get; set; }
    }
}
