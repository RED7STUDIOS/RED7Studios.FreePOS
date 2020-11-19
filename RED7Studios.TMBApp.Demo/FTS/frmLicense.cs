using MySql.Data.MySqlClient;
using RED7Studios.FreePOS.Properties;
using RED7Studios.UI.Forms;
using System;
using System.Data;
using System.Windows.Forms;

// freepos_user
// Wupt26*0

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmLicense : ModernForm
    {
        DataTable table = new DataTable();

        public frmLicense()
        {
            InitializeComponent();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Hide();

            frmWelcome welcome = new frmWelcome();
            welcome.Show();
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
                    Hide();

                    frmDatabase database = new frmDatabase();
                    database.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
