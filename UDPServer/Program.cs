using System;
using System.Windows.Forms;

namespace UDPServerTest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main ()
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);

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