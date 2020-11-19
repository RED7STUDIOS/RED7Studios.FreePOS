using RED7Studios.FreePOS.FTS;
using System;
using System.IO;
using System.Windows.Forms;


namespace RED7Studios.FreePOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists("Data\\connectionString"))
            {
                Application.Run(new FTS.frmWelcome());
            }
            else
            {
                Application.Run(new frmLogin());
            }
        }
    }
}
