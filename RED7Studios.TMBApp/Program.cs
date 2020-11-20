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
            // If the direcotry Data doesn't exist.
            if (!Directory.Exists("Data"))
            {
                // Create a new directory called 'Data'.
                Directory.CreateDirectory("Data");
            }
            // Enable visual styles for the application.
            Application.EnableVisualStyles();
            // Set the compatible text rendering default to false.
            Application.SetCompatibleTextRenderingDefault(false);
            // If the Data\connectionString doesn't exist.
            if (!File.Exists("Data\\connectionString"))
            {
                // Run in setup mode.
                Application.Run(new FTS.frmWelcome());
            }
            else
            {
                // Run in normal mode.
                Application.Run(new frmLogin());
            }
        }
    }
}
