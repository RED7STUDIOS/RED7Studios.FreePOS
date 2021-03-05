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
        // Create a new mysql connection called 'conn' and read the connection string.
        MySqlConnection conn = new MySqlConnection(Cryptography.Decrypt(File.ReadAllText("Data\\connectionString")));

        public frmDefaultAdmin()
        {
            // Initialize the form.
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new string called 'query' with the query details.
                string Query = "Insert into users (id, username, password, first, last, level) values " +
               "('" + "1" + "', '" + tbUser.Text + "', '" + tbPass.Text + "', '" + tbFirst.Text + "', '" + tbLast.Text + "', '" + "admin" + "')";

                // Create a new MySql command with the query and connection called 'command'.
                MySqlCommand command = new MySqlCommand(Query, conn);
                // Create a new mysql data reader called 'reader'.
                MySqlDataReader reader;
                // Open the connection.
                conn.Open();
                // Set the reader to the command executed.
                reader = command.ExecuteReader();
                // Show a message box.
                MessageBox.Show("Successfully made an admin account!", "SYSTEM");
                // Close the connection
                conn.Close();

                // Hide this form.
                Hide();

                // Create a new frmOptional called 'optional'.
                frmOptional optional = new frmOptional();
                // Show the 'optional' form.
                optional.Show();
            }
            catch (Exception ex)
            {
                // Show a message box.
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create a new frmDatabase called 'database'.
            frmDatabase database = new frmDatabase();
            // Show the 'database' form.
            database.Show();  
        }
    }
}
