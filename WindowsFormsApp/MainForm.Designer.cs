using System.Drawing;
using System.Windows.Forms;

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
            this.btnSettings = new System.Windows.Forms.Button();
            this.flpAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFavoritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrderByGoals = new System.Windows.Forms.Button();
            this.btnOrderByVisitors = new System.Windows.Forms.Button();
            this.btnOrderByCards = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(10, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(64, 20);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // flpAllPlayers
            // 
            this.flpAllPlayers.AllowDrop = true;
            this.flpAllPlayers.AutoScroll = true;
            this.flpAllPlayers.Location = new System.Drawing.Point(10, 86);
            this.flpAllPlayers.Name = "flpAllPlayers";
            this.flpAllPlayers.Size = new System.Drawing.Size(386, 477);
            this.flpAllPlayers.TabIndex = 1;
            this.flpAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpAllPlayers_DragDrop);
            this.flpAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpAllPlayers_DragEnter);
            // 
            // flpFavoritePlayers
            // 
            this.flpFavoritePlayers.AllowDrop = true;
            this.flpFavoritePlayers.Location = new System.Drawing.Point(471, 86);
            this.flpFavoritePlayers.Name = "flpFavoritePlayers";
            this.flpFavoritePlayers.Size = new System.Drawing.Size(386, 477);
            this.flpFavoritePlayers.TabIndex = 2;
            this.flpFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragDrop);
            this.flpFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Favorite Players";
            // 
            // btnOrderByGoals
            // 
            this.btnOrderByGoals.Location = new System.Drawing.Point(401, 114);
            this.btnOrderByGoals.Name = "btnOrderByGoals";
            this.btnOrderByGoals.Size = new System.Drawing.Size(65, 20);
            this.btnOrderByGoals.TabIndex = 6;
            this.btnOrderByGoals.Text = "Goals";
            this.btnOrderByGoals.UseVisualStyleBackColor = true;
            this.btnOrderByGoals.Click += new System.EventHandler(this.btnOrderByGoals_Click);
            // 
            // btnOrderByVisitors
            // 
            this.btnOrderByVisitors.Location = new System.Drawing.Point(401, 164);
            this.btnOrderByVisitors.Name = "btnOrderByVisitors";
            this.btnOrderByVisitors.Size = new System.Drawing.Size(65, 20);
            this.btnOrderByVisitors.TabIndex = 7;
            this.btnOrderByVisitors.Text = "Visitors";
            this.btnOrderByVisitors.UseVisualStyleBackColor = true;
            this.btnOrderByVisitors.Click += new System.EventHandler(this.btnOrderByVisitors_Click);
            // 
            // btnOrderByCards
            // 
            this.btnOrderByCards.Location = new System.Drawing.Point(401, 139);
            this.btnOrderByCards.Name = "btnOrderByCards";
            this.btnOrderByCards.Size = new System.Drawing.Size(65, 20);
            this.btnOrderByCards.TabIndex = 8;
            this.btnOrderByCards.Text = "Cards";
            this.btnOrderByCards.UseVisualStyleBackColor = true;
            this.btnOrderByCards.Click += new System.EventHandler(this.btnOrderByCards_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(401, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Get Most";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(379, 281);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(123, 25);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "LOADING...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 573);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrderByCards);
            this.Controls.Add(this.btnOrderByVisitors);
            this.Controls.Add(this.btnOrderByGoals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpFavoritePlayers);
            this.Controls.Add(this.flpAllPlayers);
            this.Controls.Add(this.btnSettings);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label lblLoading;
    }
}