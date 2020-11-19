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
        MySqlConnection conn = new MySqlConnection(File.ReadAllText("Data\\connectionString"));

        string _username;

        string _accessLevel;

        private Token token;

        public OrderList(string s, string a)
        {
            InitializeComponent();

            _username = s;
            _accessLevel = a;

            token = new Token();
        }

        public void ListCat()
        {
            DataTable linkcat = new DataTable("linkcat");
            using (MySqlConnection sqlConn = new MySqlConnection(File.ReadAllText("Data\\connectionString")))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT customer FROM invoice_master WHERE customer <> 'NULL'", sqlConn))
                {
                    da.Fill(linkcat);
                }
            }
            foreach (DataRow da in linkcat.Rows)
            {
                comboBox1.Items.Add(da[0].ToString());
            }
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            ListCat();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM invoice_master WHERE customer='" + comboBox1.Text + "'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);
            listView1.View = View.Details;
            ListViewItem iItem;
            foreach (DataRow row in table.Rows)
            {
                iItem = new ListViewItem();
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    if (i == 0)
                        iItem.Text = row.ItemArray[i].ToString();
                    else
                        iItem.SubItems.Add(row.ItemArray[i].ToString());
                }
                listView1.Items.Add(iItem);
            }
        }

        private void OrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDashboard dash = new frmDashboard(_username, _accessLevel);
            dash.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
