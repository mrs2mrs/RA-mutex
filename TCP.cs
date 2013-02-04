using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Collections;

namespace RicartAgrawala2
{
    class TCP
    {
        public static String SearchIPs()
        {
            String ret = "";
            IPAddress[] ipAddrList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ipAddrList)
            {
                ret += ip.ToString() + System.Environment.NewLine;
            }
            Console.WriteLine(ret);
            return ret;
        }

    }

    class MessageBuffer
    {
        static MessageBuffer instance = new MessageBuffer();

        public static MessageBuffer get()
        {
            return instance;
        }

        IList synchronizedList;

        public MessageBuffer()
        {
            synchronizedList = ArrayList.Synchronized(new List<string>());
        }

        public void PushForward(string v)
        {
            synchronizedList.Add(v);
        }

        public bool HasElement()
        {
            return 0 != synchronizedList.Count;
        }

        public string PopBack()
        {
            if (HasElement())
            {
                int last_index = synchronizedList.Count - 1;
                string result = (string)synchronizedList[last_index];
                synchronizedList.RemoveAt(last_index);
                return result;
            }
            return null;
        }
    }
/*
    class ServerOLD
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        private bool killMe = false;

        public ServerOLD(String stringIP, int port)
        {
            try
            {
                this.tcpListener = new TcpListener(IPAddress.Parse(stringIP), port);
                this.listenThread = new Thread(new ThreadStart(ListenForClients));
                this.listenThread.Start();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: ", e);
            }
            
        }

        private void ListenForClients()
        {
            try
            {
                this.tcpListener.Start();

                while (!killMe)
                {
                    //blocks until a client has connected to the server
                    TcpClient client = this.tcpListener.AcceptTcpClient();
                    //tcpListener.BeginAcceptTcpClient
                    //create a thread to handle communication 
                    //with connected client
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                    clientThread.Start(client);
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: ", e);
            }
            finally
            {
                // Stop listening for new clients.
                tcpListener.Stop();
            }
        }

        private void newListenThread()
        {

        }

        public void Dispose()
        {
            if (listenThread != null)
            {
                killMe = true;
                listenThread.Join();
                listenThread = null;
                tcpListener = null;
                killMe = false;
            }
        }



    }
    */
    class Server
    {
        private TcpListener tcpListener;

        public Server(String stringIP, int port)
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Parse(stringIP), port);
                tcpListener.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("tcpListener Start error: ", e);
                return;
            }
            BeginListen();
        }

        static void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            if (null != tcpClient && tcpClient.Connected)
            {
                NetworkStream clientStream = tcpClient.GetStream();

                byte[] message = new byte[4096];
                int bytesRead;

                while (true)
                {
                    bytesRead = 0;

                    try
                    {
                        //blocks until a client sends a message
                        bytesRead = clientStream.Read(message, 0, 4096);
                    }
                    catch
                    {
                        //a socket error has occured
                        break;
                    }

                    if (bytesRead == 0)
                    {
                        //the client has disconnected from the server
                        break;
                    }

                    //message has successfully been received
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
                    String s = encoder.GetString(message, 0, bytesRead);
                    //Console.WriteLine("push to msg buff");
                    MessageBuffer.get().PushForward(s);
                }
                tcpClient.Close();
            }
        }

        static void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            Server server = (Server)ar.AsyncState;
            try
            {
                
                TcpListener listener = server.tcpListener;
                if (null != listener)
                {
                    TcpClient client = listener.EndAcceptTcpClient(ar);
                    if (null != client && client.Connected)
                    {
                        Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                        clientThread.Start(client);
                        Console.WriteLine("Client connected completed");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("DoAcceptTcpClientCallback error: " + e.ToString());
            }

            server.BeginListen();
        }

        void BeginListen()
        {
            // Start to listen for connections from a client.
            Console.WriteLine("Waiting for a connection...");
            try
            {
                // Accept the connection.  
                // BeginAcceptSocket() creates the accepted socket.
                if (null != tcpListener)
                {
                    tcpListener.BeginAcceptTcpClient(
                        new AsyncCallback(DoAcceptTcpClientCallback),
                        this);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("tcpListener BeginAcceptTcpClient error: " + e.ToString());
            }
        }

        public void Dispose()
        {
            if (null != tcpListener)
            {
                tcpListener.Stop();
            }
            tcpListener = null;
        }
    }

    class Client
    {
        private TcpClient client;
        private IPEndPoint serverEndPoint;

        public int port { get { return serverEndPoint.Port; } }
        public string IPaddr { get { return serverEndPoint.Address.ToString() ; } }

        public Client(String stringIP, int port)
        {
            try
            {
                client = new TcpClient();

                serverEndPoint = new IPEndPoint(IPAddress.Parse(stringIP), port);

                client.Connect(serverEndPoint);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: ", e);
            }

        }

        public void dispose()
        {
            this.client.Close();
        }

        public void SendMessage(String msg)
        {
            if (client.Connected)
            {
                NetworkStream clientStream = client.GetStream();

                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] buffer = encoder.GetBytes(msg);

                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();
            }
            else
                Form1.printLog("SendMessage error: client not connected");
        }


  }
}
    

