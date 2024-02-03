using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using ClassLibrary;
using ClassLibrary.Model;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HashSet<Match> matches = new HashSet<Match>();
        HashSet<Result> results = new HashSet<Result>();
        HashSet<Player> startingEleven = new HashSet<Player>();
        string pickedCountry;
        string fifa_code;
        string oponentCountry;

        Result country = new Result();

        public MainWindow()
        {
            FillTeamData();
            InitializeComponent();
            PreviewKeyDown += new System.Windows.Input.KeyEventHandler(HandleEsc);
            LoadResolution();
        }

        private void HandleEsc(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        private async void FillTeamData()
        {
            results = await Repository.LoadMatchResults();

            foreach (var result in results)
            {
                cbHomeTeam.Items.Add(result);

                if (result.FifaCode == Repository.GetPickedFifaCode())
                {
                    cbHomeTeam.SelectedItem = result;
                }
            }
        }

        private async void LoadOpositeTeam()
        {
            matches = await Repository.LoadMatches(fifa_code);

            foreach (var match in matches)
            {
                if (match.HomeTeamCountry == pickedCountry.Trim())
                {
                    cbAwayTeam.Items.Add(match.AwayTeamCountry);
                }
            }

            foreach (var match in matches)
            {
                if (match.AwayTeamCountry == pickedCountry.Trim())
                {
                    cbAwayTeam.Items.Add(match.HomeTeamCountry);
                }
            }
        }

        private void LoadResolution()
        {
            string resolution = Repository.GetWPFResolution();

            switch (resolution)
            {
                case "800x550":
                    Width = 800;
                    Height = 550;
                    break;
                case "1200x950":
                    Width = 1200;
                    Height = 950;
                    break;
                case "1600x1350":
                    Width = 1600;
                    Height = 1350;
                    break;
                default:
                    break;
            }
        }

        private void LoadHomeTeam()
        {
            homeGoal.Children.Clear();
            homeDefender.Children.Clear();
            homeForward.Children.Clear();
            homeMid.Children.Clear();

            foreach (var match in matches)
            {
                if (match.HomeTeamCountry == pickedCountry.Trim())
                {
                    startingEleven = new HashSet<Player>();

                    foreach (var item in match.HomeTeamStatistics.StartingEleven)
                        startingEleven.Add(item);

                    foreach (TeamEvent teamEvent in match.HomeTeamEvents)
                        AddGoalsCards(teamEvent, startingEleven);
                }
            }
        }

        private void LoadAwayTeam()
        {
            oppositeGoal.Children.Clear();
            oppositeDefender.Children.Clear();
            oppositeMid.Children.Clear();
            oppositeForward.Children.Clear();

            foreach (var match in matches)
            {
                if (match.AwayTeamCountry == oponentCountry)
                {
                    startingEleven = new HashSet<Player>();

                    foreach (var player in match.AwayTeamStatistics.StartingEleven)
                        startingEleven.Add(player);

                    foreach (TeamEvent teamEvent in match.AwayTeamEvents)
                        AddGoalsCards(teamEvent, startingEleven);
                }
            }
        }

        private void DisplayHomeTeam()
        {
            foreach (var player in startingEleven)
            {
                switch (player.Position)
                {
                    case "Goalie":
                        homeGoal.Children.Add(new PlayerControl(player));
                        break;
                    case "Defender":
                        homeDefender.Children.Add(new PlayerControl(player));
                        break;
                    case "Midfield":
                        homeMid.Children.Add(new PlayerControl(player));
                        break;
                    case "Forward":
                        homeForward.Children.Add(new PlayerControl(player));
                        break;
                    default:
                        break;
                }
            }
        }

        private void DisplayAwayTeam()
        {
            foreach (var player in startingEleven)
            {
                switch (player.Position)
                {
                    case "Goalie":
                        oppositeGoal.Children.Add(new PlayerControl(player));
                        break;
                    case "Defender":
                        oppositeDefender.Children.Add(new PlayerControl(player));
                        break;
                    case "Midfield":
                        oppositeMid.Children.Add(new PlayerControl(player));
                        break;
                    case "Forward":
                        oppositeForward.Children.Add(new PlayerControl(player));
                        break;
                    default:
                        break;
                }
            }
        }

        private void AddGoalsCards(TeamEvent teamEvent, HashSet<Player> startingEleven)
        {
            foreach (var player in startingEleven)
                if (player.Name.Equals(teamEvent.Player))
                    if (teamEvent.TypeOfEvent.Equals("goal") || teamEvent.TypeOfEvent.Equals("goal-penalty"))
                        player.Goals += 1;
                    else if (teamEvent.TypeOfEvent.Equals("yellow-card"))
                        player.Cards += 1;
        }

        private void GetScore()
        {
            foreach (var item in matches)
                if (pickedCountry.Trim() == item.HomeTeamCountry)
                    lbResult.Content = $"{item.HomeTeam.Goals} : {item.AwayTeam.Goals}";
        }

        private void cbHomeTeam_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            lbResult.Content = "0 : 0";
            cbAwayTeam.Items.Clear();
            oppositeGoal.Children.Clear();
            oppositeDefender.Children.Clear();
            oppositeMid.Children.Clear();
            oppositeForward.Children.Clear();
            string data = cbHomeTeam.SelectedItem.ToString();
            string[] details = data.Split('(');
            string newTeam = details[1].Substring(0, 3);
            pickedCountry = details[0];
            fifa_code = newTeam;
            LoadHomeTeam();
            LoadOpositeTeam();
        }

        private void cbAwayTeam_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cbAwayTeam.SelectedItem == null) return;

            oponentCountry = cbAwayTeam.SelectedItem.ToString();

            LoadHomeTeam();
            DisplayHomeTeam();

            LoadAwayTeam();
            DisplayAwayTeam();

            GetScore();
        }

        private void btnHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            if (cbHomeTeam.SelectedIndex == -1)
                return;

            foreach (var result in results)
                if (result.Country == pickedCountry.Trim())
                    country = result;

            new CountryData(country).Show();
        }

        private void btnAwayTeam_Click(object sender, RoutedEventArgs e)
        {
            if (cbAwayTeam.SelectedIndex == -1)
                return;

            country = new Result();

            foreach (var result in results)
                if (result.Country == oponentCountry)
                    country = result;

            new CountryData(country).Show();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new Settings().Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show($"Shutdown the application?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
