using RED7Studios.UI.Forms;
using System;
using System.Windows.Forms;

namespace RED7Studios.FreePOS
{
    public partial class frmDashboard : ModernForm
    {
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
            InitializeComponent();

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
            // Show a message box to say that it is still in development.
            MessageBox.Show("This feature is still under developement. To create users, please login to the database.");
        }
    }
}
