using MySql.Data.MySqlClient;
using RED7Studios.FreePOS.Properties;
using RED7Studios.UI.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmLicense : ModernForm
    {
        // Create a new mysql connection called 'conn' with the PRIVATE connection string.
        MySqlConnection conn = new MySqlConnection("Server = 52.187.197.110; Database=freepos;Uid=freepos_user;Pwd=Wupt26*0;");

        // Create a new mysql data adapter called 'adapter'.
        MySqlDataAdapter adapter;

        // Create a new DataTable named 'table'.
        DataTable table = new DataTable();

        public frmLicense()
        {
            // Initialize the form.
            InitializeComponent();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create a new frmWelcome called 'welcome'.
            frmWelcome welcome = new frmWelcome();
            // Show the 'welcome' form.
            welcome.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the adapter to a new mysql adapter with the query.
                adapter = new MySqlDataAdapter("SELECT `license`, `type` FROM `licenses` WHERE `license` = '" + tbLicense.Text + "' AND `type` = '" + Settings.Default.license_type + "'", conn);
                // Fill the adapter with 'table'.
                adapter.Fill(table);

                // Create a DataRow called 'currentRows' with the 'table' current rows.
                DataRow[] currentRows = table.Select(
    null, null, DataViewRowState.CurrentRows);

                // If the currentRows length is less than 0.
                if (currentRows.Length < 1)
                    // Write a message to the console.
                    Console.WriteLine("No Current Rows Found");
                else
                {
                    // For each of the columns in the 'table' columns.
                    foreach (DataColumn column in table.Columns)
                        // Write the column name to the console.
                        Console.Write("\t{0}", column.ColumnName);

                    // Send a message to the console with the row state.
                    Console.WriteLine("\tRowState");

                    // For each DataRow row in current rows.
                    foreach (DataRow row in currentRows)
                    {
                        // For each column in the 'table' columns.
                        foreach (DataColumn column in table.Columns)
                            // Write the row[column] to the console.
                            Console.Write("\t{0}", row[column]);

                        // Send a message to the console with the row state.
                        Console.WriteLine("\t" + row.RowState);
                    }
                }

                // If the table rows count is less or greater than 0.
                if (table.Rows.Count <= 0)
                {
                    // Show a message box.
                    MessageBox.Show("Sorry, that license key is invalid. Please try again!", "LICENSE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Hide this form.
                    Hide();

                    // Create a new frmDatabase called 'database'.
                    frmDatabase database = new frmDatabase();
                    // Show the 'database' form.
                    database.Show();
                }

                // Clear the 'table'.
                table.Clear();
            }
            catch (Exception ex)
            {
                // Show a message box.
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }
        }
    }
}
