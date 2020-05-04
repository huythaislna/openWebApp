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
    public partial class Server : Form
    {
        IPAddress ipAddress = IPAddress.Any;
        Int32 port = 8080;
        TcpListener TcpServer;
        Socket Client;
        NetworkStream clientStream;
        public Server()
        {
            InitializeComponent();
        }
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
        private string ReceiveData() { return "message"; }
        //website is working correctly.
        private bool IsValid(string url) { return true; }
        //Transfer input of user to a valid url(add "http, https")

        private string ValidateUrl(string url) { return url; }
        //Open default Browser
        private void OpenBrowser(string url) { }
        //write to log textbox
        private void Log(string message) { }
    }
}
