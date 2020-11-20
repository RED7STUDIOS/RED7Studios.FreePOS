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
            // Initialize the form.
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Create a new string called 'path' and make it to the connection string path.
            string path = "Data\\connectionString";
            // If the 'path' doesn't exist.
            if (!File.Exists(path))
            {
                // Using the stream writer (sw) and equaling it to the create text 'path'.
                using (StreamWriter sw = File.CreateText(path))
                {
                    // Write line to the stream writer.
                    sw.WriteLine("Server = " + tbHostname.Text + "; Database=" + tbDatabase.Text + ";Uid=" + tbUsername.Text +";Pwd=" + tbPassword.Text + ";");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                // Create a new string called 's' with nothing.
                string s = "";
                // While the s is reading the line and it doesn't equal null.
                while ((s = sr.ReadLine()) != null)
                {
                    // Send a message to the console.
                    Console.WriteLine(s);
                }
            }

            try
            {
                // Show a message box.
                MessageBox.Show("The program may freeze, while creating the structure.", "SYSTEM");

                // Create a new mysql connection called 'conn' with the connection string.
                MySqlConnection conn = new MySqlConnection(File.ReadAllText("Data\\connectionString"));

                // Using the web client named 'client'.
                using (var client = new WebClient())
                {
                    // If the directory Data\TEMP doesn't exist.
                    if (!Directory.Exists("Data\\TEMP"))
                    {
                        // Create the directory Data\TEMP.
                        Directory.CreateDirectory("Data\\TEMP");
                    }
                    // Download the .sql file to the Data\TEMP\db.sql location.
                    client.DownloadFile("https://github.com/RED7Studios/FreePOS/raw/master/0.0.1/db.sql", "Data\\TEMP\\db.sql");
                }

                // Create a new string called 'Query' with the content of the .sql file.
                string Query = File.ReadAllText("Data\\TEMP\\db.sql");

                // Create a new mysql command named 'command' with the query and connection.
                MySqlCommand command = new MySqlCommand(Query, conn);
                // Create a new mysql reader named 'reader'.
                MySqlDataReader reader;
                // Open the connection.
                conn.Open();
                // Set the reader to the command executed.
                reader = command.ExecuteReader();
                // Show a message box.
                MessageBox.Show("Successfully made the database structure!", "SYSTEM");
                // Close the connection.
                conn.Close();

                // Delete the Data\TEMP directory.
                Directory.Delete("Data\\TEMP");
                // Delete the .sql file.
                File.Delete("Data\\TEMP\\db.sql");

                // Hide this form.
                Hide();

                // Create a new frmOptional named 'optional'.
                frmOptional optional = new frmOptional();
                // Show the 'optional' form.
                optional.Show();
            }
            catch (Exception ex)
            {
                // Show a message box.
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }

            // Hide this form.
            Hide();

            // Create a new frmDefaultAdmin named 'admin'.
            frmDefaultAdmin admin = new frmDefaultAdmin();
            // Show the 'admin' form.
            admin.Show();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create a new frmLicense named 'license'.
            frmLicense license = new frmLicense();
            // Show the 'license' form.
            license.Show();
        }
    }
}
