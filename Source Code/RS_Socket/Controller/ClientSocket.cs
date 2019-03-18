using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RS_Socket.Controller
{
    class ClientSocket
    {
        private string sIp;
        private int gate;
        private System.Net.Sockets.Socket sender;
        private byte[] bytes = new byte[1024];
        private bool con = false;
        public bool isConected {
            get
            {
                return con;
            }
            internal set
            {
                con = value;
            }
        }

        public ClientSocket(string ip, int porta)

        {
            sIp = ip;
            gate = porta;
        }

        public void Disconect()
        {
            if (sender != null)
            {
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                isConected = false;
            }
        }

        public void Connect()
        {
            byte[] bytes = new byte[1024];
            IPAddress ip = IPAddress.Parse(sIp);
            IPEndPoint remoteEP = new IPEndPoint(ip, gate);

            sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            { 
                sender.Connect(remoteEP);
                isConected = true;
            }
            catch (ArgumentNullException ane)
            {
                isConected = false;
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                isConected = false;
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                isConected = false;
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
             }

        }

        public string receive()
        {
            if (sender != null)
            {
                if (sender.Available != 0)
                {
                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes);
                    return Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }
            }

            return "";
        }

        public void send(string mensagem)
        {
            // Encode the data string into a byte array.  
            byte[] msg = Encoding.ASCII.GetBytes(mensagem);

            // Send the data through the socket.  
            int bytesSent = sender.Send(msg);
        }


    }
}
