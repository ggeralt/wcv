namespace WindowsFormsApp.UserControls
{
    partial class RankControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbName = new Label();
            label1 = new Label();
            label2 = new Label();
            lbCards = new Label();
            lbGoals = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(15, 23);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 54);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Cards:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Goals:";
            // 
            // lbCards
            // 
            lbCards.AutoSize = true;
            lbCards.Location = new Point(65, 54);
            lbCards.Name = "lbCards";
            lbCards.Size = new Size(0, 15);
            lbCards.TabIndex = 3;
            // 
            // lbGoals
            // 
            lbGoals.AutoSize = true;
            lbGoals.Location = new Point(65, 85);
            lbGoals.Name = "lbGoals";
            lbGoals.Size = new Size(0, 15);
            lbGoals.TabIndex = 4;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.playerIcon;
            pictureBox.Location = new Point(189, 23);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // RankControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox);
            Controls.Add(lbGoals);
            Controls.Add(lbCards);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbName);
            Name = "RankControl";
            Size = new Size(308, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label label1;
        private Label label2;
        private Label lbCards;
        private Label lbGoals;
        private PictureBox pictureBox;
    }
}
