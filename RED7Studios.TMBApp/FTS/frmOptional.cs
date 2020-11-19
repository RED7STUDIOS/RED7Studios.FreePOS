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

        private void frmDatabase_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Completed setup, the application will now restart!", "SYSTEM");
            Application.Restart();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Hide();

            frmDefaultAdmin admin = new frmDefaultAdmin();
            admin.Show();
        }
    }
}
