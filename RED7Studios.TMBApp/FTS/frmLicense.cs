using MySql.Data.MySqlClient;
using RED7Studios.FreePOS.Properties;
using RED7Studios.UI.Forms;
using System;
using System.Data;
using System.Windows.Forms;

// freepos_user
// Wupt26*0

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmLicense : ModernForm
    {
        MySqlConnection conn = new MySqlConnection("Server = 52.187.197.110; Database=freepos;Uid=freepos_user;Pwd=Wupt26*0;");

        MySqlDataAdapter adapter;

        DataTable table = new DataTable();

        public frmLicense()
        {
            InitializeComponent();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Hide();

            frmWelcome welcome = new frmWelcome();
            welcome.Show();
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT `license`, `type` FROM `licenses` WHERE `license` = '" + tbLicense.Text + "' AND `type` = '" + Settings.Default.license_type + "'", conn);
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
                        foreach (DataColumn column in table.Columns)
                            Console.Write("\t{0}", row[column]);

                        Console.WriteLine("\t" + row.RowState);
                    }
                }

                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Sorry, that license key is invalid. Please try again!", "LICENSE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Hide();

                    frmDatabase database = new frmDatabase();
                    database.Show();
                }

                table.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
