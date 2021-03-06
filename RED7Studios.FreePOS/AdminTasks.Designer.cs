
namespace RED7Studios.FreePOS
{
    partial class AdminTasks
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.mtUserManager = new MetroFramework.Controls.MetroTile();
            this.mtItemManager = new MetroFramework.Controls.MetroTile();
            this.mtServerSettings = new MetroFramework.Controls.MetroTile();
            this.mtPlugins = new MetroFramework.Controls.MetroTile();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 6;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.53271F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.46729F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.mtUserManager, 1, 1);
            this.tlpMain.Controls.Add(this.mtItemManager, 2, 1);
            this.tlpMain.Controls.Add(this.mtServerSettings, 3, 1);
            this.tlpMain.Controls.Add(this.metroUserControl1, 1, 2);
            this.tlpMain.Controls.Add(this.mtPlugins, 4, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(1, 33);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.38462F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.61538F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tlpMain.Size = new System.Drawing.Size(982, 484);
            this.tlpMain.TabIndex = 8;
            this.tlpMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpMain_Paint);
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(159, 324);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(150, 150);
            this.metroUserControl1.TabIndex = 7;
            // 
            // mtUserManager
            // 
            this.mtUserManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtUserManager.Location = new System.Drawing.Point(159, 155);
            this.mtUserManager.Name = "mtUserManager";
            this.mtUserManager.Size = new System.Drawing.Size(152, 163);
            this.mtUserManager.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtUserManager.TabIndex = 3;
            this.mtUserManager.Text = "User Manager";
            this.mtUserManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtUserManager.TileImage = global::RED7Studios.FreePOS.Properties.Resources.UserManager;
            this.mtUserManager.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUserManager.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtUserManager.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtUserManager.UseTileImage = true;
            this.mtUserManager.Click += new System.EventHandler(this.mtUserManager_Click);
            // 
            // mtItemManager
            // 
            this.mtItemManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtItemManager.Location = new System.Drawing.Point(317, 155);
            this.mtItemManager.Name = "mtItemManager";
            this.mtItemManager.Size = new System.Drawing.Size(157, 163);
            this.mtItemManager.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtItemManager.TabIndex = 5;
            this.mtItemManager.Text = "Item Manager";
            this.mtItemManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtItemManager.TileImage = global::RED7Studios.FreePOS.Properties.Resources.ItemManager;
            this.mtItemManager.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtItemManager.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtItemManager.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtItemManager.UseTileImage = true;
            this.mtItemManager.Click += new System.EventHandler(this.mtItemManager_Click);
            // 
            // mtServerSettings
            // 
            this.mtServerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtServerSettings.Location = new System.Drawing.Point(480, 155);
            this.mtServerSettings.Name = "mtServerSettings";
            this.mtServerSettings.Size = new System.Drawing.Size(160, 163);
            this.mtServerSettings.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtServerSettings.TabIndex = 6;
            this.mtServerSettings.Text = "Server Settings";
            this.mtServerSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtServerSettings.TileImage = global::RED7Studios.FreePOS.Properties.Resources.ServerSettings;
            this.mtServerSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtServerSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtServerSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtServerSettings.UseTileImage = true;
            this.mtServerSettings.Click += new System.EventHandler(this.mtComingSoon_Click);
            // 
            // mtPlugins
            // 
            this.mtPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtPlugins.Location = new System.Drawing.Point(646, 155);
            this.mtPlugins.Name = "mtPlugins";
            this.mtPlugins.Size = new System.Drawing.Size(155, 163);
            this.mtPlugins.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtPlugins.TabIndex = 8;
            this.mtPlugins.Text = "Plugins";
            this.mtPlugins.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPlugins.TileImage = global::RED7Studios.FreePOS.Properties.Resources.Plugins;
            this.mtPlugins.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPlugins.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPlugins.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtPlugins.UseTileImage = true;
            this.mtPlugins.Click += new System.EventHandler(this.mtPlugins_Click);
            // 
            // AdminTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 518);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.tlpMain);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "AdminTasks";
            this.Sizable = false;
            this.Text = "Admin Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminTasks_FormClosing);
            this.Load += new System.EventHandler(this.AdminTasks_Load);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MetroFramework.Controls.MetroTile mtItemManager;
        private MetroFramework.Controls.MetroTile mtUserManager;
        private MetroFramework.Controls.MetroTile mtServerSettings;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroTile mtPlugins;
    }
}