namespace WindowsFormsApp.UserControls
{
    partial class MatchRankControl
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
            lbLocation = new Label();
            lbHost = new Label();
            lbVisitor = new Label();
            lbViewers = new Label();
            SuspendLayout();
            // 
            // lbLocation
            // 
            lbLocation.AutoSize = true;
            lbLocation.Location = new Point(51, 11);
            lbLocation.Name = "lbLocation";
            lbLocation.Size = new Size(38, 15);
            lbLocation.TabIndex = 0;
            lbLocation.Text = "label1";
            // 
            // lbHost
            // 
            lbHost.AutoSize = true;
            lbHost.Location = new Point(51, 46);
            lbHost.Name = "lbHost";
            lbHost.Size = new Size(38, 15);
            lbHost.TabIndex = 1;
            lbHost.Text = "label2";
            // 
            // lbVisitor
            // 
            lbVisitor.AutoSize = true;
            lbVisitor.Location = new Point(51, 82);
            lbVisitor.Name = "lbVisitor";
            lbVisitor.Size = new Size(38, 15);
            lbVisitor.TabIndex = 2;
            lbVisitor.Text = "label3";
            // 
            // lbViewers
            // 
            lbViewers.AutoSize = true;
            lbViewers.Location = new Point(51, 118);
            lbViewers.Name = "lbViewers";
            lbViewers.Size = new Size(38, 15);
            lbViewers.TabIndex = 3;
            lbViewers.Text = "label4";
            // 
            // MatchRankControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbViewers);
            Controls.Add(lbVisitor);
            Controls.Add(lbHost);
            Controls.Add(lbLocation);
            Name = "MatchRankControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLocation;
        private Label lbHost;
        private Label lbVisitor;
        private Label lbViewers;
    }
}
