using ClassLibrary.Model;

namespace WindowsFormsApp.UserControls
{
    public partial class MatchRankControl : UserControl
    {
        public MatchRankControl()
        {
            InitializeComponent();
        }

        public MatchRankControl(Match match)
        {
            InitializeComponent();

            lbLocation.Text = match.Location;
            lbHost.Text = match.HomeTeamCountry;
            lbVisitor.Text = match.AwayTeamCountry;
            lbViewers.Text = match.Attendance;
        }
    }
}
