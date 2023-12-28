using ClassLibrary.Model;
using System.Data;
using WindowsFormsApp.UserControls;

namespace WindowsFormsApp
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        public Print(List<Match> matches)
        {
            InitializeComponent();

            matches.OrderByDescending(m => m.GetAttendance()).ToList();

            flowLayoutPanel.Width = 200;

            foreach (Match match in matches) flowLayoutPanel.Controls.Add(new MatchRankControl(match));
        }

        public Print(List<Player> players, string gameType)
        {
            InitializeComponent();

            if (gameType == "Cards") players = players.OrderByDescending(p => p.Cards).ToList();
            else if (gameType == "Goals") players = players.OrderByDescending(p => p.Goals).ToList();
            foreach (Player player in players) flowLayoutPanel.Controls.Add(new RankControl(player));
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bmp = new Bitmap(Size.Width, Size.Height);

            DrawToBitmap(bmp, new Rectangle
            {
                X = 0,
                Y = 0,
                Width = Size.Width,
                Height = Size.Height
            });

            e.Graphics.DrawImage(bmp, new Point
            {
                X = e.MarginBounds.Left,
                Y = e.MarginBounds.Top
            });
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }
    }
}
