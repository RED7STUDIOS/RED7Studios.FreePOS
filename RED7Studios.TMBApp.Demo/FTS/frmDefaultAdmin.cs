using MySql.Data.MySqlClient;
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
    public partial class frmDefaultAdmin : ModernForm
    {
        MySqlConnection conn = new MySqlConnection(File.ReadAllText("Data\\connectionString"));

        public frmDefaultAdmin()
        {
            InitializeComponent();
        }

        private void frmDefaultAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

                MessageBox.Show("Successfully made an admin account!", "SYSTEM");

                Hide(); 

                frmOptional optional = new frmOptional();
                optional.Show();

        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Hide();

            frmDatabase database = new frmDatabase();
            database.Show();  
        }
    }
}
