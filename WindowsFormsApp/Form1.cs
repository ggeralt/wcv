using ClassLibrary;
using ClassLibrary.Model;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            cbGender.Items.Add(Gender.M);
            cbGender.Items.Add(Gender.F);
            cbGender.SelectedIndex = 0;

            cbLanguage.Items.Add(Language.English);
            cbLanguage.Items.Add(Language.Hrvatski);
            cbLanguage.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Set gender to: {cbGender.SelectedItem}\nSet language to {cbLanguage.SelectedItem}", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Settings settings = new Settings
                {
                    Gender = (Gender)cbGender.SelectedItem,
                    Language = (Language)cbLanguage.SelectedItem
                };

                Repository.SaveSettings(settings);
                this.Hide();
                new FavoriteTeam().Show();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void SetCulture(string language)
        {
            CultureInfo cultureInfo = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Thread.CurrentThread.CurrentCulture = cultureInfo;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanguage.Text == "English")
            {
                SetCulture("EN");
            }
            else
            {
                SetCulture("HR");
            }

            if (Thread.CurrentThread.CurrentUICulture.Name == "HR")
            {
                SetCulture("EN");
            }
            else
            {
                SetCulture("HR");
            }
        }
    }
}