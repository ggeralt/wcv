namespace WindowsFormsApp
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label1 = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 331);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 0;
            label1.Text = "Made by: Jan Šantek";
            // 
            // pictureBox
            // 
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.ErrorImage = null;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(6, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 200);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 361);
            Controls.Add(pictureBox);
            Controls.Add(label1);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox;
    }
}