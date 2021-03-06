using RED7Studios.UI.Forms;
using System;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmWelcome : ModernForm
    {
        public frmWelcome()
        {
            // Initialize form.
            InitializeComponent();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            // Quit the program.
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create a new frmDatabase called 'database'.
            frmDatabase database = new frmDatabase();
            // Show the 'database' form.
            database.Show();
        }
    }
}
