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
            lbCaptain.Content = player.Captain ? "Yes" : "Not captain";
        }
    }
}
