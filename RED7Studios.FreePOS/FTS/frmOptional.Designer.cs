namespace RED7Studios.FreePOS.FTS
{
    partial class frmOptional
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
            this.btnBack = new RED7Studios.UI.Controls.ModernButton();
            this.btnNext = new RED7Studios.UI.Controls.ModernButton();
            this.lbComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.CustomColorScheme = false;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnBack.Location = new System.Drawing.Point(741, 435);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 70);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.modernButton2_Click);
            // 
            // btnNext
            // 
            this.btnNext.CustomColorScheme = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.btnNext.Location = new System.Drawing.Point(13, 435);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(230, 70);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lbComment.Location = new System.Drawing.Point(12, 42);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(220, 36);
            this.lbComment.TabIndex = 9;
            this.lbComment.Text = "Optional Settings:";
            // 
            // frmOptional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 518);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbComment);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmOptional";
            this.Text = "Optional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UI.Controls.ModernButton btnBack;
        private UI.Controls.ModernButton btnNext;
        private System.Windows.Forms.Label lbComment;
    }
}