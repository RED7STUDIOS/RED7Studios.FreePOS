using RED7Studios.FreePOS.PluginInterface;
using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.FreePOS
{
    public partial class frmPlugins : ModernForm
    {
        // Create new PluginImplementerButton called 'PI'.
        PluginImplementer PI;

        // Create string for username.
        string _username;

        // Create string for level.
        string _accessLevel;

        // Create variable for token.
        private Token token;

        public frmPlugins(string s, string a)
        {
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

        private void frmPlugins_Load(object sender, EventArgs e)
        {
            // For each of the plugins in the 'Plugins' directory.
            foreach (var files in Directory.GetFiles(@"Plugins", "*.dll"))
            {
                // Create a new variable called 'assembly' and load the files.
                var assembly = Assembly.LoadFrom(files);
                // For each of the types in the assembly types.
                foreach (var type in assembly.GetTypes())
                {
                    // If the type interfaces contains the plugin implementer for the button OR all of the implementers.
                    if (type.GetInterfaces().Contains(typeof(PluginImplementer)))
                    {
                        // Set PI to the new instance of type as the plugin implementer for the button.
                        PI = Activator.CreateInstance(type) as PluginImplementer;
                        // Create a new string called 'name' with the plugin name.
                        string name = PI.PluginName();

                        // Create a new button called 'btn'.
                        Button btn = new Button();
                        // Set 'btn's height to 180.
                        btn.Height = 180;
                        // Set 'btn's width to 180.
                        btn.Width = 180;
                        // Set 'btn's back color to green.
                        btn.BackColor = Color.SeaGreen;
                        // Set 'btn's fore color to white.
                        btn.ForeColor = Color.White;
                        // Set the 'btn's text to the plugin name.
                        btn.Text = name;
                        // Set the 'btn's name to 'btn' plus the plugin name.
                        btn.Name = "btn" + name;
                        // Set the font of 'btn' to 'Segoe UI'.
                        btn.Font = new Font("Segoe UI", 16);
                        // Add the 'btn' to the plugins list.
                        flpPlugins.Controls.Add(btn);
                        // Run the interfaces button adder function (with 'btn').
                        PI.EmployeeButtonAdder(btn);
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
                    // If the type interfaces contains the plugin implementer for the button OR all of the implementers.
                    if (type.GetInterfaces().Contains(typeof(PluginImplementer)))
                    {
                        // Set PI to the new instance of type as the plugin implementer for the button.
                        PI = Activator.CreateInstance(type) as PluginImplementer;
                        // Create a new string called 'name' with the plugin name.
                        string name = PI.PluginName();

                        // Create a new button called 'btn'.
                        Button btn = new Button();
                        // Set 'btn's height to 180.
                        btn.Height = 180;
                        // Set 'btn's width to 180.
                        btn.Width = 180;
                        // Set 'btn's back color to green.
                        btn.BackColor = Color.LightSkyBlue;
                        // Set 'btn's fore color to white.
                        btn.ForeColor = Color.White;
                        // Set the 'btn's text to the plugin name.
                        btn.Text = name;
                        // Set the 'btn's name to 'btn' plus the plugin name.
                        btn.Name = "btn" + name;
                        // Set the font of 'btn' to 'Segoe UI'.
                        btn.Font = new Font("Segoe UI", 16);
                        // Add the 'btn' to the plugins list.
                        flpPlugins.Controls.Add(btn);
                        // Run the interfaces button adder function (with 'btn').
                        PI.EmployeeButtonAdder(btn);
                    }
                }
            }
        }
    }
}
