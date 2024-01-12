using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for CountryData.xaml
    /// </summary>
    public partial class CountryData : Window
    {
        public Result result { get; set; }

        public CountryData(Result result)
        {
            InitializeComponent();
            this.result = result;
            LoadInfo();
        }

        private void LoadInfo()
        {
            lbCountry.Content = result.Country;
            lbCountryCode.Content = result.FifaCode;
            lbGames.Content = result.GamesPlayed;
            lbWins.Content = result.Wins;
            lbDraws.Content = result.Draws;
            lbLosses.Content = result.Losses;
            lblGoalsScored.Content = result.GoalsScored;
            lbGoalsTaken.Content = result.GoalsTaken;
            lbGoalDifferential.Content = result.GoalDifferential;
        }
    }
}
