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
            this.mtAdminTasks = new MetroFramework.Controls.MetroTile();
            this.mtOrderList = new MetroFramework.Controls.MetroTile();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.mtCreateOrder = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtAdminTasks
            // 
            this.mtAdminTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtAdminTasks.Location = new System.Drawing.Point(814, 155);
            this.mtAdminTasks.Name = "mtAdminTasks";
            this.mtAdminTasks.Size = new System.Drawing.Size(165, 163);
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
            // 
            // mtOrderList
            // 
            this.mtOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtOrderList.Location = new System.Drawing.Point(159, 3);
            this.mtOrderList.Name = "mtOrderList";
            this.mtOrderList.Size = new System.Drawing.Size(159, 146);
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
            // mtLogout
            // 
            this.mtLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtLogout.Location = new System.Drawing.Point(814, 324);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(165, 157);
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
            // mtCreateOrder
            // 
            this.mtCreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtCreateOrder.Location = new System.Drawing.Point(3, 3);
            this.mtCreateOrder.Name = "mtCreateOrder";
            this.mtCreateOrder.Size = new System.Drawing.Size(150, 146);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 6;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.mtOrderList, 1, 0);
            this.tlpMain.Controls.Add(this.mtCreateOrder, 0, 0);
            this.tlpMain.Controls.Add(this.mtAdminTasks, 5, 1);
            this.tlpMain.Controls.Add(this.mtLogout, 5, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(1, 33);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.38462F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.61538F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tlpMain.Size = new System.Drawing.Size(982, 484);
            this.tlpMain.TabIndex = 7;
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
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
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

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCreateOrder;
        private MetroFramework.Controls.MetroTile mtLogout;
        private MetroFramework.Controls.MetroTile mtOrderList;
        private MetroFramework.Controls.MetroTile mtAdminTasks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
    }
}