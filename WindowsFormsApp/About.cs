using System.Diagnostics;

namespace WindowsFormsApp
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            string target = "http://www.algebra.hr";

            try
            {
                Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                {
                    MessageBox.Show(noBrowser.Message);
                }
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
