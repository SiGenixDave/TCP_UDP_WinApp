using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UDPClientTest
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
                Application.Run (new UDPClientTest ());
            }
            else
            {
                Application.Run (new UDPClientTest (args[1], args[2]));
            }

        }
    }
}
