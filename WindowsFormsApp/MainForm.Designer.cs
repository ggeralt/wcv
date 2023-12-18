namespace WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSettings = new Button();
            flpAllPlayers = new FlowLayoutPanel();
            flpFavoritePlayers = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            btnOrderByGoals = new Button();
            btnOrderByVisitors = new Button();
            btnOrderByCards = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(12, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(75, 23);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // flpAllPlayers
            // 
            flpAllPlayers.Location = new Point(12, 99);
            flpAllPlayers.Name = "flpAllPlayers";
            flpAllPlayers.Size = new Size(450, 550);
            flpAllPlayers.TabIndex = 1;
            flpAllPlayers.DragDrop += flpAllPlayers_DragDrop;
            flpAllPlayers.DragEnter += flpAllPlayers_DragEnter;
            // 
            // flpFavoritePlayers
            // 
            flpFavoritePlayers.Location = new Point(550, 99);
            flpFavoritePlayers.Name = "flpFavoritePlayers";
            flpFavoritePlayers.Size = new Size(450, 550);
            flpFavoritePlayers.TabIndex = 2;
            flpFavoritePlayers.DragDrop += flpFavoritePlayers_DragDrop;
            flpFavoritePlayers.DragEnter += flpFavoritePlayers_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "All Players";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 71);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 4;
            label2.Text = "Favorite Players";
            // 
            // btnOrderByGoals
            // 
            btnOrderByGoals.Location = new Point(468, 131);
            btnOrderByGoals.Name = "btnOrderByGoals";
            btnOrderByGoals.Size = new Size(76, 23);
            btnOrderByGoals.TabIndex = 6;
            btnOrderByGoals.Text = "Goals";
            btnOrderByGoals.UseVisualStyleBackColor = true;
            btnOrderByGoals.Click += btnOrderByGoals_Click;
            // 
            // btnOrderByVisitors
            // 
            btnOrderByVisitors.Location = new Point(468, 189);
            btnOrderByVisitors.Name = "btnOrderByVisitors";
            btnOrderByVisitors.Size = new Size(76, 23);
            btnOrderByVisitors.TabIndex = 7;
            btnOrderByVisitors.Text = "Visitors";
            btnOrderByVisitors.UseVisualStyleBackColor = true;
            btnOrderByVisitors.Click += btnOrderByVisitors_Click;
            // 
            // btnOrderByCards
            // 
            btnOrderByCards.Location = new Point(468, 160);
            btnOrderByCards.Name = "btnOrderByCards";
            btnOrderByCards.Size = new Size(76, 23);
            btnOrderByCards.TabIndex = 8;
            btnOrderByCards.Text = "Cards";
            btnOrderByCards.UseVisualStyleBackColor = true;
            btnOrderByCards.Click += btnOrderByCards_Click;
            // 
            // label3
            // 
            label3.Location = new Point(468, 99);
            label3.Name = "label3";
            label3.Size = new Size(76, 18);
            label3.TabIndex = 9;
            label3.Text = "All Players";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 661);
            Controls.Add(label3);
            Controls.Add(btnOrderByCards);
            Controls.Add(btnOrderByVisitors);
            Controls.Add(btnOrderByGoals);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flpFavoritePlayers);
            Controls.Add(flpAllPlayers);
            Controls.Add(btnSettings);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSettings;
        private FlowLayoutPanel flpAllPlayers;
        private FlowLayoutPanel flpFavoritePlayers;
        private Label label1;
        private Label label2;
        private Button btnOrderByGoals;
        private Button btnOrderByVisitors;
        private Button btnOrderByCards;
        private Label label3;
    }
}