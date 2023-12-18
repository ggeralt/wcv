namespace WindowsFormsApp.UserControls
{
    partial class PlayerControl
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
            lbPosition = new Label();
            lbShirtNumber = new Label();
            lbCaptain = new Label();
            pictureBoxIcon = new PictureBox();
            pictureBoxStar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStar).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(11, 12);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // lbPosition
            // 
            lbPosition.AutoSize = true;
            lbPosition.Location = new Point(11, 38);
            lbPosition.Name = "lbPosition";
            lbPosition.Size = new Size(50, 15);
            lbPosition.TabIndex = 1;
            lbPosition.Text = "Position";
            // 
            // lbShirtNumber
            // 
            lbShirtNumber.AutoSize = true;
            lbShirtNumber.Location = new Point(11, 65);
            lbShirtNumber.Name = "lbShirtNumber";
            lbShirtNumber.Size = new Size(76, 15);
            lbShirtNumber.TabIndex = 2;
            lbShirtNumber.Text = "Shirt number";
            // 
            // lbCaptain
            // 
            lbCaptain.AutoSize = true;
            lbCaptain.Location = new Point(11, 94);
            lbCaptain.Name = "lbCaptain";
            lbCaptain.Size = new Size(48, 15);
            lbCaptain.TabIndex = 3;
            lbCaptain.Text = "Captain";
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.ErrorImage = null;
            pictureBoxIcon.Image = Properties.Resources.playerIcon;
            pictureBoxIcon.Location = new Point(223, 12);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(100, 100);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 4;
            pictureBoxIcon.TabStop = false;
            // 
            // pictureBoxStar
            // 
            pictureBoxStar.ErrorImage = null;
            pictureBoxStar.Image = Properties.Resources.favoriteIcon;
            pictureBoxStar.Location = new Point(167, 38);
            pictureBoxStar.Name = "pictureBoxStar";
            pictureBoxStar.Size = new Size(50, 50);
            pictureBoxStar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStar.TabIndex = 5;
            pictureBoxStar.TabStop = false;
            // 
            // PlayerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxStar);
            Controls.Add(pictureBoxIcon);
            Controls.Add(lbCaptain);
            Controls.Add(lbShirtNumber);
            Controls.Add(lbPosition);
            Controls.Add(lbName);
            Name = "PlayerControl";
            Size = new Size(337, 128);
            MouseDown += PlayerControl_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbPosition;
        private Label lbShirtNumber;
        private Label lbCaptain;
        private PictureBox pictureBoxIcon;
        private PictureBox pictureBoxStar;
    }
}
