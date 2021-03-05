using Newtonsoft.Json.Linq;
using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RED7Studios.FreePOS.Plugins.EnterpriseSolutions
{
    public partial class frmAdminButton : ModernForm
    {
        public frmAdminButton()
        {
            InitializeComponent();
        }

        private void frmAdminButton_Load(object sender, EventArgs e)
        {

        }

        private void btnRemovePluginsButtonForEmployees_Click(object sender, EventArgs e)
        {
            UpdateTokenValue("RemovePluginsButtonFromDashboard", "true");
        }

        string UpdateTokenValue(string TokenName, string newValue)
        {
            using (StreamReader r = new StreamReader(@"Data\\settings.json"))
            {
                JObject jsonObj = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(r.ReadToEnd());
                jsonObj.Property(TokenName).Value = newValue;
                return Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj);
            }
        }
    }
}
