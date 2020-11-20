namespace RED7Studios.FreePOS.FTS
{
    partial class frmDefaultAdmin
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
            this.lbPass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnBack = new RED7Studios.UI.Controls.ModernButton();
            this.btnNext = new RED7Studios.UI.Controls.ModernButton();
            this.lbComment = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbLast = new System.Windows.Forms.Label();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.lbFirst = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbPass.Location = new System.Drawing.Point(14, 252);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(97, 28);
            this.lbPass.TabIndex = 30;
            this.lbPass.Text = "Password:";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbPass.Location = new System.Drawing.Point(125, 252);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(325, 30);
            this.tbPass.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.CustomColorScheme = false;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnBack.Location = new System.Drawing.Point(557, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 70);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.modernButton2_Click);
            // 
            // btnNext
            // 
            this.btnNext.CustomColorScheme = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnNext.Location = new System.Drawing.Point(12, 368);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(230, 70);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lbComment.Location = new System.Drawing.Point(13, 42);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(635, 36);
            this.lbComment.TabIndex = 20;
            this.lbComment.Text = "Please enter details to create a default admin account.";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbUser.Location = new System.Drawing.Point(14, 216);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(103, 28);
            this.lbUser.TabIndex = 32;
            this.lbUser.Text = "Username:";
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbUser.Location = new System.Drawing.Point(125, 216);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(325, 30);
            this.tbUser.TabIndex = 31;
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbLast.Location = new System.Drawing.Point(14, 180);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(107, 28);
            this.lbLast.TabIndex = 34;
            this.lbLast.Text = "Last Name:";
            // 
            // tbLast
            // 
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbLast.Location = new System.Drawing.Point(125, 180);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(325, 30);
            this.tbLast.TabIndex = 33;
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbFirst.Location = new System.Drawing.Point(14, 144);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(110, 28);
            this.lbFirst.TabIndex = 36;
            this.lbFirst.Text = "First Name:";
            // 
            // tbFirst
            // 
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbFirst.Location = new System.Drawing.Point(125, 144);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(325, 30);
            this.tbFirst.TabIndex = 35;
            // 
            // frmDefaultAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.lbFirst);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.lbLast);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbComment);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDefaultAdmin";
            this.Text = "Create Default Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbPass;
        private UI.Controls.ModernButton btnBack;
        private UI.Controls.ModernButton btnNext;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lbLast;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.TextBox tbFirst;
    }
}