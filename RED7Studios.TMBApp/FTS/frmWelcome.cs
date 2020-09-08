using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.TMBApp.FTS
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
    }
}
