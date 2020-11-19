using MySql.Data.MySqlClient;
using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.FTS
{
    public partial class frmDefaultAdmin : ModernForm
    {
        MySqlConnection conn = new MySqlConnection(File.ReadAllText("Data\\connectionString"));

        public frmDefaultAdmin()
        {
            InitializeComponent();
        }

        private void frmDefaultAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "Insert into users (id, username, password, first, last, level) values " +
               "('" + "1" + "', '" + tbUser.Text + "', '" + tbPass.Text + "', '" + tbFirst.Text + "', '" + tbLast.Text + "', '" + "admin" + "')";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //This is command class which will handle the query and connection object.  
                MySqlCommand command = new MySqlCommand(Query, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Successfully made an admin account!", "SYSTEM");
                conn.Close();

                Hide(); 

                frmOptional optional = new frmOptional();
                optional.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "CRITICAL ERROR!");
            }
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Hide();

            frmDatabase database = new frmDatabase();
            database.Show();  
        }
    }
}
