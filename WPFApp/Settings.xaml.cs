using ClassLibrary.Model;
using ClassLibrary;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            string pickedGender = cbSelectGender.Text;
            string pickedLanguage = cbSelectLanguage.Text;
            string pickedScreenSize = cbScreenSize.Text;
            Repository.SaveWPFSettings(new WPFSettings(pickedGender, pickedLanguage, pickedScreenSize));
            Hide();
            new MainWindow().Show();
        }
    }
}
