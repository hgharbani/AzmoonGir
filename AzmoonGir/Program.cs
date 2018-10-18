using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzmoonGir
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
            if (!System.IO.Directory.Exists(AppConfigration.FileName))
            {
                System.IO.Directory.CreateDirectory(AppConfigration.FileName);

            }
            Application.Run(new Form1());

        }
    }
}
