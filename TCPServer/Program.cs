using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TCPServerTest
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
                Application.Run (new TCPServerTest ());
            }
            else
            {
                Application.Run (new TCPServerTest (Convert.ToUInt16(args[1])));
            }

        }
    }
}
