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

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmDatabaseSkipped : ModernForm
    {
        public frmDatabaseSkipped()
        {
            InitializeComponent();
        }

        private void frmDatabaseSkipped_Load(object sender, EventArgs e)
        {

        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
