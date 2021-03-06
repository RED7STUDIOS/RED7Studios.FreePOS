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
using MySql.Data.MySqlClient;
using RED7Studios.UI.Forms;

namespace RED7Studios.FreePOS
{
    public partial class AT_UserManager : ModernForm
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
        public AT_UserManager(string s, string a)
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

        private void AT_UserManager_Load(object sender, EventArgs e)
        {
            // Clear the list view.
            lvList.Items.Clear();

            // Create a new mysql command named 'cmd' with a query.
            MySqlCommand cmd = new MySqlCommand(@"SELECT id, username, first, last, level FROM users", conn);
            // Create a new mysql adapter called 'da' and make it use 'cmd'.
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            // Create a new data table called my table and store it in 'table'.
            DataTable table = new DataTable("myTable");
            // Fill the adapter 'da' with the table.
            da.Fill(table);
            // Set the list view's view to details.
            lvList.View = View.Details;
            // Create a new list view item variable called 'iItem'.
            ListViewItem iItem;
            // For each 'row' (DataRow) in the table's rows.
            foreach (DataRow row in table.Rows)
            {
                // Set iItem to a new ListViewItem.
                iItem = new ListViewItem();
                // Something.
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    // If 'i' equals 0
                    if (i == 0)
                        // Set the iItem's text to an row item array[i] and convert to string.
                        iItem.Text = row.ItemArray[i].ToString();
                    else
                        // Add subitems to the 'iItem' and convert to string.
                        iItem.SubItems.Add(row.ItemArray[i].ToString());
                }
                // Add the 'iItem' to the list view.
                lvList.Items.Add(iItem);
            }
        }

        private void AT_UserManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create new frmDashboard called 'dash' and pass username and access level.
            AdminTasks userman = new AdminTasks(_username, _accessLevel);
            // Show the 'dash' form.
            userman.Show();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AT_UserMan_NewUser newuser = new AT_UserMan_NewUser(_username, _accessLevel);
            newuser.ShowDialog();
        }
    }
}
