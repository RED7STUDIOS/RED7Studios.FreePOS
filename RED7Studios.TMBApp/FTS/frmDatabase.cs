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

            try
            {
                MessageBox.Show("The program may freeze, while creating the structure.", "SYSTEM");

                MySqlConnection conn = new MySqlConnection(File.ReadAllText("Data\\connectionString"));

                using (var client = new WebClient())
                {
                    if (!Directory.Exists("Data\\TEMP"))
                    {
                        Directory.CreateDirectory("Data\\TEMP");
                    }
                    client.DownloadFile("https://github.com/RED7Studios/FreePOS/raw/master/0.0.1/db.sql", "Data\\TEMP\\db.sql");
                }

                string Query = File.ReadAllText("Data\\TEMP\\db.sql");

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //This is command class which will handle the query and connection object.  
                MySqlCommand command = new MySqlCommand(Query, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Successfully made the database structure!", "SYSTEM");
                conn.Close();

                Directory.Delete("Data\\TEMP");
                File.Delete("Data\\TEMP\\db.sql");

                Hide();

                frmOptional optional = new frmOptional();
                optional.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }

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
