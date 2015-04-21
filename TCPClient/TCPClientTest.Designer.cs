namespace TCPClientTest
{
    partial class TCPClientTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBytesRx = new System.Windows.Forms.Label();
            this.upDownMsgSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSendLargeMsg = new System.Windows.Forms.Button();
            this.lblSingleServerResp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblContinuousServerResp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.messagesPerCycle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.cycleTime = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMsgSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagesPerCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleTime)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(75, 27);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(150, 20);
            this.txtServerIP.TabIndex = 3;
            this.txtServerIP.Text = "192.168.56.102";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(231, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(131, 46);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(8, 22);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(262, 57);
            this.txtMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(276, 22);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 57);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServerPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server Port:";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(75, 53);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(150, 20);
            this.txtServerPort.TabIndex = 6;
            this.txtServerPort.Text = "30002";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server IP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBytesRx);
            this.groupBox2.Controls.Add(this.upDownMsgSize);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonSendLargeMsg);
            this.groupBox2.Controls.Add(this.lblSingleServerResp);
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Single Message";
            // 
            // lblBytesRx
            // 
            this.lblBytesRx.AutoSize = true;
            this.lblBytesRx.Location = new System.Drawing.Point(163, 148);
            this.lblBytesRx.Name = "lblBytesRx";
            this.lblBytesRx.Size = new System.Drawing.Size(61, 13);
            this.lblBytesRx.TabIndex = 6;
            this.lblBytesRx.Text = "Bytes Rx = ";
            // 
            // upDownMsgSize
            // 
            this.upDownMsgSize.Location = new System.Drawing.Point(196, 124);
            this.upDownMsgSize.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.upDownMsgSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownMsgSize.Name = "upDownMsgSize";
            this.upDownMsgSize.Size = new System.Drawing.Size(62, 20);
            this.upDownMsgSize.TabIndex = 5;
            this.upDownMsgSize.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.upDownMsgSize.Value = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "MsgSize";
            // 
            // buttonSendLargeMsg
            // 
            this.buttonSendLargeMsg.Location = new System.Drawing.Point(276, 95);
            this.buttonSendLargeMsg.Name = "buttonSendLargeMsg";
            this.buttonSendLargeMsg.Size = new System.Drawing.Size(86, 57);
            this.buttonSendLargeMsg.TabIndex = 3;
            this.buttonSendLargeMsg.Text = "Send Large Message";
            this.buttonSendLargeMsg.UseVisualStyleBackColor = true;
            this.buttonSendLargeMsg.Click += new System.EventHandler(this.buttonSendLargeMsg_Click);
            // 
            // lblSingleServerResp
            // 
            this.lblSingleServerResp.AutoSize = true;
            this.lblSingleServerResp.Location = new System.Drawing.Point(8, 84);
            this.lblSingleServerResp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSingleServerResp.Name = "lblSingleServerResp";
            this.lblSingleServerResp.Size = new System.Drawing.Size(121, 13);
            this.lblSingleServerResp.TabIndex = 2;
            this.lblSingleServerResp.Text = "Single Server Response";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(288, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblContinuousServerResp);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.messagesPerCycle);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonStop);
            this.groupBox3.Controls.Add(this.buttonStart);
            this.groupBox3.Controls.Add(this.cycleTime);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(12, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 160);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exercise System";
            // 
            // lblContinuousServerResp
            // 
            this.lblContinuousServerResp.AutoSize = true;
            this.lblContinuousServerResp.Location = new System.Drawing.Point(12, 133);
            this.lblContinuousServerResp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContinuousServerResp.Name = "lblContinuousServerResp";
            this.lblContinuousServerResp.Size = new System.Drawing.Size(145, 13);
            this.lblContinuousServerResp.TabIndex = 3;
            this.lblContinuousServerResp.Text = "Continuous Server Response";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Messages Per Cycle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cyce Time";
            // 
            // messagesPerCycle
            // 
            this.messagesPerCycle.Location = new System.Drawing.Point(163, 97);
            this.messagesPerCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.messagesPerCycle.Name = "messagesPerCycle";
            this.messagesPerCycle.Size = new System.Drawing.Size(54, 20);
            this.messagesPerCycle.TabIndex = 4;
            this.messagesPerCycle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ms";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(268, 97);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(78, 43);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(270, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(78, 43);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // cycleTime
            // 
            this.cycleTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cycleTime.Location = new System.Drawing.Point(163, 42);
            this.cycleTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cycleTime.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cycleTime.Name = "cycleTime";
            this.cycleTime.Size = new System.Drawing.Size(54, 20);
            this.cycleTime.TabIndex = 0;
            this.cycleTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TCPClientTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TCPClientTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Client (v 1.0.0.2)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMsgSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagesPerCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown messagesPerCycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown cycleTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSingleServerResp;
        private System.Windows.Forms.Label lblContinuousServerResp;
        private System.Windows.Forms.Button buttonSendLargeMsg;
        private System.Windows.Forms.NumericUpDown upDownMsgSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBytesRx;
    }
}

