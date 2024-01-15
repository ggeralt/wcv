using ClassLibrary.Model;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for PlayerControl.xaml
    /// </summary>
    public partial class PlayerControl : UserControl
    {
        Player player = new Player();

        public PlayerControl(Player player)
        {
            this.player = player;
            InitializeComponent();
            lbPlayerNumber.Content = player.ShirtNumber;
            lbPlayerName.Content = player.Name;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new PlayerData(player).Show();
        }

        private void lbPlayerNumber_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new PlayerData(player).Show();
        }

        private void lbPlayerName_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new PlayerData(player).Show();
        }
    }
}
