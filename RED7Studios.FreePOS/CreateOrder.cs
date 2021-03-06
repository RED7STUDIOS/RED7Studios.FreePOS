using MySql.Data.MySqlClient;
using RED7Studios.FreePOS.PluginInterface;
using RED7Studios.UI.Forms;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace RED7Studios.FreePOS
{
    public partial class CreateOrder : ModernForm
    {
        // Create connection string variable.
        MySqlConnection conn = new MySqlConnection(Cryptography.Decrypt(File.ReadAllText("Data\\connectionString")));

        // Create a new 'PluginImplementerMenu' called 'PI'.
        PluginImplementer PI;

        // Create string for username.
        string _username;

        // Create string for level.
        string _accessLevel;

        // Create variable for token.
        private Token token;

        public CreateOrder(string s, string a)
        {
            // Initialize the form.
            if (a == "admin" || a == "employee")
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("You are not an administrator or employee, you cannot access this feature.", "CRITCAL ERROR");
            }

            // Set the passed username to the string (s).
            _username = s;
            // Set the passed level to the string (a).
            _accessLevel = a;

            // Create new Token for the username and level.
            token = new Token();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            // Fill the customers combo box using function.
            FillCustomersCombo();
            // Fill the items combo box using function.
            FillItemsCombo();

            // For each of the plugins in the 'Plugins' directory.
            foreach (var files in Directory.GetFiles(@"Plugins", "*.dll"))
            {
                // Create a new variable called 'assembly' and load the files.
                var assembly = Assembly.LoadFrom(files);
                // For each of the types in the assembly types.
                foreach (var type in assembly.GetTypes())
                {
                    // If the type interfaces contains the plugin implementer for the menu.
                    if (type.GetInterfaces().Contains(typeof(PluginImplementer)))
                    {
                        // Set PI to the new instance of type as the plugin implementer for the menu.
                        PI = Activator.CreateInstance(type) as PluginImplementer;
                        // Create a new string called 'name' with the plugin name.
                        string name = PI.PluginName();

                        // Create a new ToolStripMenuItem called 'tsi' with the name of the plugin.
                        ToolStripMenuItem tsi = new ToolStripMenuItem(name);
                        // Add the 'tsi' to the menu.
                        menu.Items.Add(tsi);
                        // Run the menu adder of the plugin.
                        PI.CreateOrderMenuAdder(tsi);
                    }
                }
            }

            // For each of the plugins in the 'Plugins' directory.
            foreach (var files in Directory.GetFiles(@"Plugins", "*.pos_dll"))
            {
                // Create a new variable called 'assembly' and load the files.
                var assembly = Assembly.LoadFrom(files);
                // For each of the types in the assembly types.
                foreach (var type in assembly.GetTypes())
                {
                    // If the type interfaces contains the plugin implementer for the menu.
                    if (type.GetInterfaces().Contains(typeof(PluginImplementer)))
                    {
                        // Set PI to the new instance of type as the plugin implementer for the menu.
                        PI = Activator.CreateInstance(type) as PluginImplementer;
                        // Create a new string called 'name' with the plugin name.
                        string name = PI.PluginName();

                        // Create a new ToolStripMenuItem called 'tsi' with the name of the plugin.
                        ToolStripMenuItem tsi = new ToolStripMenuItem(name);
                        // Add the 'tsi' to the menu.
                        menu.Items.Add(tsi);
                        // Run the menu adder of the plugin.
                        PI.CreateOrderMenuAdder(tsi);
                    }
                }
            }
        }

        public void FillCustomersCombo()
        {
            // Clear the customers combo box.
            cmbCustomers.Items.Clear();

            // Create a new DataTable called 'customertable' and store it in 'customtertable'.
            DataTable customertable = new DataTable("customertable");
            // Using the sql connection to create a new one using the connection string.
            using (MySqlConnection sqlConn = new MySqlConnection(Cryptography.Decrypt(File.ReadAllText("Data\\connectionString"))))
            {
                // Using the sql adapter to create a new one using the query and 'sqlConn'.
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT customer FROM invoice_master WHERE customer <> 'NULL'", sqlConn))
                {
                    // Fill the adapter with 'customertable'.
                    da.Fill(customertable);
                }
            }
            // For each of the DataRow da in the customer table's rows.
            foreach (DataRow da in customertable.Rows)
            {
                // Add each of the items to the combo box.
                cmbCustomers.Items.Add(da[0].ToString());
            }
        }

        public void FillItemsCombo()
        {
            // Clear the items combo box.
            cmbItems.Items.Clear();

            // Create a new DataTable called 'itemtable' and store it in 'itemtable'.
            DataTable itemtable = new DataTable("itemtable");
            // Using the sql connection to create a new one using the connection string.
            using (MySqlConnection sqlConn = new MySqlConnection(Cryptography.Decrypt(File.ReadAllText("Data\\connectionString"))))
            {
                // Using the sql adapter to create a new one using the query and 'sqlConn'.
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT name FROM items WHERE name <> 'NULL'", sqlConn))
                {
                    // Fill the adapter with 'itemtable'.
                    da.Fill(itemtable);
                }
            }
            // For each of the DataRow da in the customer table's rows.
            foreach (DataRow da in itemtable.Rows)
            {
                // Add each of the items to the combo box.
                cmbItems.Items.Add(da[0].ToString());
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            // If the quanity of the text length is greater than 0.
            if (tbQty.Text.Length > 0)
            {
                // Set the total to the quanity multipled by the price.
                tbTotal.Text = (Convert.ToInt16(tbQty.Text) * Convert.ToInt16(tbPrice.Text)).ToString();
            }
        }

        private void cmb_items_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Clear the total.
            tbTotal.Text = "";
            // Clear the quanity.
            tbQty.Text = "";
        }

        private void CreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create new frmDashboard called 'dash' and pass username and access level.
            frmDashboard dash = new frmDashboard(_username, _accessLevel);
            // Show the 'dash' form.
            dash.Show();
        }

        private void AddDiscountToTotal()
        {
            // If the discount is nothing.
            if (tbDiscount.Text == "")
            {
                // Set the discount to 0.
                tbDiscount.Text = "0";
            }
            else
            {
                // Create a new interger called 'total' and minus the sub total from the discount.
                int total = Convert.ToInt32(tbSubTotal.Text) - Convert.ToInt32(tbDiscount.Text);

                // If the total (string) contains '-'.
                if (total.ToString().Contains("-"))
                {
                    // Show a message box.
                    MessageBox.Show("You are forbidden from making the total in to the minus zone. The total price has been set to 0.", "SYSTEM");
                    // Set the discount text to the sub total.
                    tbDiscount.Text = tbSubTotal.Text;
                    // Set thte total to 0.
                    tbFullTotal.Text = "0";
                }
                else
                {
                    // Set the total to the total (string).
                    tbFullTotal.Text = total.ToString();
                }
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            // Add the discount to the total using a function.
            AddDiscountToTotal();
        }

        private void txt_sub_TextChanged(object sender, EventArgs e)
        {
            // Add the discount to the total using a function.
            AddDiscountToTotal();
        }

        // Create a new bitmap called 'memoryImage'.
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            // Create a new graphics called 'myGraphics' and equal it to the function.
            Graphics myGraphics = this.CreateGraphics();
            // Crate a new size and equal it to the form size.
            Size s = this.Size;
            // Set the 'memoryImage' to a new bitmap with the width and height with 'myGraphics'.
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            // Create a new graphics called 'memoryGraphics' and equal it to the graphics from the memory image.
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            // Set the CopyFromScreen function on 'memoryGraphics' to the location.x and location.y as well as 0, 0 and s.
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Utilize the draw image function on the 'memoryImage' and the page bounds.
            e.Graphics.DrawImage(memoryImage, e.PageBounds);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Fill the customers combo box using function.
            FillCustomersCombo();
            // Fill the items combo box using function.
            FillItemsCombo();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Run the CaptureScreen function to capture the screen.
            CaptureScreen();

            // Set the print document default page settings to landscape.
            printDocument1.DefaultPageSettings.Landscape = true;

            // Set the print preview dialog's document to the print document.
            printPreviewDialog1.Document = printDocument1;
            // Show the print preview dialog using the show dialog function.
            printPreviewDialog1.ShowDialog();
            // Set the print dialog document to the print document.
            printDialog1.Document = printDocument1;

            // If the print dialog's dialog result was OK.
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Print the document.
                printDocument1.Print();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Hide the form.
            Hide();

            // Create a new string named 'username' with '_username'.
            string username = _username;
            // Create a new string named 'accessLevel' with '_accessLevel'.
            string accessLevel = _accessLevel;

            // Create a new CreateOrder named 'thisForm' with the passed args.
            CreateOrder thisForm = new CreateOrder(username, accessLevel);
            // Show 'thisForm' form.
            thisForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // If the list views items are greater than 0.
            if (lvItems.Items.Count > 0)
            {

                //
                // ITEM
                //

                // Create a new array list called 'aList_item'.
                ArrayList aList_item = new ArrayList();
                // Something
                for (int i = 0; i < lvItems.Items.Count; i++)
                {
                    // Create a new string called 'columns' and make it empty.
                    string columns = String.Empty;
                    // Add the list view items text to the 'columns'.
                    columns += lvItems.Items[i].Text;
                    // Add 'columns' to the 'aList_item'.
                    aList_item.Add(columns);
                }

                // Create a string called 'item'.
                string item = "";

                // For each items in 'aList_item'.
                foreach (var items in aList_item)
                {
                    // Add the items to the item and seperate it by ';'.
                    item += items + ";";
                }

                //
                // PRICE
                //

                // Create a new array list called 'aList_price'.
                ArrayList aList_price = new ArrayList();
                // Something
                for (int i = 0; i < lvItems.Items.Count; i++)
                {
                    // Create a new string called 'columns' and make it empty.
                    string columns = String.Empty;
                    // Add the list view items text to the 'columns'.
                    columns += lvItems.Items[i].SubItems[1].Text;
                    // Add 'columns' to the 'aList_item'.
                    aList_price.Add(columns);
                }

                // Create a string called 'price'.
                string price = "";

                // For each items in 'aList_price'.
                foreach (var prices in aList_price)
                {
                    // Add the prices to the price and seperate it by ';'.
                    price += prices + ";";
                }

                //
                // QTY
                //

                // Create a new array list called 'aList_qty'.
                ArrayList aList_qty = new ArrayList();
                // Something
                for (int i = 0; i < lvItems.Items.Count; i++)
                {
                    // Create a new string called 'columns' and make it empty.
                    string columns = String.Empty;
                    // Add the list view items text to the 'columns'.
                    columns += lvItems.Items[i].SubItems[2].Text;
                    // Add 'columns' to the 'aList_qty'.
                    aList_qty.Add(columns);
                }

                // Create a string called 'qty'.
                string qty = "";

                // For each items in 'aList_qty'.
                foreach (var qtys in aList_qty)
                {
                    // Add the qtys to the qty and seperate it by ';'.
                    qty += qtys + ";";
                }

                //
                // TOTAL
                //

                // Create a new array list called 'aList_total'.
                ArrayList aList_total = new ArrayList();
                // Something
                for (int i = 0; i < lvItems.Items.Count; i++)
                {
                    // Create a new string called 'columns' and make it empty.
                    string columns = String.Empty;
                    // Add the list view items text to the 'columns'.
                    columns += lvItems.Items[i].SubItems[3].Text;
                    // Add 'columns' to the 'aList_total'.
                    aList_total.Add(columns);
                }

                // Create a string called 'total'.
                string total = "";

                // For each items in 'aList_total'.
                foreach (var totals in aList_total)
                {
                    // Add the totals to the total and seperate it by ';'.
                    total += totals + ";";
                }

                try
                {
                    // Set item to the item removed length by -1.
                    item = item.Remove(item.Length - 1, 1);

                    // Create a new string called 'Query' and dump the query into it.
                    string Query = "Insert into invoice_master (customer, date, total, discount, item, itemprice, itemqty, itemtotal) values " +
                   "('" + cmbCustomers.Text + "', " + "NOW(), " + tbFullTotal.Text + ", " + tbDiscount.Text + ", '" + item + "', '" + price + "', '" + qty + "', '" + total + "')";

                    // Create a new sql command named 'command' with a new command with Query and the connection.
                    MySqlCommand command = new MySqlCommand(Query, conn);
                    // Create a mysql data reader called 'reader'.
                    MySqlDataReader reader;
                    // Open the connection.
                    conn.Open();
                    // Set the 'reader' to the command executed.
                    reader = command.ExecuteReader();
                    // Show a message box.
                    MessageBox.Show("Successfully made an order/invoice!", "SYSTEM");
                    // Close the connection.
                    conn.Close();
                }
                catch (Exception ex)
                {
                    // Show a message box.
                    MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
                }
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // If the list views selected items is greater than 0.
            if (lvItems.SelectedItems.Count > 0)
            {
                // Something
                for (int i = 0; i < lvItems.Items.Count; i++)
                {
                    // If the list view items[i] selected.
                    if (lvItems.Items[i].Selected)
                    {
                        // Set the sub total to the sub total minus the list views first 3 items to text and then a string.
                        tbSubTotal.Text = (Convert.ToInt16(tbSubTotal.Text) - Convert.ToInt16(lvItems.Items[i].SubItems[3].Text)).ToString();
                        // Remove the item from the list view.
                        lvItems.Items[i].Remove();
                    }
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Create a new string called 'arr' with a new string[4].
            string[] arr = new string[4];
            // Set the first one to the items combobox selected item then to string.
            arr[0] = cmbItems.SelectedItem.ToString();
            // Set the second one to the price.
            arr[1] = tbPrice.Text;
            // Set the third one to the quanity.
            arr[2] = tbQty.Text;
            // Set the last one to the total.
            arr[3] = tbTotal.Text;

            // Create ListViewItem called 'lvi' and create a new ListViewItem with the 'arr' variable.
            ListViewItem lvi = new ListViewItem(arr);
            // Add the 'lvi' items to the list view.
            lvItems.Items.Add(lvi);

            // Make the sub total the sub total minus the total then to string.
            tbSubTotal.Text = (Convert.ToInt32(tbSubTotal.Text) + Convert.ToInt32(tbTotal.Text)).ToString();
        }
    }
}