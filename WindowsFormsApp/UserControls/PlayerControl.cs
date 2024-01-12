using ClassLibrary.Model;
using System.Windows.Forms;

namespace WindowsFormsApp.UserControls
{
    public partial class PlayerControl : UserControl
    {
        public Player player;
        public bool isSelected = false;

        public PlayerControl()
        {
            InitializeComponent();
        }

        public PlayerControl(Player player, bool favorite)
        {
            InitializeComponent();

            this.player = player;
            lbName.Text = player.Name;
            lbPosition.Text = player.Position;
            lbShirtNumber.Text = player.ShirtNumber.ToString();
            lbCaptain.Text = player.Captain ? "Captain" : "";

            if (favorite)
                pictureBoxStar.Visible = true;
        }

        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            PlayerControl playerControl = sender as PlayerControl;

            if (e.Button == MouseButtons.Left)
            {
                playerControl.DoDragDrop(playerControl, DragDropEffects.Move);

                if (isSelected)
                    pictureBoxStar.Visible = true;
                else
                    pictureBoxStar.Visible = false;
            }
        }
    }
}
