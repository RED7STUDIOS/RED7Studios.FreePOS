using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RED7Studios.FreePOS.PluginInterface;
using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace RED7Studios.FreePOS
{
    public partial class frmDashboard : ModernForm
    {
        // Create a new 'PluginImplementerMenu' called 'PI'.
        PluginImplementer PI;

        // Create string for username.
        string _username;

        // Create string for level.
        string _accessLevel;

        // Create variable for token.
        private Token token;

        // String (s) and (a) are for passing variables.     
        public frmDashboard(string s, string a)
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

        private void mtLogout_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Set 'login' to the form 'frmLogin'.
            frmLogin login = new frmLogin();
            // Show the 'login' form.
            login.Show();
        }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(@"Data\\settings.json"))
            {
                Item account = JsonConvert.DeserializeObject<Item>(r.ReadToEnd());
                if (account.RemovePluginsButtonFromDashboard == true)
                {
                    mtPlugins.Visible = false;
                }

                if (account.RemoveOrdersListButtonFromDashboard == true)
                {
                    mtOrderList.Visible = false;
                }

                if (account.RemoveCreateOrderButtonFromDashboard == true)
                {
                    mtCreateOrder.Visible = false;
                }
            }
        }

        public class Item 
        {
            public bool RemovePluginsButtonFromDashboard;
            public bool RemoveOrdersListButtonFromDashboard;
            public bool RemoveCreateOrderButtonFromDashboard;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // Send the passed username and level to the console.
            Console.WriteLine("Username: " + _username + " Level: " + _accessLevel);

            // If the access level is 'admin'.
            if (_accessLevel == "admin")
            {
                // Show the admin tasks button.
                mtAdminTasks.Visible = true;
            }

            LoadJson();

            Console.WriteLine();

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
                        PI.DashboardMenuAdder(tsi);
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
                        PI.DashboardMenuAdder(tsi);
                    }
                }
            }
        }

        private void mtCreateOrder_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Set 'createOrder' to the form 'CreateOrder'.
            CreateOrder createOrder = new CreateOrder(_username, _accessLevel);
            // Show the 'createOrder' form.
            createOrder.Show();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void mtOrderList_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Set 'list' to the form 'OrderList'.
            OrderList list = new OrderList(_username, _accessLevel);
            // Show the 'list' form.
            list.Show();
        }

        private void mtAdminTasks_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Set 'at' to the form 'AdminTasks'.
            AdminTasks at = new AdminTasks(_username, _accessLevel);
            // Show the 'at' form.
            at.Show();
        }

        private void mtPlugins_Click(object sender, EventArgs e)
        {
            // Create new frmPlugins called 'plugins' and pass username and access level.
            frmPlugins plugins = new frmPlugins(_username, _accessLevel);
            // Show the 'plugins' form.
            plugins.Show();
        }
    }
}
