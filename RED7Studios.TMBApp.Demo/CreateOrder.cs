using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RED7Studios.TMBApp
{
    public partial class CreateOrder : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = 52.187.233.224; Database=freepos_demo;Uid=freepos_demo;Pwd=oP31v4!w;");

        public CreateOrder()
        {
            InitializeComponent();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            FillCustomersCombo();
            FillItemsCombo();
        }

        public void FillCustomersCombo()
        {
            cmb_customers.Items.Clear();

            DataTable customertable = new DataTable("customertable");
            using (MySqlConnection sqlConn = new MySqlConnection(@"Server = 52.187.233.224; Database=freepos_demo;Uid=freepos_demo;Pwd=oP31v4!w;"))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT customer FROM invoice_master WHERE customer <> 'NULL'", sqlConn))
                {
                    da.Fill(customertable);
                }
            }
            foreach (DataRow da in customertable.Rows)
            {
                cmb_customers.Items.Add(da[0].ToString());
            }
        }

        public void FillItemsCombo()
        {
            cmb_items.Items.Clear();

            DataTable itemtable = new DataTable("itemtable");
            using (MySqlConnection sqlConn = new MySqlConnection(@"Server = 52.187.233.224; Database=freepos_demo;Uid=freepos_demo;Pwd=oP31v4!w;"))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT name FROM items WHERE name <> 'NULL'", sqlConn))
                {
                    da.Fill(itemtable);
                }
            }
            foreach (DataRow da in itemtable.Rows)
            {
                cmb_items.Items.Add(da[0].ToString());
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

                //
                // ITEM
                //

                ArrayList aList_item = new ArrayList();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string columns = String.Empty;
                    columns += listView1.Items[i].Text;
                    aList_item.Add(columns);
                }

                string item = "";

                foreach (var items in aList_item)
                {
                    item += items + ";";
                }

                //
                // PRICE
                //

                ArrayList aList_price = new ArrayList();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string columns = String.Empty;
                    columns += listView1.Items[i].SubItems[1].Text;
                    aList_price.Add(columns);
                }

                string price = "";

                foreach (var prices in aList_price)
                {
                    price += prices + ";";
                }

                //
                // QTY
                //

                ArrayList aList_qty = new ArrayList();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string columns = String.Empty;
                    columns += listView1.Items[i].SubItems[2].Text;
                    aList_qty.Add(columns);
                }

                string qty = "";

                foreach (var qtys in aList_qty)
                {
                    qty += qtys + ";";
                }

                //
                // TOTAL
                //

                ArrayList aList_total = new ArrayList();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string columns = String.Empty;
                    columns += listView1.Items[i].SubItems[3].Text;
                    aList_total.Add(columns);
                }

                string total = "";

                foreach (var totals in aList_total)
                {
                    total += totals + ";";
                }

                try
                {
                    item = item.Remove(item.Length - 1, 1);

                    string Query = "Insert into invoice_master (customer, date, total, discount, item, itemprice, itemqty, itemtotal) values " +
                   "('" + cmb_customers.Text + "', " + "NOW(), " + textBox1.Text + ", " + txt_discount.Text + ", '" + item + "', '" + price + "', '" + qty + "', '" + total + "')";

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
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
            }
            else
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
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            AddDiscountToTotal();
        }

        private void txt_sub_TextChanged(object sender, EventArgs e)
        {
            AddDiscountToTotal();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();

            CreateOrder thisForm = new CreateOrder();
            thisForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CaptureScreen();

            printDocument1.DefaultPageSettings.Landscape = true;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, e.PageBounds);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillCustomersCombo();
            FillItemsCombo();
        }
    }
}
