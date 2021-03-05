
namespace RED7Studios.FreePOS
{
    partial class AT_ItemMan_NewItem
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
            this.btnAdd = new RED7Studios.UI.Controls.ModernButton();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.CustomColorScheme = false;
            this.btnAdd.Location = new System.Drawing.Point(17, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 39);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add New Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(98, 71);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(181, 23);
            this.tbPrice.TabIndex = 14;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbPrice.Location = new System.Drawing.Point(13, 71);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 19);
            this.lbPrice.TabIndex = 13;
            this.lbPrice.Text = "Price:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(181, 23);
            this.tbName.TabIndex = 12;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbName.Location = new System.Drawing.Point(13, 42);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 19);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name:";
            // 
            // AT_ItemMan_NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 151);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AT_ItemMan_NewItem";
            this.Sizable = false;
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.AT_ItemMan_NewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Controls.ModernButton btnAdd;
        private MetroFramework.Controls.MetroTextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private MetroFramework.Controls.MetroTextBox tbName;
        private System.Windows.Forms.Label lbName;
    }
}