using System;
using System.Windows.Forms;

namespace RED7Studios.TMBApp.FTS
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
