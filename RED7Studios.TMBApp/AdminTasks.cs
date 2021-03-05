using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RED7Studios.UI.Forms;

namespace RED7Studios.FreePOS
{
    public partial class AdminTasks : ModernForm
    {
        // Create string for username.
        string _username;

        // Create string for level.
        string _accessLevel;

        // Create variable for token.
        private Token token;

        public AdminTasks(string s, string a)
        {
            if (a == "admin")
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("You are not an administrator, you cannot access this feature.", "CRITCAL ERROR");
            }

            // Set the passed username to the string (s).
            _username = s;
            // Set the passed level to the string (a).
            _accessLevel = a;

            // Create new Token for the username and level.
            token = new Token();
        }

        private void AdminTasks_Load(object sender, EventArgs e)
        {

        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtGoBack_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create new frmDashboard called 'dash' and pass username and access level.
            frmDashboard dash = new frmDashboard(_username, _accessLevel);
            // Show the 'dash' form.
            dash.Show();
        }

        private void AdminTasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create new frmDashboard called 'dash' and pass username and access level.
            frmDashboard dash = new frmDashboard(_username, _accessLevel);
            // Show the 'dash' form.
            dash.Show();
        }

        private void mtUserManager_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create new frmDashboard called 'dash' and pass username and access level.
            AT_UserManager userman = new AT_UserManager(_username, _accessLevel);
            // Show the 'dash' form.
            userman.Show();
        }

        private void mtItemManager_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create new frmDashboard called 'dash' and pass username and access level.
            AT_ItemManager itemman = new AT_ItemManager(_username, _accessLevel);
            // Show the 'dash' form.
            itemman.Show();
        }

        private void mtComingSoon_Click(object sender, EventArgs e)
        {
            // Hide this form.
            Hide();

            // Create new frmDashboard called 'dash' and pass username and access level.
            ServerSettings serverSettings = new ServerSettings(_username, _accessLevel);
            // Show the 'dash' form.
            serverSettings.Show();
        }

        private void mtPlugins_Click(object sender, EventArgs e)
        {
            // Create new AT-Plugins called 'plugins' and pass username and access level.
            AT_Plugins plugins = new AT_Plugins(_username, _accessLevel);
            // Show the 'plugins' form.
            plugins.Show();
        }
    }
}
