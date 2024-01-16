using ClassLibrary.Model;
using ClassLibrary;
using System.Windows;
using System.Windows.Forms;

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
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show($"Set gender to: {cbSelectGender.Text}\nSet language to {cbSelectLanguage.Text}\nSet resolution to: {cbScreenSize.Text}", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
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
}
