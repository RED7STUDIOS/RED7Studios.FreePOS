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

namespace RED7Studios.FreePOS
{
    public partial class frmSettings : ModernForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnRedoFTS_Click(object sender, EventArgs e)
        {
            // Delete the "connectionString" file.
            File.Delete("Data\\connectionString");
            // Delete the "Data" Directory.
            Directory.Delete("Data");
            // Restart the program.
            Application.Restart();
        }
    }
}
