using ClassLibrary;
using ClassLibrary.Model;
using WindowsFormsApp.UserControls;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Player> players;
        private List<Match> matches;
        public List<string> favoritePlayers = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            favoritePlayers = Repository.LoadFavoritePlayers();
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            flpAllPlayers.Controls.Clear();
            flpFavoritePlayers.Controls.Clear();

            matches = await Repository.GetMatch();
            players = new List<Player>();

            foreach (Player player in matches[0].HomeTeamStatistics.StartingEleven)
                players.Add(player);

            foreach (Player player in matches[0].HomeTeamStatistics.Substitutes)
                players.Add(player);

            foreach (Player player in players)
            {
                bool used = false;

                foreach (string favoritePlayer in favoritePlayers)
                {
                    if (player.Name == favoritePlayer)
                    {
                        flpFavoritePlayers.Controls.Add(new PlayerControl(player, true));
                        used = true;
                    }
                }

                if (!used)
                    flpAllPlayers.Controls.Add(new PlayerControl(player, player.Favorite));
            }

            foreach (Match match in matches)
            {
                foreach (TeamEvent teamEvent in match.HomeTeamEvents)
                    AddGoalsCards(teamEvent, players);

                foreach (TeamEvent teamEvent in match.AwayTeamEvents)
                    AddGoalsCards(teamEvent, players);
            }
        }

        private void AddGoalsCards(TeamEvent teamEvent, List<Player> players)
        {
            foreach (Player player in players)
            {
                if (player.Name.Equals(teamEvent.Player))
                {
                    if (teamEvent.TypeOfEvent.Equals("goal") || teamEvent.TypeOfEvent.Equals("goal-penalty"))
                        player.Goals += 1;
                    else if (teamEvent.TypeOfEvent.Equals("yellow-card"))
                        player.Cards += 1;
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Hide();
            new Form1().Show();
        }

        private void btnOrderByGoals_Click(object sender, EventArgs e)
        {
            if (players != null)
                new Print(players, "Goals").ShowDialog();
            else
                MessageBox.Show("Players are empty!");
        }

        private void btnOrderByCards_Click(object sender, EventArgs e)
        {
            if (players != null)
                new Print(players, "Cards").ShowDialog();
            else
                MessageBox.Show("Players are empty!");
        }

        private void btnOrderByVisitors_Click(object sender, EventArgs e)
        {
            if (players == null)
                MessageBox.Show("Players are empty");

            if (matches == null)
                MessageBox.Show("Matches are empty");

            new Print(matches).ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Repository.SaveFavoritePlayers(favoritePlayers);
                Dispose();
            }
            else
                return;
        }

        private void flpAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            PlayerControl player = (PlayerControl)e.Data.GetData(typeof(PlayerControl));

            if (player.Parent == flpFavoritePlayers)
            {
                player.isSelected = false;
                flpAllPlayers.Controls.Add(player);

                favoritePlayers.Remove(player.player.Name);
            }
        }

        private void flpAllPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flpFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            PlayerControl player = (PlayerControl)e.Data.GetData(typeof(PlayerControl));

            if (player.Parent == flpAllPlayers && (flpFavoritePlayers.Controls.Count) < 3)
            {
                player.isSelected = true;
                flpFavoritePlayers.Controls.Add(player);

                favoritePlayers.Add(player.player.Name);
            }
        }

        private void flpFavoritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
