using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UDPServerTest
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
            string[] args = Environment.GetCommandLineArgs ();

            if (args.Length == 1)
            {
                Application.Run (new UDPServerTest ());
            }
            else
            {
                Application.Run (new UDPServerTest (Convert.ToUInt16 (args[1])));
            }
        }
    }
}
