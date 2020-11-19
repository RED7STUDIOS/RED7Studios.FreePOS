using MySql.Data.MySqlClient;
using RED7Studios.UI.Forms;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

// DB INFO:
// IP: 52.187.197.110
// Username : macarons_storeapp
// Password : Vf7gd5*3
// Database : macarons_storeapp

// Server = 52.187.197.110; Database=macarons_storeapp;Uid=macarons_storeapp;Pwd=Vf7gd5*3;

namespace RED7Studios.FreePOS
{
    public partial class CreateOrder : ModernForm
    {
        MySqlConnection conn = new MySqlConnection(File.ReadAllText("Data\\connectionString"));

        string _username;

        string _accessLevel;

        private Token token;


        public CreateOrder(string s, string a)
        {
            InitializeComponent();

            _username = s;
            _accessLevel = a;

            token = new Token();
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
            using (MySqlConnection sqlConn = new MySqlConnection(File.ReadAllText("Data\\connectionString")))
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
            using (MySqlConnection sqlConn = new MySqlConnection(File.ReadAllText("Data\\connectionString")))
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

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_qty.Text) * Convert.ToInt16(txt_price.Text)).ToString();
            }
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
            frmDashboard dash = new frmDashboard(_username, _accessLevel);
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, e.PageBounds);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillCustomersCombo();
            FillItemsCombo();
        }

        private void HideButtons(bool arg1)
        {
            btnRefresh.Visible = arg1;
            btnAddItem.Visible = arg1;
            btnRemoveItem.Visible = arg1;
            btnSave.Visible = arg1;
            btnClear.Visible = arg1;
            btnPrint.Visible = arg1;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            HideButtons(false);
            CaptureScreen();

            printDocument1.DefaultPageSettings.Landscape = true;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            HideButtons(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Hide();

            string username = _username;
            string accessLevel = _accessLevel;

            CreateOrder thisForm = new CreateOrder(username, accessLevel);
            thisForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnRemoveItem_Click(object sender, EventArgs e)
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

        private void btnAddItem_Click(object sender, EventArgs e)
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
    }
}
