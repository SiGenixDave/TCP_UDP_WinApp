using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TCPServerTest
{
    public partial class TCPServerTest : Form
    {
        TcpServer _tcpServer;
        EchoServiceProvider _provider;
        UInt16 _port;
        
        public TCPServerTest (UInt16 port = 12345)
        {
            _port = port;
            InitializeComponent();
        }

        public void UpdateTestBox (Object textBoxInfo)
        {
            // Required so another thread can update UI
            if (InvokeRequired)
            {
                Invoke (new System.Threading.WaitCallback (UpdateTestBox), textBoxInfo);
                return;
            }
 
            rtxtStatus.Text += (string)textBoxInfo;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            _provider = new EchoServiceProvider (this);
            _tcpServer = new TcpServer (_provider, _port, this);
            this.Text += " - Port:" + _port.ToString ();
            _tcpServer.Start ();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

               
        #region Other Methods

        private void UpdateStatus(string status)
        {
            rtxtStatus.Text += status + Environment.NewLine;
            // Force vertical scroll to bottom of multi-line textbox
            rtxtStatus.SelectionStart = rtxtStatus.Text.Length;
            rtxtStatus.ScrollToCaret();
            rtxtStatus.Refresh();
        }

        #endregion
    }
}