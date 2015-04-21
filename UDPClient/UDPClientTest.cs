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


namespace UDPClientTest
{
    public partial class UDPClientTest : Form
    {
        #region Private Members

        // Client socket
        private Socket clientSocket;

        // Server End Point
        private EndPoint epServer;

        // Data stream
        private byte[] dataStream = new byte[1024];

        #endregion

        #region Constructor

        public UDPClientTest ()
        {
            InitializeComponent ();
        }

        public UDPClientTest (String address, String port) : this()
        {
            txtServerIP.Text = address;
            txtServerPort.Text = port;
        }


        #endregion

        #region Events

        private void Client_Load (object sender, EventArgs e)
        {
        }

        private void btnSend_Click (object sender, EventArgs e)
        {
            try
            {
                // Get packet as byte array
                byte[] byteData = Encoding.ASCII.GetBytes (txtMessage.Text);

                // Send packet to the server
                clientSocket.BeginSendTo (byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback (this.SendData), null);

                txtMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Send Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_FormClosing (object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.clientSocket != null)
                {
                    // Close the socket
                    this.clientSocket.Close ();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Closing Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click (object sender, EventArgs e)
        {
            try
            {
                // Initialize socket
                this.clientSocket = new Socket (AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Initialize server IP
                IPAddress serverIP = IPAddress.Parse (txtServerIP.Text.Trim ());

                // Initialize the IPEndPoint for the server and use desired port
                IPEndPoint server = new IPEndPoint (serverIP, Convert.ToInt32 (txtServerPort.Text));

                // Initialize the EndPoint for the server
                epServer = (EndPoint)server;

                // Get packet as byte array
                byte[] data = Encoding.ASCII.GetBytes ("Connect");

                // Send data to server
                clientSocket.BeginSendTo (data, 0, data.Length, SocketFlags.None, epServer, new AsyncCallback (this.SendData), null);

                // Initialize data stream
                this.dataStream = new byte[1024];

                //
                groupBox1.Enabled = false;

                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Connection Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click (object sender, EventArgs e)
        {
            Close ();
        }

        #endregion

        #region Send And Receive

        private void SendData (IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSend (ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Send Data: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion


        private void timer1_Tick (object sender, EventArgs e)
        {
            SendCycleMessages ();
        }

        private void buttonStart_Click (object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            timer1.Interval = Convert.ToInt32 (cycleTime.Value);
            timer1.Enabled = true;
            cycle++;
            msgCounter = 1;
        }

        private void buttonStop_Click (object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            timer1.Enabled = false;
        }

        int msgCounter;
        int cycle;
        private void SendCycleMessages ()
        {
            int count = Convert.ToInt32 (messagesPerCycle.Value);
            int localMsgCounter = 1;
            while (localMsgCounter <= count)
            {
                // Get packet as byte array
                byte[] byteData = Encoding.ASCII.GetBytes ("DISP: " + cycle.ToString ("X") + ":" + msgCounter.ToString ("X"));

                // Send packet to the server
                clientSocket.BeginSendTo (byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback (this.SendData), null);

                localMsgCounter++;
                msgCounter++;
            }
        }
    }
}
