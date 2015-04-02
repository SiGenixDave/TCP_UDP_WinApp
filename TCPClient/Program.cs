using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TCPClientTest
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
                Application.Run (new TCPClientTest ());
            }
            else
            {
                Application.Run (new TCPClientTest (args[1], args[2]));
            }
        }
    }
}
