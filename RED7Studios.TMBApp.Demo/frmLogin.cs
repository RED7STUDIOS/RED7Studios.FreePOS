using MySql.Data.MySqlClient;
using RED7Studios.UI.Forms;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

// DB INFO:
// IP: 52.187.197.110
// Username : macarons_storeapp
// Password : Vf7gd5*3
// Database : macarons_storeapp

namespace RED7Studios.FreePOS
{
    public partial class frmLogin : ModernForm
    {
        MySqlConnection conn = new MySqlConnection(Cryptography.Decrypt(File.ReadAllText("Data\\connectionString")));

        MySqlDataAdapter adapter;

        DataTable table = new DataTable();

        private Token token;

        private string level;

        public frmLogin()
        {
            InitializeComponent();

            token = new Token();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT `username`, `password`, `first`, `last`, `level` FROM `users` WHERE `username` = '" + tbUsername.Text + "' AND `password` = '" + tbPassword.Text + "'", conn);
                adapter.Fill(table);

                DataRow[] currentRows = table.Select(
    null, null, DataViewRowState.CurrentRows);

                if (currentRows.Length < 1)
                    Console.WriteLine("No Current Rows Found");
                else
                {
                    foreach (DataColumn column in table.Columns)
                        Console.Write("\t{0}", column.ColumnName);

                    Console.WriteLine("\tRowState");

                    foreach (DataRow row in currentRows)
                    {
                        level = row[4].ToString();

                        foreach (DataColumn column in table.Columns)
                            Console.WriteLine("\t{0}", row[column]);

                        Console.WriteLine("\t" + row.RowState);
                        Console.WriteLine("Level is : " + level);

                    }
                }

                if (table.Rows.Count <= 0)
                {
                    // invalid
                    //MessageBox.Show("Invalid");
                }
                else
                {
                    // correct
                    //MessageBox.Show("Correct");
                    Hide();

                    string username = tbUsername.Text;
                    string accessLevel = level;

                    _ = new frmDashboard(username, accessLevel).ShowDialog();
                }

                table.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }
        }

        private void mtMakayla_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "makayla";
        }

        private void mtAdministrator_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "admin";
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "employee";
            tbPassword.Text = "employee";
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "admin";
            tbPassword.Text = "admin";
        }
    }
}
