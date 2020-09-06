using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace RED7Studios.TMBApp
{
    public partial class OrderList : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = 52.187.233.224; Database=macarons_storeapp;Uid=macarons_storeapp;Pwd=Vf7gd5*3;");
        public OrderList()
        {
            InitializeComponent();
        }

        public void ListCat()
        {
            DataTable linkcat = new DataTable("linkcat");
            using (MySqlConnection sqlConn = new MySqlConnection(@"Server = 52.187.233.224; Database=macarons_storeapp;Uid=macarons_storeapp;Pwd=Vf7gd5*3;"))
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
            frmDashboard dash = new frmDashboard();
            dash.Show();
        }
    }
}
