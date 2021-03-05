using RED7Studios.FreePOS.PluginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.Plugins.EnterpriseSolutions
{
    public class Starter : PluginImplementer
    {
        public string PluginName()
        {
            // This is for the plugin name.
            return "Enterprise Solutions";
        }

        public string PluginVersion()
        {
            // This is for the plugin version.
            return "1.0.0.0";
        }

        public string PluginAuthor()
        {
            // This is the plugin author, normally your name or alias.
            return "Creaous (RED7 STUDIOS)";
        }

        public string PluginSignature()
        {
            // Signature
            return Cryptography.Decrypt("WjeHtrdJ1WBCW+ySrCFLMEq4dBwMTJ8MRH98/sfwJ457mJ5iG+GrnXeZcichCUuKz0bQE2Bgf26nlNojochJd5PsT7e2eOIcNANsd0ejvCIA8UeA9xHW7M0Tr3QoE4pI3vGDZNvdybHPxd79pcanLJHc8GozzlIM0pa1+V5r9w6g+f5luPHQSQtYK/SQbIpMbtF9aNXb8LjQ0JP4kw3SU0cXbb3A5EfGF/Mav5mrkau5lbUu7dk8VFPqVaHOfe9L1mUxJBNc5hLK49lZ+5wGK8eAymB7KJwl9g4OqDhuYhuCGgt6kKEKmIs3R+6n/kyqVX60cirMpafW+yhBwGIf7lBlE+8b3tk/vrj8/0Y65Ok3NXcUWCcQwvsXvCir4wVJds0G/yT1qlnBkeprCKLHDXbLo0dFsSo2rSADGR1oG6MI16iolxdh0JmlHRSIKB7e+KGeG9DkJ3rP79NIIsZZyfDpq92ZB4DIm0/ErbLaM6NpxOl714DArIx0llbdgO5jeETkzmY7ISRAmntSiSfvDzZv6KCL4r+1vQT6zUYUa+19/rxFSnG8CDrYaHhi+FMJPUxutA/0dD6KpekQWqyPJVEWUMKXFj0ncVUrtQ1pLnC4PUHkQR/mtRrBVlv+v+1g71w6hd6RK5rg6PMbtwSPd4LHkL2hwFVnScOreVhXeW/pLSU10D3AQ+YzJrUzZuXqvN/1M6RVYgUH3e1o4REbL5obQdfI9W3Qs1s9BNFHnJv5v0x9vxOAoWK1fZeZuCU2Msa+mKCCibn4u2j/cvRuQpph5jblOGzala5QkcbvSuqy0vJbEVRWgFhnlCq2/fDHyDeM+w8MZqoLgaCGN9QJ7dQyp62wxg68M6XYtF8QohiNtaWgZs9nTj6NtKmYWDVUfKYgVbshlThq6HEWvqgD4JKzmTO47LpVBMJbcwH67Y0VoEo1eOz6w4zfHOMdYMTC/OVwaldeBgOers1ZSOy8DJMAr4q2YFB2Lw8m5pRGZz82OtZBMHn+jxhaCP+g0iENAfGdjBHA4bGNL2cygUeXhK0H8gHt2NUF7sDfypmjOtste5evWYpFjzUYEH9rZoMO");
        }

        public string PluginDescription()
        {
            // This is for your plugin description.
            return "An enterprise plugin for enterprise solutions.";
        }

        public Icon PluginIcon()
        {
            // Don't mess with this.
            return Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        }

        public void AdminButtonAdder(Button btn)
        {
            // Set the button click to the button click function here.
            btn.Click += AdminButton_Click;
        }

        public void EmployeeButtonAdder(Button btn)
        {
            // Set the button click to the button click function here.
            btn.Click += EmployeeButton_Click;
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

        public void AdminButton_Click(object sender, EventArgs e)
        {
            frmAdminButton adminButton = new frmAdminButton();
            adminButton.Show();
        }

        public void EmployeeButton_Click(object sender, EventArgs e)
        {
            frmEmployeeButton employeeButton = new frmEmployeeButton();
            employeeButton.Show();
        }
    }
}
