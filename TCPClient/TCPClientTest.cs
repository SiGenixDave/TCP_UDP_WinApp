using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TCPClientTest
{
    public partial class TCPClientTest : Form
    {
        #region Private Members

        // Client socket
        private TcpClient tcpClient;

        #endregion Private Members

        #region Constructor

        public TCPClientTest ()
        {
            InitializeComponent ();
        }

        #endregion Constructor

        #region Events

        private void Client_Load (object sender, EventArgs e)
        {
        }

        private void btnSend_Click (object sender, EventArgs e)
        {
            try
            {
                NetworkStream stm = tcpClient.GetStream ();

                // Get packet as byte array
                byte[] byteData = Encoding.ASCII.GetBytes (txtMessage.Text);

                if (byteData.Length != 0)
                {
                    stm.Write (byteData, 0, byteData.Length);

                    byte[] bb = new byte[1000];
                    stm.ReadTimeout = 500; 
                    int k = stm.Read (bb, 0, 1000);

                    if (k != 0)
                    {
                        lblSingleServerResp.Text = Encoding.ASCII.GetString (bb, 0, k);
                    }

                }

                txtMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Send Error: " + ex.Message, "TCP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_FormClosing (object sender, FormClosingEventArgs e)
        {
            try
            {
                if (tcpClient != null)
                {
                    // Close the socket
                    tcpClient.Close ();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Closing Error: " + ex.Message, "TCP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click (object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient ();

                // Initialize server IP
                IPAddress serverIP = IPAddress.Parse (txtServerIP.Text.Trim ());

                UInt16 serverPort = Convert.ToUInt16 (txtServerPort.Text);
                tcpClient.Connect (serverIP, serverPort);

                NetworkStream stm = tcpClient.GetStream ();

                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Connection Error: " + ex.Message, "TCP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click (object sender, EventArgs e)
        {
            NetworkStream stm = tcpClient.GetStream ();
            stm.Close ();
            tcpClient.Close ();
            Close ();
        }

        #endregion Events

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

        private int msgCounter;
        private int cycle;

        private void SendCycleMessages ()
        {
            int count = Convert.ToInt32 (messagesPerCycle.Value);
            int localMsgCounter = 1;
            byte[] bb = new byte[100];

            while (localMsgCounter <= count)
            {
                NetworkStream stm = tcpClient.GetStream ();

                // Get packet as byte array
                byte[] byteData = Encoding.ASCII.GetBytes ("DISP: " + cycle.ToString ("X") + ":" + msgCounter.ToString ("X"));

                try
                {
                    if (stm.CanWrite)
                    {
                        stm.Write (byteData, 0, byteData.Length);
                    }

                    if (stm.CanRead)
                    {
                        int k = stm.Read (bb, 0, 100);
                        if (k != 0)
                        {
                            lblContinuousServerResp.Text = Encoding.ASCII.GetString (bb, 0, k);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show ("Send Error: " + ex.Message, "TCP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                localMsgCounter++;
                msgCounter++;
            }
        }
    }
}