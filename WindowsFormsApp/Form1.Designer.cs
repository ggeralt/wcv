namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnNext = new Button();
            btnAbout = new Button();
            cbGender = new ComboBox();
            cbLanguage = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 86);
            label1.TabIndex = 0;
            label1.Text = "wcv";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(622, 295);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 75);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.ForeColor = SystemColors.ControlText;
            btnAbout.Location = new Point(12, 295);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(150, 75);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(12, 150);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(760, 45);
            cbGender.TabIndex = 3;
            // 
            // cbLanguage
            // 
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLanguage.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Location = new Point(12, 201);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(760, 45);
            cbLanguage.TabIndex = 4;
            cbLanguage.SelectedIndexChanged += cbLanguage_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 384);
            Controls.Add(cbLanguage);
            Controls.Add(cbGender);
            Controls.Add(btnAbout);
            Controls.Add(btnNext);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "wcv";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNext;
        private Button btnAbout;
        private ComboBox cbGender;
        private ComboBox cbLanguage;
    }
}