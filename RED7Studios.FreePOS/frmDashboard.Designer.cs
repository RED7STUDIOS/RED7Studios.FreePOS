namespace RED7Studios.FreePOS
{
    partial class frmDashboard
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
            this.mtOrderList = new MetroFramework.Controls.MetroTile();
            this.mtCreateOrder = new MetroFramework.Controls.MetroTile();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.mtAdminTasks = new MetroFramework.Controls.MetroTile();
            this.mtPlugins = new MetroFramework.Controls.MetroTile();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 6;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.mtOrderList, 1, 0);
            this.tlpMain.Controls.Add(this.mtCreateOrder, 0, 0);
            this.tlpMain.Controls.Add(this.mtLogout, 5, 2);
            this.tlpMain.Controls.Add(this.mtAdminTasks, 5, 0);
            this.tlpMain.Controls.Add(this.mtPlugins, 5, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(1, 57);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.38462F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.61538F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tlpMain.Size = new System.Drawing.Size(982, 460);
            this.tlpMain.TabIndex = 7;
            // 
            // mtOrderList
            // 
            this.mtOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtOrderList.Location = new System.Drawing.Point(157, 3);
            this.mtOrderList.Name = "mtOrderList";
            this.mtOrderList.Size = new System.Drawing.Size(156, 135);
            this.mtOrderList.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtOrderList.TabIndex = 5;
            this.mtOrderList.Text = "Order List";
            this.mtOrderList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtOrderList.TileImage = global::RED7Studios.FreePOS.Properties.Resources.OrderList;
            this.mtOrderList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOrderList.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtOrderList.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtOrderList.UseTileImage = true;
            this.mtOrderList.Click += new System.EventHandler(this.mtOrderList_Click);
            // 
            // mtCreateOrder
            // 
            this.mtCreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtCreateOrder.Location = new System.Drawing.Point(3, 3);
            this.mtCreateOrder.Name = "mtCreateOrder";
            this.mtCreateOrder.Size = new System.Drawing.Size(148, 135);
            this.mtCreateOrder.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtCreateOrder.TabIndex = 3;
            this.mtCreateOrder.Text = "Create Order";
            this.mtCreateOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCreateOrder.TileImage = global::RED7Studios.FreePOS.Properties.Resources.CreateOrder;
            this.mtCreateOrder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCreateOrder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCreateOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCreateOrder.UseTileImage = true;
            this.mtCreateOrder.Click += new System.EventHandler(this.mtCreateOrder_Click);
            // 
            // mtLogout
            // 
            this.mtLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtLogout.Location = new System.Drawing.Point(809, 300);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(170, 157);
            this.mtLogout.Style = MetroFramework.MetroColorStyle.Red;
            this.mtLogout.TabIndex = 4;
            this.mtLogout.Text = "Log Out";
            this.mtLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtLogout.TileImage = global::RED7Studios.FreePOS.Properties.Resources.ExitIcon;
            this.mtLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtLogout.UseTileImage = true;
            this.mtLogout.Click += new System.EventHandler(this.mtLogout_Click);
            // 
            // mtAdminTasks
            // 
            this.mtAdminTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtAdminTasks.Location = new System.Drawing.Point(809, 3);
            this.mtAdminTasks.Name = "mtAdminTasks";
            this.mtAdminTasks.Size = new System.Drawing.Size(170, 135);
            this.mtAdminTasks.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAdminTasks.TabIndex = 6;
            this.mtAdminTasks.Text = "Admin Tasks";
            this.mtAdminTasks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAdminTasks.TileImage = global::RED7Studios.FreePOS.Properties.Resources.AdminTasks;
            this.mtAdminTasks.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdminTasks.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdminTasks.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdminTasks.UseTileImage = true;
            this.mtAdminTasks.Visible = false;
            this.mtAdminTasks.Click += new System.EventHandler(this.mtAdminTasks_Click);
            // 
            // mtPlugins
            // 
            this.mtPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtPlugins.Location = new System.Drawing.Point(809, 144);
            this.mtPlugins.Name = "mtPlugins";
            this.mtPlugins.Size = new System.Drawing.Size(170, 150);
            this.mtPlugins.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtPlugins.TabIndex = 7;
            this.mtPlugins.Text = "Plugins";
            this.mtPlugins.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPlugins.TileImage = global::RED7Studios.FreePOS.Properties.Resources.Plugins;
            this.mtPlugins.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPlugins.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPlugins.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtPlugins.UseTileImage = true;
            this.mtPlugins.Click += new System.EventHandler(this.mtPlugins_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(1, 33);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(982, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "menu";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 518);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menu);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCreateOrder;
        private MetroFramework.Controls.MetroTile mtLogout;
        private MetroFramework.Controls.MetroTile mtOrderList;
        private MetroFramework.Controls.MetroTile mtAdminTasks;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MetroFramework.Controls.MetroTile mtPlugins;
        private System.Windows.Forms.MenuStrip menu;
    }
}