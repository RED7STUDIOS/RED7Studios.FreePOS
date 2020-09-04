using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.TMBApp
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void mtLogout_Click(object sender, EventArgs e)
        {
            Hide();

            frmLogin login = new frmLogin();
            login.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            mtAdminTasks.Visible = true;
        }
    }
}
