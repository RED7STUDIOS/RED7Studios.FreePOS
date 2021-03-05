using RED7Studios.FreePOS.PluginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ExamplePlugin
{
    public class Starter : PluginImplementer
    {
        public string PluginName()
        {
            // This is for the plugin name.
            return "Example Plugin";
        }

        public string PluginVersion()
        {
            // This is for the plugin version.
            return "1.0.0.0";
        }

        public string PluginAuthor()
        {
            // This is the plugin author, normally your name or alias.
            return "Example Author";
        }

        public string PluginSignature()
        {
            // Signature
            return "JibTdHy1xTYOHo2ah5bXPVp84445psPCspumlw0S34Hv5hi404IZYEStR9ysCTA0FvvwiedADVMYK3PY2VTJDIEWCyXi1vkhue9UWHkF2s2Ys6qX28Wc0j3ipiQd6D0sFyIthmPDl1jcGe6KlnfcLoNh6jbaIN8Wxu0a4lTRBgoRjcEIi06mvYRNEoM1imnNjszIYRZY";
        }

        public string PluginDescription()
        {
            // This is for your plugin description.
            return "Just an example plugin to show off if it works!";
        }

        public Icon PluginIcon()
        {
            // Don't mess with this.
            return Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        }

        public void AdminButtonAdder(Button btn)
        {
            // Set the button click to the button click function here.
            btn.Click += button_Click;
        }

        public void EmployeeButtonAdder(Button btn)
        {
            // Set the button click to the button click function here.
            btn.Click += button_Click;
        }

        public void DashboardMenuAdder(ToolStripMenuItem tsi)
        {
            tsi.Visible = false;
        }

        public void CreateOrderMenuAdder(ToolStripMenuItem tsi)
        {
            tsi.Visible = false;
        }

        public void OrderListMenuAdder(ToolStripMenuItem tsi)
        {
            tsi.Visible = false;
        }

        public void button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
