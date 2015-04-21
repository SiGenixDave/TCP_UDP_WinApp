using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using System.Collections;

namespace UDPServerTest
{
    public partial class UDPServerTest : Form
    {
        #region Private Members

        // Structure to store the client information
        private struct Client
        {
            public EndPoint endPoint;
            public string name;
        }

        private UInt16 _port;

        // Listing of clients
        private ArrayList clientList;

        // Server socket
        private Socket serverSocket;

        // Data stream
        private byte[] dataStream = new byte[1024];

        // Status delegate
        private delegate void UpdateStatusDelegate (string status);
        private UpdateStatusDelegate updateStatusDelegate = null;

        #endregion

        #region Constructor

        public UDPServerTest (UInt16 port = 12345)
        {
            _port = port;
            InitializeComponent ();
        }

        #endregion

        #region Events

        private void Server_Load (object sender, EventArgs e)
        {
            try
            {
                // Initialize the ArrayList of connected clients
                this.clientList = new ArrayList ();

                // Initialize the delegate which updates the status
                this.updateStatusDelegate = new UpdateStatusDelegate (this.UpdateStatus);

                // Initialize the socket
                serverSocket = new Socket (AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Initialize the IPEndPoint for the server and listen on port 30000
                IPEndPoint server = new IPEndPoint (IPAddress.Any, _port);

                // Associate the socket with this IP address and port
                serverSocket.Bind (server);

                // Initialize the IPEndPoint for the clients
                IPEndPoint clients = new IPEndPoint (IPAddress.Any, 0);

                // Initialize the EndPoint for the clients
                EndPoint epSender = (EndPoint)clients;

                // Start listening for incoming data
                serverSocket.BeginReceiveFrom (this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epSender, new AsyncCallback (ReceiveData), epSender);

                lblStatus.Text = "Listening";

                this.Text += " - Port:" + _port.ToString ();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error";
                MessageBox.Show ("Load Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click (object sender, EventArgs e)
        {
            Close ();
        }

        #endregion

        #region Send And Receive

        public void SendData (IAsyncResult asyncResult)
        {
            try
            {
                serverSocket.EndSend (asyncResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show ("SendData Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveData (IAsyncResult asyncResult)
        {
            try
            {
                // Initialize the IPEndPoint for the clients
                IPEndPoint clients = new IPEndPoint (IPAddress.Any, 0);

                // Initialize the EndPoint for the clients
                EndPoint epSender = (EndPoint)clients;

                // Receive all data
                serverSocket.EndReceiveFrom (asyncResult, ref epSender);

                string s = Encoding.ASCII.GetString (dataStream).TrimEnd ((Char)0);

                dataStream = new byte[1024];

                // Listen for more connections again...
                serverSocket.BeginReceiveFrom (this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epSender, new AsyncCallback (this.ReceiveData), epSender);

                // Update status through a delegate
                this.Invoke (this.updateStatusDelegate, new object[] { s });
            }
            catch (Exception ex)
            {
                MessageBox.Show ("ReceiveData Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Other Methods

        private void UpdateStatus (string status)
        {
            rtxtStatus.Text += status + Environment.NewLine;
            // Force vertical scroll to bottom of multi-line textbox
            rtxtStatus.SelectionStart = rtxtStatus.Text.Length;
            rtxtStatus.ScrollToCaret ();
            rtxtStatus.Refresh ();
        }

        #endregion
    }
}