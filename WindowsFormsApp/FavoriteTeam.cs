using ClassLibrary;
using ClassLibrary.Model;
using System.Collections.Specialized;

namespace WindowsFormsApp
{
    public partial class FavoriteTeam : Form
    {
        private List<Team> teams = new List<Team>();

        public FavoriteTeam()
        {
            InitializeComponent();
        }

        private void FavoriteTeam_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            teams = await Repository.GetTeams();
            foreach (Team team in teams)
                cbFavoriteTeam.Items.Add(team);
            cbFavoriteTeam.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Team selectedTeam = (Team)cbFavoriteTeam.SelectedItem;
            Repository.SaveFavoriteTeam(selectedTeam);
            this.Hide();
            new MainForm().Show();
        }
    }
}
