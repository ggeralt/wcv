using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    partial class FavoriteTeam
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
            label1 = new Label();
            cbFavoriteTeam = new ComboBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 0;
            label1.Text = "Pick your favorite team:";
            // 
            // cbFavoriteTeam
            // 
            cbFavoriteTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFavoriteTeam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbFavoriteTeam.FormattingEnabled = true;
            cbFavoriteTeam.IntegralHeight = false;
            cbFavoriteTeam.ItemHeight = 21;
            cbFavoriteTeam.Location = new Point(12, 50);
            cbFavoriteTeam.Name = "cbFavoriteTeam";
            cbFavoriteTeam.Size = new Size(360, 29);
            cbFavoriteTeam.Sorted = true;
            cbFavoriteTeam.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(147, 117);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(93, 32);
            btnNext.TabIndex = 2;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FavoriteTeam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(btnNext);
            Controls.Add(cbFavoriteTeam);
            Controls.Add(label1);
            Name = "FavoriteTeam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "wcv";
            Load += FavoriteTeam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbFavoriteTeam;
        private Button btnNext;
    }
}