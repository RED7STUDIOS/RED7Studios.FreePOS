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

namespace RED7Studios.FreePOS
{
    public partial class AT_UserMan_NewUser : ModernForm
    {
        // Create connection string variable.
        MySqlConnection conn = new MySqlConnection(Cryptography.Decrypt(File.ReadAllText("Data\\connectionString")));

        // Create string for username.
        string _username;

        // Create string for level.
        string _accessLevel;

        // Create variable for token.
        private Token token;

        // String (s) and (a) are for passing variables.     
        public AT_UserMan_NewUser(string s, string a)
        {
            // Initialize the form.
            if (a == "admin")
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("You are not an administrator, you cannot access this feature.", "CRITCAL ERROR");
            }

            // Set the passed username to the string (s).
            _username = s;
            // Set the passed level to the string (a).
            _accessLevel = a;

            // Create new Token for the username and level.
            token = new Token();
        }

        private void AT_UserMan_NewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbLastName.Text != "" && tbUsername.Text != "" && tbPassword.Text != "" && cmbLevel.Text != "") {
                try
                {
                    // Create a new string called 'Query' and dump the query into it.
                    string Query = "Insert into users (id, username, password, first, last, level) values " +
                   "(NULL, '" + tbUsername.Text + "', '" + Cryptography.Encrypt(tbPassword.Text) + "', '" + tbFirstName.Text + "', '" + tbLastName.Text + "', '" + cmbLevel.Text + "')";

                    // Create a new sql command named 'command' with a new command with Query and the connection.
                    MySqlCommand command = new MySqlCommand(Query, conn);
                    // Create a mysql data reader called 'reader'.
                    MySqlDataReader reader;
                    // Open the connection.
                    conn.Open();
                    // Set the 'reader' to the command executed.
                    reader = command.ExecuteReader();
                    // Show a message box.
                    MessageBox.Show("Successfully created '" + tbUsername.Text + "'!", "SYSTEM");
                    // Close the connection.
                    conn.Close();
                }
                catch (Exception ex)
                {
                    // Show a message box.
                    MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
                    conn.Close();
                }
            }
        }
    }
}
