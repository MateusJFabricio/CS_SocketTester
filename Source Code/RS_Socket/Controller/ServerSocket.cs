using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace RS_Socket.Controller
{
    class ServerSocket
    {
        private IPAddress ipAddress;
        private int gate;
        private TcpListener tcpListener;
        private TcpClient tcpClient;
        private Boolean waitClient = false;
        private NetworkStream stream;

        public bool isConected
        {
            get
            {
                if (tcpClient != null)
                    return tcpClient.Connected;
                else
                    return false;
            }
        }

        public ServerSocket(string ip, int porta)
        {
            ipAddress = IPAddress.Parse(ip);
            gate = porta;

        }

        public void Start()
        {
            try
            {
                tcpListener = new TcpListener(ipAddress, gate);
                tcpListener.Start();
                waitClient = true;
                tcpClient = tcpListener.AcceptTcpClient();
                waitClient = false;
                stream = tcpClient.GetStream();
            }
            catch (Exception e)
            {
                MessageBox.Show("A porta esta sendo usada por outro processo: " + e.Message);
            }
             
        }

        public void Send(string dados)
        {
            if (tcpClient.Client.Connected)
            {
                byte[] arrayBytesAnswer = ASCIIEncoding.ASCII.GetBytes(dados);
                stream.Write(arrayBytesAnswer, 0, arrayBytesAnswer.Length);
            }
        }

        public string Receive()
        {
            if(tcpClient != null)
            {
                if (tcpClient.Client.Connected && (tcpClient.Available > 0))
                {
                    byte[] arrayBytesRequest = new byte[tcpClient.Available];
                    int nRead = stream.Read(arrayBytesRequest, 0, arrayBytesRequest.Length);
                    return ASCIIEncoding.ASCII.GetString(arrayBytesRequest);
                }
            }

            return "";
        }

        public void Disconect()
        {
            if (tcpClient.Client.Connected)
            {
                stream.Close();
                tcpClient.Dispose();
                tcpClient.Close();
                tcpListener.Stop();
            }
        }

        public IPAddress IpAddress { get => ipAddress; }
        public int Port { get => gate; }
        public bool WaitClient { get => waitClient;}
        public int Available {
            get {
                if (tcpClient != null)
                    return tcpClient.Available;
                else
                    return 0;
            }
        }
    }
}
