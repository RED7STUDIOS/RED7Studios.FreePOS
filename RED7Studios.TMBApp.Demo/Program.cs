using System;
using System.Windows.Forms;


namespace RED7Studios.TMBApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show("This program is for demo purposes only. Stuff in this demo is subject to change. Servers may shut down for the demo!", "DEMO APPLICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Run(new frmLogin());
        }
    }
}
