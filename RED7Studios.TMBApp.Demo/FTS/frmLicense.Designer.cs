namespace RED7Studios.FreePOS.FTS
{
    partial class frmLicense
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
            this.modernButton2 = new RED7Studios.UI.Controls.ModernButton();
            this.btnNext = new RED7Studios.UI.Controls.ModernButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modernButton2
            // 
            this.modernButton2.CustomColorScheme = false;
            this.modernButton2.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.modernButton2.Location = new System.Drawing.Point(556, 368);
            this.modernButton2.Name = "modernButton2";
            this.modernButton2.Size = new System.Drawing.Size(230, 70);
            this.modernButton2.TabIndex = 7;
            this.modernButton2.Text = "Back";
            this.modernButton2.UseVisualStyleBackColor = true;
            this.modernButton2.Click += new System.EventHandler(this.modernButton2_Click);
            // 
            // btnNext
            // 
            this.btnNext.CustomColorScheme = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnNext.Location = new System.Drawing.Point(11, 368);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(230, 70);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(716, 144);
            this.label2.TabIndex = 5;
            this.label2.Text = "To continue you must enter the license key you have bought.\r\n\r\nKeys look like thi" +
    "s:\r\n12345-ABCDE-F6789";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbLicense
            // 
            this.tbLicense.Enabled = false;
            this.tbLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbLicense.Location = new System.Drawing.Point(18, 218);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(325, 38);
            this.tbLicense.TabIndex = 8;
            this.tbLicense.Text = "DEMO1-DEMO2-DEMO3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label6.Location = new System.Drawing.Point(692, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "DEMO";
            // 
            // frmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLicense);
            this.Controls.Add(this.modernButton2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "frmLicense";
            this.ShowIcon = false;
            this.Text = "License";
            this.Load += new System.EventHandler(this.frmLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Controls.ModernButton modernButton2;
        private UI.Controls.ModernButton btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.Label label6;
    }
}