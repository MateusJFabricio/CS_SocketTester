using RS_Socket.Controller;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace RS_Socket.Model
{
    class RSModel
    {
        private ClientSocket client;
        private ServerSocket server;

        public bool isClientConection {
            get {
                if (client != null)
                    return client.isConected;
                else
                    return false;
            }
        }
        public bool isServerConection
        {
            get
            {
                if (server != null)
                {
                    return server.isConected;
                }
                else
                    return false;
            }
        }

        public object[] ListIP {
            get {
                string dnsName = Dns.GetHostName();

                IPAddress[] ip = Dns.GetHostAddresses(dnsName);
                List<string> ips = new List<string>();
                for (int i = 0; i < ip.Length; i++)
                {
                    if (ip[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        ips.Add(ip[i].ToString());
                    }
                }
                object[] ret = new object[ips.Count];

                for (int i = 0; i < ips.Count; i++)
                {
                    ret[i] = ips[i];
                }

                return ret;
            }
        }

        public bool VerifyIp(String ip)
        {
            IPAddress a ;
            return IPAddress.TryParse(ip, out a);
        }

        public bool VerifyGate(String gate)
        {
            int a;
            return int.TryParse(gate, out a);
        }
        
        public void connectClientSocket(string ip, string porta)
        {
            client = new ClientSocket(ip, int.Parse(porta));
            client.Connect();
        }

        public void connectServerSocket(string ip, string porta)
        {
            server = new ServerSocket(ip, int.Parse(porta));
            server.Start();
        }

        public void sendClientMessage(string message)
        {
            client.send(message);
        }

        public void sendServerMessage(string message)
        {
            server.Send(message);
        }

        public string receiveClientMessage()
        {
            return client.receive();
        }

        public string receiveServerMessage()
        {
            return server.Receive();
        }
        
        internal void disconectClientSocket()
        {
            client.Disconect();
        }

        internal void disconectServerSocket()
        {
            server.Disconect();
        }
    }
}
