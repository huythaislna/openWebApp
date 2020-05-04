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
        IPAddress ipAddress;
        Int32 port;
        TcpClient TcpClient = new TcpClient();
        NetworkStream serverStream;
        public Client()
        {
            InitializeComponent();
        }
        //Process everything of client (use for button click)
        private void Process() { }
        //Setup port, ip,.... and start client
        private void Setup() { }
        //listen to client for sending and receiving
        private void Listen(object clientObj) { }
        //waiting for client and accept connection
        private void Connect() { }
        //send a message
        private void SendData(string message) { }
        //get message from client
        private string ReceiveData() { return "message"; }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void banner_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
