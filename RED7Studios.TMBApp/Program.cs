using AutoUpdaterDotNET;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;

namespace RED7Studios.FreePOS
{
    static class Program
    {
        // Create a new ProgramSettings called 'settings'.
        static ProgramSettings settings = new ProgramSettings();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set the update data json file to contain update data.
            AutoUpdater.PersistenceProvider = new JsonFilePersistenceProvider(Path.Combine(Environment.CurrentDirectory, "Data\\UpdateData.json"));

            // If the directory Data doesn't exist.
            if (!Directory.Exists("Data"))
            {
                // Create a new directory called 'Data'.
                Directory.CreateDirectory("Data");
            }

            // Enable visual styles for the application.
            Application.EnableVisualStyles();

            // Set the compatible text rendering default to false.
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the updater with the NEW url.
            AutoUpdater.Start(settings.UpdateURL + settings.UpdateURLXML);

            // Write a line to the console with the settings.
            Console.WriteLine("\n\nSettings:\nVersion: " + settings.Version + "\nBeta: " + settings.Beta + "\n\nUpdate URL: " + settings.UpdateURL + "\nUpdate Structure: " + settings.UpdateURL + settings.UpdateURLStruct + "\nUpdate XML: " + settings.UpdateURL + settings.UpdateURLXML + "\n\n");

            // If the connection string for the database doesn't exist.
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
