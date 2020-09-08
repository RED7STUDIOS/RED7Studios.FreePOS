using System;
using System.Windows.Forms;

namespace RED7Studios.TMBApp
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void mtLogout_Click(object sender, EventArgs e)
        {
            Hide();

            frmLogin login = new frmLogin();
            login.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            mtAdminTasks.Visible = true;
        }

        private void mtCreateOrder_Click(object sender, EventArgs e)
        {
            Hide();
            CreateOrder createOrder = new CreateOrder();
            createOrder.Show();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void mtOrderList_Click(object sender, EventArgs e)
        {
            Hide();
            OrderList list = new OrderList();
            list.Show();
        }
    }
}
