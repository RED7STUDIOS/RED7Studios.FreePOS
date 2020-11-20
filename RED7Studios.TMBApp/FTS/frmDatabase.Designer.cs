namespace RED7Studios.FreePOS.FTS
{
    partial class frmDatabase
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
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.btnBack = new RED7Studios.UI.Controls.ModernButton();
            this.btnNext = new RED7Studios.UI.Controls.ModernButton();
            this.lbComment = new System.Windows.Forms.Label();
            this.lbHostname = new System.Windows.Forms.Label();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbHostname
            // 
            this.tbHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbHostname.Location = new System.Drawing.Point(124, 177);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(325, 30);
            this.tbHostname.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.CustomColorScheme = false;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnBack.Location = new System.Drawing.Point(556, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 70);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.modernButton2_Click);
            // 
            // btnNext
            // 
            this.btnNext.CustomColorScheme = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnNext.Location = new System.Drawing.Point(11, 368);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(230, 70);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lbComment.Location = new System.Drawing.Point(12, 42);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(412, 108);
            this.lbComment.TabIndex = 9;
            this.lbComment.Text = "Please enter your database details.\r\n\r\n(MYSQL IS ONLY SUPPORTED)";
            // 
            // lbHostname
            // 
            this.lbHostname.AutoSize = true;
            this.lbHostname.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbHostname.Location = new System.Drawing.Point(13, 177);
            this.lbHostname.Name = "lbHostname";
            this.lbHostname.Size = new System.Drawing.Size(105, 28);
            this.lbHostname.TabIndex = 13;
            this.lbHostname.Text = "Hostname:";
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbDatabase.Location = new System.Drawing.Point(13, 213);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(97, 28);
            this.lbDatabase.TabIndex = 15;
            this.lbDatabase.Text = "Database:";
            // 
            // tbDatabase
            // 
            this.tbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbDatabase.Location = new System.Drawing.Point(124, 213);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(325, 30);
            this.tbDatabase.TabIndex = 14;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbPassword.Location = new System.Drawing.Point(13, 285);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(97, 28);
            this.lbPassword.TabIndex = 19;
            this.lbPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbPassword.Location = new System.Drawing.Point(124, 285);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(325, 30);
            this.tbPassword.TabIndex = 18;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbUsername.Location = new System.Drawing.Point(13, 249);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(103, 28);
            this.lbUsername.TabIndex = 17;
            this.lbUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbUsername.Location = new System.Drawing.Point(124, 249);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(325, 30);
            this.tbUsername.TabIndex = 16;
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbDatabase);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.lbHostname);
            this.Controls.Add(this.tbHostname);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbComment);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDatabase";
            this.Text = "Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHostname;
        private UI.Controls.ModernButton btnBack;
        private UI.Controls.ModernButton btnNext;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Label lbHostname;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbUsername;
    }
}