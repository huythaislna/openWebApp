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

namespace Server
{
    public partial class Form1 : Form
    {
        IPAddress ipAddress = IPAddress.Any;
        Int32 port = 8080;
        TcpListener Server;
        Socket Client;
        NetworkStream clientStream;
        public Form1()
        {
            InitializeComponent();
        
        //Process everything of server (use for button click)
        private void Process() { }
        //Setup port, ip,.... and start server
        private void Setup() { }
        //listen to client for sending and receiving
        private void Listen(object clientObj) { }
        //waiting for client and accept connection
        private void Connect() { }
        //send a message
        private void SendData(string message) { }
        //get message from client
        private string ReceiveData() { }
        //website is working correctly.
        private bool IsValid(string url) { }
        //Transfer input of user to a valid url(add "http, https")

        private string ValidateUrl(string url) { }
        //Open default Browser
        private void OpenBrowser(string url) { }
    }
}
