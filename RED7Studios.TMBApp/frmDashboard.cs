using RED7Studios.UI.Forms;
using System;
using System.Windows.Forms;

namespace RED7Studios.FreePOS
{
    public partial class frmDashboard : ModernForm
    {
        string _username;

        string _accessLevel;

        private Token token;

        public frmDashboard(string s, string a)
        {
            InitializeComponent();

            _username = s;
            _accessLevel = a;

            token = new Token();
        }

        private void mtLogout_Click(object sender, EventArgs e)
        {
            Hide();

            frmLogin login = new frmLogin();
            login.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Username: " + _username + " Level: " + _accessLevel);

            if (_accessLevel == "admin")
            {
                mtAdminTasks.Visible = true;
            }
        }

        private void mtCreateOrder_Click(object sender, EventArgs e)
        {
            Hide();
            CreateOrder createOrder = new CreateOrder(_username, _accessLevel);
            createOrder.Show();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* frmLogin login = new frmLogin();
            login.Show(); */
        }

        private void mtOrderList_Click(object sender, EventArgs e)
        {
            Hide();
            OrderList list = new OrderList(_username, _accessLevel);
            list.Show();
        }
    }
}
