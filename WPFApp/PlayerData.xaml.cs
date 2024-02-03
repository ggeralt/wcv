using ClassLibrary.Model;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for PlayerData.xaml
    /// </summary>
    public partial class PlayerData : Window
    {
        Player player = new Player();

        public PlayerData(Player player)
        {
            this.player = player;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lbPlayerName.Content = player.Name;
            lbShirtNumber.Content = player.ShirtNumber;
            lbShirtNumber.Content = player.ShirtNumber;
            lbYellowCards.Content = player.Cards;
            lbPosition.Content = player.Position;
            lbGoals.Content = player.Goals;
            lbCaptain.Content = player.Captain ? "Yes" : "No";
        }
    }
}
