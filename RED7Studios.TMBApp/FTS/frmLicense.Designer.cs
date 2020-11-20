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
            this.btnBack = new RED7Studios.UI.Controls.ModernButton();
            this.btnNext = new RED7Studios.UI.Controls.ModernButton();
            this.lbComment = new System.Windows.Forms.Label();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.CustomColorScheme = false;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnBack.Location = new System.Drawing.Point(741, 435);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 70);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.modernButton2_Click);
            // 
            // btnNext
            // 
            this.btnNext.CustomColorScheme = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnNext.Location = new System.Drawing.Point(13, 435);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(230, 70);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lbComment.Location = new System.Drawing.Point(12, 53);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(716, 144);
            this.lbComment.TabIndex = 5;
            this.lbComment.Text = "To continue you must enter the license key you have bought.\r\n\r\nKeys look like thi" +
    "s:\r\n12345-ABCDE-F6789";
            // 
            // tbLicense
            // 
            this.tbLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbLicense.Location = new System.Drawing.Point(18, 218);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(325, 38);
            this.tbLicense.TabIndex = 8;
            // 
            // frmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 518);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.tbLicense);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbComment);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "frmLicense";
            this.ShowIcon = false;
            this.Text = "License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Controls.ModernButton btnBack;
        private UI.Controls.ModernButton btnNext;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.TextBox tbLicense;
    }
}