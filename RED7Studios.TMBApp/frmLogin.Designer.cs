namespace RED7Studios.TMBApp
{
    partial class frmLogin
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
            this.mtAdministrator = new MetroFramework.Controls.MetroTile();
            this.mtMakayla = new MetroFramework.Controls.MetroTile();
            this.tbUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new RED7Studios.UI.Controls.ModernButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtAdministrator
            // 
            this.mtAdministrator.Location = new System.Drawing.Point(156, 3);
            this.mtAdministrator.Name = "mtAdministrator";
            this.mtAdministrator.Size = new System.Drawing.Size(147, 149);
            this.mtAdministrator.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAdministrator.TabIndex = 0;
            this.mtAdministrator.Text = "Administrator";
            this.mtAdministrator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAdministrator.TileImage = global::RED7Studios.TMBApp.Properties.Resources.UserIcon;
            this.mtAdministrator.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdministrator.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdministrator.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdministrator.UseTileImage = true;
            this.mtAdministrator.Click += new System.EventHandler(this.mtAdministrator_Click);
            // 
            // mtMakayla
            // 
            this.mtMakayla.Location = new System.Drawing.Point(3, 3);
            this.mtMakayla.Name = "mtMakayla";
            this.mtMakayla.Size = new System.Drawing.Size(147, 149);
            this.mtMakayla.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtMakayla.TabIndex = 2;
            this.mtMakayla.Text = "Makayla";
            this.mtMakayla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtMakayla.TileImage = global::RED7Studios.TMBApp.Properties.Resources.UserIcon;
            this.mtMakayla.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMakayla.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtMakayla.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtMakayla.UseTileImage = true;
            this.mtMakayla.Click += new System.EventHandler(this.mtMakayla_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.Location = new System.Drawing.Point(3, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(300, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(3, 29);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(300, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.CustomColorScheme = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.Location = new System.Drawing.Point(246, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(306, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mtMakayla, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtAdministrator, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(246, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 155);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tbUsername, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbPassword, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(246, 164);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(306, 52);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnLogin, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(799, 451);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdministrator;
        private MetroFramework.Controls.MetroTile mtMakayla;
        private MetroFramework.Controls.MetroTextBox tbUsername;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private UI.Controls.ModernButton btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}