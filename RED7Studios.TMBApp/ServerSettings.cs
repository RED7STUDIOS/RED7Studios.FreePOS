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
    public partial class ServerSettings : ModernForm
    {
        // Create connection string variable.
        MySqlConnection conn = new MySqlConnection(Cryptography.Decrypt(File.ReadAllText("Data\\connectionString")));

        // Create string for username.
        string _username;

        // Create string for level.
        string _accessLevel;

        // Create variable for token.
        private Token token;

        public ServerSettings(string s, string a)
        {
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

        private void ServerSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeServerName_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new string called 'Query' and dump the query into it.
                string Query = "UPDATE settings SET value = '" + tbServerName.Text + "' WHERE option_id = 'settings.servername';";

                // Create a new sql command named 'command' with a new command with Query and the connection.
                MySqlCommand command = new MySqlCommand(Query, conn);
                // Create a mysql data reader called 'reader'.
                MySqlDataReader reader;
                // Open the connection.
                conn.Open();
                // Set the 'reader' to the command executed.
                reader = command.ExecuteReader();
                // Show a message box.
                MessageBox.Show("Successfully changed the server name!", "SYSTEM");
                // Close the connection.
                conn.Close();
            }
            catch (Exception ex)
            {
                // Show a message box.
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }
        }
    }
}
