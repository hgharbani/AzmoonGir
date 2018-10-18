using System;
using System.Windows.Forms;

namespace AzmoonGir
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!System.IO.Directory.Exists(AppConfigration.FileName))
            {
                System.IO.Directory.CreateDirectory(AppConfigration.FileName);
            }
            Application.Run(new Form1());
        }
    }
}