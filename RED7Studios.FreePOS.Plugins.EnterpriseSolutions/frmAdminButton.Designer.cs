
namespace RED7Studios.FreePOS.Plugins.EnterpriseSolutions
{
    partial class frmAdminButton
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
            this.modernButton1 = new RED7Studios.UI.Controls.ModernButton();
            this.btnRemovePluginsButtonForEmployees = new RED7Studios.UI.Controls.ModernButton();
            this.SuspendLayout();
            // 
            // modernButton1
            // 
            this.modernButton1.CustomColorScheme = false;
            this.modernButton1.Location = new System.Drawing.Point(13, 45);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.Size = new System.Drawing.Size(143, 49);
            this.modernButton1.TabIndex = 1;
            this.modernButton1.Text = "Enable Enterprise Updates";
            this.modernButton1.UseVisualStyleBackColor = true;
            // 
            // btnRemovePluginsButtonForEmployees
            // 
            this.btnRemovePluginsButtonForEmployees.CustomColorScheme = false;
            this.btnRemovePluginsButtonForEmployees.Location = new System.Drawing.Point(162, 45);
            this.btnRemovePluginsButtonForEmployees.Name = "btnRemovePluginsButtonForEmployees";
            this.btnRemovePluginsButtonForEmployees.Size = new System.Drawing.Size(143, 49);
            this.btnRemovePluginsButtonForEmployees.TabIndex = 2;
            this.btnRemovePluginsButtonForEmployees.Text = "Remove \"Plugins\" button for employees";
            this.btnRemovePluginsButtonForEmployees.UseVisualStyleBackColor = true;
            this.btnRemovePluginsButtonForEmployees.Click += new System.EventHandler(this.btnRemovePluginsButtonForEmployees_Click);
            // 
            // frmAdminButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.btnRemovePluginsButtonForEmployees);
            this.Controls.Add(this.modernButton1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminButton";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Text = "Admin Settings - Enterprise Solutions";
            this.Load += new System.EventHandler(this.frmAdminButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.ModernButton modernButton1;
        private UI.Controls.ModernButton btnRemovePluginsButtonForEmployees;
    }
}