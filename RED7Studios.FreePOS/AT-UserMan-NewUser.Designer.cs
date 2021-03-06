
namespace RED7Studios.FreePOS
{
    partial class AT_UserMan_NewUser
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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new MetroFramework.Controls.MetroTextBox();
            this.tbLastName = new MetroFramework.Controls.MetroTextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new MetroFramework.Controls.MetroTextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.btnAdd = new RED7Studios.UI.Controls.ModernButton();
            this.cmbLevel = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbFirstName.Location = new System.Drawing.Point(9, 45);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(78, 19);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(98, 45);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(181, 23);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(98, 74);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(181, 23);
            this.tbLastName.TabIndex = 3;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbLastName.Location = new System.Drawing.Point(10, 74);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(77, 19);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Last Name:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(98, 132);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(181, 23);
            this.tbPassword.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbPassword.Location = new System.Drawing.Point(10, 132);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 19);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(98, 103);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(181, 23);
            this.tbUsername.TabIndex = 5;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbUsername.Location = new System.Drawing.Point(9, 103);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(74, 19);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username:";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbLevel.Location = new System.Drawing.Point(9, 162);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(43, 19);
            this.lbLevel.TabIndex = 8;
            this.lbLevel.Text = "Level:";
            // 
            // btnAdd
            // 
            this.btnAdd.CustomColorScheme = false;
            this.btnAdd.Location = new System.Drawing.Point(17, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 39);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add New User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.ItemHeight = 19;
            this.cmbLevel.Items.AddRange(new object[] {
            "employee",
            "admin"});
            this.cmbLevel.Location = new System.Drawing.Point(98, 161);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(181, 25);
            this.cmbLevel.TabIndex = 11;
            // 
            // AT_UserMan_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 245);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "AT_UserMan_NewUser";
            this.Sizable = false;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.AT_UserMan_NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private MetroFramework.Controls.MetroTextBox tbFirstName;
        private MetroFramework.Controls.MetroTextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private MetroFramework.Controls.MetroTextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbLevel;
        private UI.Controls.ModernButton btnAdd;
        private MetroFramework.Controls.MetroComboBox cmbLevel;
    }
}