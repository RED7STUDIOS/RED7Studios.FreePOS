using MySql.Data.MySqlClient;
using RED7Studios.UI.Forms;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace RED7Studios.FreePOS
{
    public partial class frmLogin : ModernForm
    {
        // Create connection string variable.
        MySqlConnection conn = new MySqlConnection(Cryptography.Decrypt(File.ReadAllText("Data\\connectionString")));

        // Create a mysql adapter variable.
        MySqlDataAdapter adapter;

        // Create new data table.
        DataTable table = new DataTable();

        // Create new token variable.
        private Token token;

        // Create new level string.
        private string level;

        public frmLogin()
        {
            // Initialize the form.
            InitializeComponent();

            // Create new token.
            token = new Token();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Clear the username text box.
            tbUsername.Clear();
            // Clear the password text box.
            tbPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Set adapter to a new MySql adapter.
                adapter = new MySqlDataAdapter("SELECT `username`, `password`, `first`, `last`, `level` FROM `users` WHERE `username` = '" + tbUsername.Text + "' AND `password` = '" + Cryptography.Encrypt(tbPassword.Text) + "'", conn);
                // Fill the table with the adapter data.
                adapter.Fill(table);

                Console.WriteLine(Cryptography.Encrypt(tbPassword.Text));

                // Don't know.
                DataRow[] currentRows = table.Select(
    null, null, DataViewRowState.CurrentRows);

                // If the length of the current rows are less than one.
                if (currentRows.Length < 1)
                    // Send 'No Current Rows Found' to the console.
                    Console.WriteLine("No Current Rows Found");
                else
                {
                    // For each of the columns in the table columns.
                    foreach (DataColumn column in table.Columns)
                        // Write the column name to the console.
                        Console.Write("\t{0}", column.ColumnName);

                    // Send the RowState to the console.
                    Console.WriteLine("\tRowState");

                    // For each of the rows in currentRows.
                    foreach (DataRow row in currentRows)
                    {
                        // Set the level variable to the level string in db.
                        level = row[4].ToString();

                        // For each of the columns in the table columns.
                        foreach (DataColumn column in table.Columns)
                            Console.WriteLine("\t{0}", row[column]);

                        // Send the RowState to the console.
                        Console.WriteLine("\t" + row.RowState);
                        // Send the current 'level' to the console.
                        Console.WriteLine("Level is : " + level);

                    }
                }

                // If the table rows are less than 0.
                if (table.Rows.Count <= 0)
                {
                    // Show a message box saying incorrect username and/or password.
                    MessageBox.Show("Incorrect username and/or password.", "SYSTEM");
                }
                else
                {
                    // Hide this form.
                    Hide();

                    // Create a new string called 'username' with the 'tbUsername' textbox.
                    string username = tbUsername.Text;
                    // Create a new string called 'accessLevel' with the 'level' variable.
                    string accessLevel = level;

                    // Create new dashboard form with the username and accessLevel (and show it).
                    _ = new frmDashboard(username, accessLevel).ShowDialog();
                }

                // Clear the table.
                table.Clear();
            }
            // Catch exception.
            catch (Exception ex)
            {
                // Show a new messagebox with the error.
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit the application fully.
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.ShowDialog();
        }
    }
}
