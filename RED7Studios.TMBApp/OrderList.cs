using MySql.Data.MySqlClient;
using RED7Studios.UI.Forms;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace RED7Studios.FreePOS
{
    public partial class OrderList : ModernForm
    {
        // Create connection string variable.
        MySqlConnection conn = new MySqlConnection(File.ReadAllText("Data\\connectionString"));

        // Create string for username.
        string _username;

        // Create string for level.
        string _accessLevel;

        // Create variable for token.
        private Token token;

        // String (s) and (a) are for passing variables.     
        public OrderList(string s, string a)
        {
            // Initialize the form.
            InitializeComponent();

            // Set the passed username to the string (s).
            _username = s;
            // Set the passed level to the string (a).
            _accessLevel = a;

            // Create new Token for the username and level.
            token = new Token();
        }

        public void ListCat()
        {
            // Create a new data table called 'linkcat'.
            DataTable linkcat = new DataTable("linkcat");
            // Using the sql connection and create a new one with the connection string file.
            using (MySqlConnection sqlConn = new MySqlConnection(File.ReadAllText("Data\\connectionString")))
            {
                // Using the mysql adapter and create a new one with the query.
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT customer FROM invoice_master WHERE customer <> 'NULL'", sqlConn))
                {
                    // Fill the adapter with the data table 'linkcat'.
                    da.Fill(linkcat);
                }
            }
            // For each datarow (da) in the linkcat data table rows.
            foreach (DataRow da in linkcat.Rows)
            {
                // Add the data rows to the combobox.
                cbCustomer.Items.Add(da[0].ToString());
            }
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            // Utilize the 'LinkCat' function.
            ListCat();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the list view.
            lvList.Items.Clear();

            // Create a new mysql command named 'cmd' with a query.
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM invoice_master WHERE customer='" + cbCustomer.Text + "'", conn);
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

        private void OrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create new frmDashboard called 'dash' and pass username and access level.
            frmDashboard dash = new frmDashboard(_username, _accessLevel);
            // Show the 'dash' form.
            dash.Show();
        }
    }
}
