namespace RED7Studios.FreePOS
{
    partial class CreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.lbDiscount = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lbSelectItem = new System.Windows.Forms.Label();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.lbFullTotal = new System.Windows.Forms.Label();
            this.tbFullTotal = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnPrint = new RED7Studios.UI.Controls.ModernButton();
            this.btnClear = new RED7Studios.UI.Controls.ModernButton();
            this.btnSave = new RED7Studios.UI.Controls.ModernButton();
            this.btnRefresh = new RED7Studios.UI.Controls.ModernButton();
            this.btnAddItem = new RED7Studios.UI.Controls.ModernButton();
            this.btnRemoveItem = new RED7Studios.UI.Controls.ModernButton();
            this.SuspendLayout();
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbDiscount.Location = new System.Drawing.Point(176, 366);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(63, 17);
            this.lbDiscount.TabIndex = 38;
            this.lbDiscount.Text = "Discount";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(243, 363);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(90, 23);
            this.tbDiscount.TabIndex = 37;
            this.tbDiscount.Text = "0";
            this.tbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDiscount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbSubTotal.Location = new System.Drawing.Point(12, 366);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(66, 17);
            this.lbSubTotal.TabIndex = 36;
            this.lbSubTotal.Text = "Sub Total";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(81, 363);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(86, 23);
            this.tbSubTotal.TabIndex = 35;
            this.tbSubTotal.Text = "0";
            this.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSubTotal.TextChanged += new System.EventHandler(this.txt_sub_TextChanged);
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvItems.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(13, 188);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(466, 160);
            this.lvItems.TabIndex = 34;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 80;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTotal.Location = new System.Drawing.Point(296, 113);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(39, 17);
            this.lbTotal.TabIndex = 32;
            this.lbTotal.Text = "Total";
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbQty.Location = new System.Drawing.Point(171, 113);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(30, 17);
            this.lbQty.TabIndex = 31;
            this.lbQty.Text = "Qty";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbPrice.Location = new System.Drawing.Point(43, 113);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(38, 17);
            this.lbPrice.TabIndex = 30;
            this.lbPrice.Text = "Price";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(266, 132);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 23);
            this.tbTotal.TabIndex = 29;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(138, 132);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(100, 23);
            this.tbQty.TabIndex = 28;
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(17, 133);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(90, 23);
            this.tbPrice.TabIndex = 27;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(14, 42);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(67, 17);
            this.lbCustomer.TabIndex = 26;
            this.lbCustomer.Text = "Customer";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(96, 42);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(364, 24);
            this.cmbCustomers.TabIndex = 25;
            // 
            // lbSelectItem
            // 
            this.lbSelectItem.AutoSize = true;
            this.lbSelectItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbSelectItem.Location = new System.Drawing.Point(14, 72);
            this.lbSelectItem.Name = "lbSelectItem";
            this.lbSelectItem.Size = new System.Drawing.Size(76, 17);
            this.lbSelectItem.TabIndex = 50;
            this.lbSelectItem.Text = "Select Item";
            // 
            // cmbItems
            // 
            this.cmbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Items.AddRange(new object[] {
            "Normal:",
            "Chocolate",
            "Nutella",
            "Mango",
            "Raspberry",
            "Strawberry"});
            this.cmbItems.Location = new System.Drawing.Point(96, 70);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(364, 24);
            this.cmbItems.TabIndex = 49;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged_1);
            // 
            // lbFullTotal
            // 
            this.lbFullTotal.AutoSize = true;
            this.lbFullTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbFullTotal.Location = new System.Drawing.Point(344, 366);
            this.lbFullTotal.Name = "lbFullTotal";
            this.lbFullTotal.Size = new System.Drawing.Size(39, 17);
            this.lbFullTotal.TabIndex = 52;
            this.lbFullTotal.Text = "Total";
            // 
            // tbFullTotal
            // 
            this.tbFullTotal.Location = new System.Drawing.Point(387, 363);
            this.tbFullTotal.Name = "tbFullTotal";
            this.tbFullTotal.ReadOnly = true;
            this.tbFullTotal.Size = new System.Drawing.Size(86, 23);
            this.tbFullTotal.TabIndex = 51;
            this.tbFullTotal.Text = "0";
            this.tbFullTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.CustomColorScheme = false;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(231, 408);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 30);
            this.btnPrint.TabIndex = 54;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.CustomColorScheme = false;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(122, 408);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 30);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.CustomColorScheme = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(13, 408);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 30);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.CustomColorScheme = false;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(466, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 52);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.CustomColorScheme = false;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.Location = new System.Drawing.Point(388, 128);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(91, 26);
            this.btnAddItem.TabIndex = 58;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.CustomColorScheme = false;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.Location = new System.Drawing.Point(388, 157);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(91, 26);
            this.btnRemoveItem.TabIndex = 59;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lbFullTotal);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.lbQty);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbFullTotal);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.lbSelectItem);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.tbDiscount);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "CreateOrder";
            this.ShowIcon = false;
            this.Text = "Create Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateOrder_FormClosing);
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label lbSelectItem;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label lbFullTotal;
        private System.Windows.Forms.TextBox tbFullTotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private UI.Controls.ModernButton btnPrint;
        private UI.Controls.ModernButton btnClear;
        private UI.Controls.ModernButton btnSave;
        private UI.Controls.ModernButton btnRefresh;
        private UI.Controls.ModernButton btnAddItem;
        private UI.Controls.ModernButton btnRemoveItem;
    }
}

