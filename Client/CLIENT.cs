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
        NetworkStream serverStream = null;
        public Client()
        {
            InitializeComponent();
        }
        //send a message
        private void SendData(string message)
        {
            try
            {
                byte[] outstream = Encoding.UTF8.GetBytes(message);
                serverStream.Write(outstream, 0, outstream.Length);
                serverStream.Flush();
                url_tb.Text = "";
            }
            catch
            {
                notification("Can't connect to server", "Red");
            }
        }
        //Setup port, ip,.... and start client
        private void Setup()
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                if (TcpClient.Connected) notification("Already connected!", "Orange");
                else TcpClient.Connect(ip_tb.Text, Int32.Parse(port_tb.Text));
                Thread ctThread = new Thread(ReceiveMessage);
                ctThread.Start();
                url_tb.Enabled = true;
                search_bt.Enabled = true;
            }
            catch
            {
                notification("Can't connect to server", "Red");
            }
        }

        //Receive Message from server     
        private void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    serverStream = TcpClient.GetStream();
                    var bufferSize = TcpClient.ReceiveBufferSize;
                    byte[] instream = new byte[bufferSize];
                    serverStream.Read(instream, 0, bufferSize);
                    notification(Encoding.UTF8.GetString(instream), "Green");
                }
                catch
                {
                    notification("Server was closed!", "Red");
                    serverStream.Close();
                    TcpClient.Close();
                    return;
                }
            }
        }

        //Print notification
        private void notification(string message, string color)
        {
            if (message.StartsWith("Unsuccessful")) color = "Red";
            status_lb.Text = message;
            status_lb.ForeColor = Color.FromName(color);
        }
        //Enter to send
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendData(url_tb.Text.Trim());
        }
        private void connect_bt_Click(object sender, EventArgs e)
        {
            Thread stThread = new Thread(Setup);
            stThread.IsBackground = true;
            stThread.Start();
            //Setup();
        }
        //click to send
        private void search_button_Click(object sender, EventArgs e)
        {
            SendData(url_tb.Text.Trim());
        }
    }
}
