using ClassLibrary.Model;
using System.Windows.Forms;

namespace WindowsFormsApp.UserControls
{
    public partial class RankControl : UserControl
    {
        public RankControl()
        {
            InitializeComponent();
        }

        public RankControl(Player player)
        {
            InitializeComponent();
            lbName.Text = player.Name;
            lbGoals.Text = player.Goals.ToString();
            lbCards.Text = player.Cards.ToString();
        }
    }
}
