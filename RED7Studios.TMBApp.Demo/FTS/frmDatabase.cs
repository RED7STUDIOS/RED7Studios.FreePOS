using MySql.Data.MySqlClient;
using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmDatabase : ModernForm
    {
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string path = "Data\\connectionString";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Server = " + tbHostname.Text + "; Database=" + tbDatabase.Text + ";Uid=" + tbUsername.Text +";Pwd=" + tbPassword.Text + ";");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

                MessageBox.Show("The program may freeze, while creating the structure.", "SYSTEM");

                MessageBox.Show("Successfully made the database structure!", "SYSTEM");

                Hide();

                frmOptional optional = new frmOptional();
                optional.Show();
            Hide();

            frmDefaultAdmin admin = new frmDefaultAdmin();
            admin.Show();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Hide();

            frmLicense license = new frmLicense();
            license.Show();
        }
    }
}
