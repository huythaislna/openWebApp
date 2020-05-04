using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
   public partial class Client : Form
    {
        TcpClient TcpClient = new TcpClient();
        string readData = null;
        NetworkStream serverStream;
        public Client()
        {
            InitializeComponent();
        }        
        //send a message
        private void SendData(string message)
        {
            byte[] outstream = Encoding.UTF8.GetBytes(message);
            serverStream.Write(outstream, 0, outstream.Length);
            serverStream.Flush();
            url_tb.Text= "";
        }
        //Setup port, ip,.... and start client
        private void Setup()
        {
            try
            {
                TcpClient.Connect(ip_tb.Text, Int32.Parse(port_tb.Text));
            }
            catch
            {
                status_lb.Text = "This port already connected!";
            }
            Thread ctThread = new Thread(ReceiveMessage);
            ctThread.Start();
        }

        //Receive Message from server     
        private void ReceiveMessage()
        {
            while (true)
            {
                serverStream = TcpClient.GetStream();
                var bufferSize = TcpClient.ReceiveBufferSize;
                byte[] instream = new byte[bufferSize];

                serverStream.Read(instream, 0, bufferSize);
                readData = Encoding.UTF8.GetString(instream);
                if (readData == "bye") { this.Close(); }
                notification();

            }
        }

        //Print notification
        private void notification()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(notification));
            }
            else
                status_lb.Text = readData;
        }
        //Enter to send
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendData(url_tb.Text.Trim());
        }
        //click to send
        private void button1_Click(object sender, EventArgs e)
        {
            SendData(url_tb.Text.Trim());
        }

        private void connect_bt_Click(object sender, EventArgs e)
        {
            Setup();
            url_tb.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            introduce intro = new introduce();
            intro.Show();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
