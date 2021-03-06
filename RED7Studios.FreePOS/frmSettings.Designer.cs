
namespace RED7Studios.FreePOS
{
    partial class frmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUsername = new MetroFramework.Controls.MetroTextBox();
            this.btnChangeConnection = new RED7Studios.UI.Controls.ModernButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRedoFTS = new RED7Studios.UI.Controls.ModernButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.btnChangeConnection);
            this.groupBox1.Location = new System.Drawing.Point(13, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(7, 16);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(499, 20);
            this.tbUsername.TabIndex = 4;
            this.tbUsername.Text = "Server = 0.0.0.0; Database=db; Uid=uid; Pwd=pwd;";
            // 
            // btnChangeConnection
            // 
            this.btnChangeConnection.CustomColorScheme = false;
            this.btnChangeConnection.Location = new System.Drawing.Point(7, 42);
            this.btnChangeConnection.Name = "btnChangeConnection";
            this.btnChangeConnection.Size = new System.Drawing.Size(499, 23);
            this.btnChangeConnection.TabIndex = 0;
            this.btnChangeConnection.Text = "Change Connection";
            this.btnChangeConnection.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.btnRedoFTS);
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other";
            // 
            // btnRedoFTS
            // 
            this.btnRedoFTS.CustomColorScheme = false;
            this.btnRedoFTS.Location = new System.Drawing.Point(7, 22);
            this.btnRedoFTS.Name = "btnRedoFTS";
            this.btnRedoFTS.Size = new System.Drawing.Size(499, 23);
            this.btnRedoFTS.TabIndex = 0;
            this.btnRedoFTS.Text = "Redo FTS (First Time Setup) (THIS WILL RESET THE WHOLE PROGRAM)";
            this.btnRedoFTS.UseVisualStyleBackColor = true;
            this.btnRedoFTS.Click += new System.EventHandler(this.btnRedoFTS_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(7, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(449, 15);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "*This is not your real connection string, for security the string will not be sho" +
    "wn.";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(7, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(433, 15);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Re-doing FTS will reset the (CLIENT) program but not the (SERVER) database.";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSettings";
            this.Sizable = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private UI.Controls.ModernButton btnChangeConnection;
        private MetroFramework.Controls.MetroTextBox tbUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private UI.Controls.ModernButton btnRedoFTS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}