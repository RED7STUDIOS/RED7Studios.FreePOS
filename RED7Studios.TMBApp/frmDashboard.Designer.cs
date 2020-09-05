namespace RED7Studios.TMBApp
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
            this.btnDebug = new System.Windows.Forms.Button();
            this.mtAdminTasks = new MetroFramework.Controls.MetroTile();
            this.mtOrderList = new MetroFramework.Controls.MetroTile();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.mtCreateOrder = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(794, -13);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(14, 19);
            this.btnDebug.TabIndex = 7;
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // mtAdminTasks
            // 
            this.mtAdminTasks.Location = new System.Drawing.Point(637, 135);
            this.mtAdminTasks.Name = "mtAdminTasks";
            this.mtAdminTasks.Size = new System.Drawing.Size(150, 150);
            this.mtAdminTasks.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAdminTasks.TabIndex = 6;
            this.mtAdminTasks.Text = "Admin Tasks";
            this.mtAdminTasks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAdminTasks.TileImage = global::RED7Studios.TMBApp.Properties.Resources.AdminTasks;
            this.mtAdminTasks.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdminTasks.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdminTasks.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdminTasks.UseTileImage = true;
            this.mtAdminTasks.Visible = false;
            // 
            // mtOrderList
            // 
            this.mtOrderList.Location = new System.Drawing.Point(168, 12);
            this.mtOrderList.Name = "mtOrderList";
            this.mtOrderList.Size = new System.Drawing.Size(150, 150);
            this.mtOrderList.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtOrderList.TabIndex = 5;
            this.mtOrderList.Text = "Order List";
            this.mtOrderList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtOrderList.TileImage = global::RED7Studios.TMBApp.Properties.Resources.OrderList;
            this.mtOrderList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOrderList.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtOrderList.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtOrderList.UseTileImage = true;
            // 
            // mtLogout
            // 
            this.mtLogout.Location = new System.Drawing.Point(637, 291);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(150, 150);
            this.mtLogout.Style = MetroFramework.MetroColorStyle.Red;
            this.mtLogout.TabIndex = 4;
            this.mtLogout.Text = "Log Out";
            this.mtLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtLogout.TileImage = global::RED7Studios.TMBApp.Properties.Resources.ExitIcon;
            this.mtLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtLogout.UseTileImage = true;
            this.mtLogout.Click += new System.EventHandler(this.mtLogout_Click);
            // 
            // mtCreateOrder
            // 
            this.mtCreateOrder.Location = new System.Drawing.Point(12, 12);
            this.mtCreateOrder.Name = "mtCreateOrder";
            this.mtCreateOrder.Size = new System.Drawing.Size(150, 150);
            this.mtCreateOrder.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtCreateOrder.TabIndex = 3;
            this.mtCreateOrder.Text = "Create Order";
            this.mtCreateOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCreateOrder.TileImage = global::RED7Studios.TMBApp.Properties.Resources.CreateOrder;
            this.mtCreateOrder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCreateOrder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCreateOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCreateOrder.UseTileImage = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.mtAdminTasks);
            this.Controls.Add(this.mtOrderList);
            this.Controls.Add(this.mtLogout);
            this.Controls.Add(this.mtCreateOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCreateOrder;
        private MetroFramework.Controls.MetroTile mtLogout;
        private MetroFramework.Controls.MetroTile mtOrderList;
        private MetroFramework.Controls.MetroTile mtAdminTasks;
        private System.Windows.Forms.Button btnDebug;
    }
}