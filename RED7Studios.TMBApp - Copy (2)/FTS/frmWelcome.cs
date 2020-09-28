using RED7Studios.UI.Forms;
using System;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmWelcome : ModernForm
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();

            frmLicense license = new frmLicense();
            license.Show();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void frmWelcome_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void frmWelcome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && (e.Control))
            {
                Hide();

                frmDatabaseSkipped skipped = new frmDatabaseSkipped();
                skipped.Show();
            }
        }
    }
}
