using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string databaseConnection = "Server=52.187.233.224;Database=macarons_storeapp;Uid=macarons_storeapp;Pwd=Vf7gd5*3;";

        MySqlConnection conn = new MySqlConnection("Server = 52.187.233.224; Database=macarons_storeapp;Uid=macarons_storeapp;Pwd=Vf7gd5*3;");

        public CreateOrder()
        {
            InitializeComponent();

            
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {

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


            txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    int total = Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_discount.Text);

                    string Query = "Insert into invoice_master (date, total, discount, item, itemprice, itemqty, itemtotal) values " +
                       "(NOW(), " + total + ", " + txt_discount.Text + ", " + cmb_items.Text + ", " + txt_price.Text + ", " + txt_qty.Text + ", " + txt_total.Text + ")";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand command = new MySqlCommand(Query, conn);
                    MySqlDataReader reader;
                    conn.Open();
                    reader = command.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Save Data");
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
    }
}
