using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmOptional : ModernForm
    {
        public frmOptional()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Show a message box.
            MessageBox.Show("Completed setup, the application will now restart!", "SYSTEM");
            // Restart the application.
            Application.Restart();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create a new frmDefaultAdmin called 'admin'.
            frmDefaultAdmin admin = new frmDefaultAdmin();
            // Show the 'admin' form.
            admin.Show();
        }
    }
}
