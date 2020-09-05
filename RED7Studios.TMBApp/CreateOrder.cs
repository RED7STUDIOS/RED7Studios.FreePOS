using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

// DB INFO:
// IP: 52.187.233.224
// Username : macarons_storeapp
// Password : Vf7gd5*3
// Database : macarons_storeapp

namespace RED7Studios.TMBApp
{
    public partial class CreateOrder : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = 52.187.233.224; Database=macarons_storeapp;Uid=macarons_storeapp;Pwd=Vf7gd5*3;");

        public CreateOrder()
        {
            InitializeComponent();

            
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            ListCat();   
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);


            txt_sub.Text = (Convert.ToInt32(txt_sub.Text) + Convert.ToInt32(txt_total.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();


                    }
                }
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_qty.Text) * Convert.ToInt16(txt_price.Text)).ToString();
            }
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    string Query = "Insert into invoice_master (customer, date, total, discount, item, itemprice, itemqty, itemtotal) values " +
                       "('" + comboBox1.Text + "', " + "NOW(), " + textBox1.Text + ", " + txt_discount.Text + ", '" + cmb_items.Text + "', " + txt_price.Text + ", " + txt_qty.Text + ", " + txt_total.Text + ")";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand command = new MySqlCommand(Query, conn);
                    MySqlDataReader reader;
                    conn.Open();
                    reader = command.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Successfully made an order/invoice!", "SYSTEM");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
                }
            }
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_items_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == "Sweets Item 1")
            { txt_price.Text = "50"; }
            else if (cmb_items.SelectedItem.ToString() == "Sweets Item 2")
            { txt_price.Text = "100"; }
            else if (cmb_items.SelectedItem.ToString() == "Sweets Item 3")
            { txt_price.Text = "150"; }
            else if (cmb_items.SelectedItem.ToString() == "Bakery Item 1")
            { txt_price.Text = "200"; }
            else if (cmb_items.SelectedItem.ToString() == "Bakery Item 2")
            { txt_price.Text = "250"; }
            else if (cmb_items.SelectedItem.ToString() == "Bakery Item 3")
            { txt_price.Text = "300"; }
            else
            { txt_price.Text = "0"; }


            txt_total.Text = "";
            txt_qty.Text = "";
        }

        private void CreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
        }

        private void AddDiscountToTotal()
        {
            int total = Convert.ToInt32(txt_sub.Text) - Convert.ToInt32(txt_discount.Text);
            if (total.ToString().Contains("-"))
            {
                MessageBox.Show("You are forbidden from making the total in to the minus zone. The total price has been set to 0.", "SYSTEM");
                txt_discount.Text = txt_sub.Text;
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = total.ToString();
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            AddDiscountToTotal();
        }

        private void txt_sub_TextChanged(object sender, EventArgs e)
        {
            AddDiscountToTotal();
        }
    }
}
