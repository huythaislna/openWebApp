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
        IPAddress ipAddress;
        Int32 port = 8080;
        TcpListener TcpServer;
        Socket Client = null;
        NetworkStream clientStream;


        public Server()
        {
            InitializeComponent();
        }
        //Setup port, ip,.... and start server
        private void Setup()
        {
            CheckForIllegalCrossThreadCalls = false;
            ipAddress = IPAddress.Parse("127.0.0.1");
            port = Int32.Parse(port_tb.Text);
            TcpServer = new TcpListener(IPAddress.Any, port);
            TcpServer.Start();
            //status.Text = "Waiting for a connection...";
            Thread serverThread = new Thread(Connect);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        //waiting for client and accept connection
        private void Connect()
        {
            while (true)
            {
                Client = TcpServer.AcceptSocket();
                var t = new Thread(new ParameterizedThreadStart(Listen));
                t.IsBackground = true;
                t.Start(Client);
            }
        }

        //listen to client for sending and receiving
        private void Listen(object clientObj)
        {
            Log("Connect ", "Connected", Client.RemoteEndPoint.ToString());
            SendData("Connected to server!", clientObj);
            string stt;
            while (true)
            {
                try
                {
                    urlprocess.Text = ReceiveData();
                    SendData("Processing...", clientObj);

                    string url = ValidateUrl(urlprocess.Text);
                    OpenBrowser(url);

                    if (IsValid(url))
                    {
                        SendData("Successful", clientObj);
                        stt = "Successful";
                    }
                    else
                    {
                        SendData("Unsuccessful", clientObj);
                        stt = "Unsuccessful";
                    }

                    Log(urlprocess.Text, stt, Client.RemoteEndPoint.ToString());
                }
                catch
                {
                    clientStream.Flush();
                    clientStream.Close();
                    return;
                }
            }
        }

        //send a message
        private void SendData(string message, object clientObj)
        {
            Client = clientObj as Socket;
            clientStream = new NetworkStream(Client);
            byte[] noti = Encoding.UTF8.GetBytes(message);
            clientStream.Write(noti, 0, noti.Length);
        }

        //get message from client
        private string ReceiveData()
        {
            byte[] buffer = new byte[Client.ReceiveBufferSize];
            clientStream.Read(buffer, 0, buffer.Length);

            string mess = Encoding.UTF8.GetString(buffer);
            return mess;

        }

        //website is working correctly.
        private bool IsValid(string url)
        {
            try
            {
                //Creating the HttpWebRequest 
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too. 
                request.Method = "HEAD";
                //Getting the Web Response. 
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200 
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Any exception will returns false. 
                return false;
            }
        }

        //Transfer input of user to a valid url(add "http, https")
        private string ValidateUrl(string url)
        {
            string head = "http://";
            string head1 = "https://";
            if (url.Contains(head) || url.Contains(head1))
                return url;
            else
                return head + url;
        }

        //Open default Browser
        private void OpenBrowser(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        //write to log textbox
        private void Log(string data, string stt, string cli)
        {
            ListViewItem x = new ListViewItem(data);
            ListViewItem.ListViewSubItem y = new ListViewItem.ListViewSubItem(x, stt);
            ListViewItem.ListViewSubItem z = new ListViewItem.ListViewSubItem(x, cli);
            ListViewItem.ListViewSubItem t = new ListViewItem.ListViewSubItem(x, DateTime.Now.ToString());

            x.SubItems.Add(y);
            x.SubItems.Add(z);
            x.SubItems.Add(t);
            log_tb.Items.Add(x);
        }

        private void start_bt_Click(object sender, EventArgs e)
        {
            start_bt.Enabled = false;
            Setup();
            power_lb.Text = "ON";
            power_lb.ForeColor = System.Drawing.Color.Green;
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Client != null)
            {
                clientStream.Flush();
                clientStream.Close();
                Client.Close();
            }
        }
    }
}
