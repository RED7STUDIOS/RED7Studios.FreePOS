
namespace RED7Studios.FreePOS
{
    partial class ServerSettings
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
            this.tbServerName = new MetroFramework.Controls.MetroTextBox();
            this.btnChangeServerName = new RED7Studios.UI.Controls.ModernButton();
            this.SuspendLayout();
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(13, 45);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(499, 20);
            this.tbServerName.TabIndex = 6;
            // 
            // btnChangeServerName
            // 
            this.btnChangeServerName.CustomColorScheme = false;
            this.btnChangeServerName.Location = new System.Drawing.Point(13, 71);
            this.btnChangeServerName.Name = "btnChangeServerName";
            this.btnChangeServerName.Size = new System.Drawing.Size(499, 23);
            this.btnChangeServerName.TabIndex = 5;
            this.btnChangeServerName.Text = "Change Server Name";
            this.btnChangeServerName.UseVisualStyleBackColor = true;
            this.btnChangeServerName.Click += new System.EventHandler(this.btnChangeServerName_Click);
            // 
            // ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.btnChangeServerName);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(1680, 1010);
            this.Name = "ServerSettings";
            this.Sizable = false;
            this.Text = "Server Settings";
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbServerName;
        private UI.Controls.ModernButton btnChangeServerName;
    }
}