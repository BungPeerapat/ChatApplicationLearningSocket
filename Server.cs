using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplicationLearningSocket
{
    internal class Server
    {
        public static readonly object _lock = new object();
        public static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();
        public static readonly Dictionary<int, String> list_clients_name = new Dictionary<int, String>();
        public static int count;
        public static TcpListener ServerSocket;
        public int Sport;
        private static Thread thread;

        public static void Start()
        {
            int port = 1443;
            string IP = "127.0.0.1";
            TcpListener ServerSocket = new TcpListener(IPAddress.Parse(IP),port);
            ServerSocket.Start();
            MainMenu.mainMenu.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Green Point");
            while (true)
            {
                //int count = 1;
                TcpClient client = ServerSocket.AcceptTcpClient();
                lock (_lock) list_clients.Add(count, client);
                Console.WriteLine("Someone connected!!");
                Thread t = new Thread(handle_clients);
                t.Start(count);
                count++;
            }

        }

        public static void SSIP()
        {
            while (true)
            {
                int count = 1;
                TcpClient client = ServerSocket.AcceptTcpClient();
                lock (_lock) list_clients.Add(count, client);

                Thread t = new Thread(handle_clients);
                t.Start(count);
                count++;
                MessageBox.Show(" Client Connected Now : " + count);
            }
        }

        public static void handle_clients(object o)
        {
            int id = (int)o;
            TcpClient client;

            lock (_lock) client = list_clients[id];

            while (true)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                //Test

                    int byte_count = stream.Read(buffer, 0, buffer.Length);

                try
                {
                    while ((byte_count) > 0)
                    {
                        //Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
                        MainMenu.UpdateRealtimeChat(Encoding.ASCII.GetString(buffer, 0, byte_count));
                        break;

                    }
                    if (byte_count == 0)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //Test Usernamesend [ TOEI ]

                string data = Encoding.ASCII.GetString(buffer, 0, byte_count);
                String[] msg = data.Split(':');
                if (msg[0] == "Member") // Member:YOURNAME
                {
                    list_clients_name[id] = msg[1];
                    MessageBox.Show(msg[0]);
                }
                Console.Write(msg[0]);

                //Test Usernamesend [ TOEI ]
            }

            lock (_lock) list_clients.Remove(id);
        }

        public static void broadcast(string username, string data)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(username + ":" + data + Environment.NewLine);

            lock (_lock)
            {
                foreach (TcpClient c in list_clients.Values)
                {
                    NetworkStream stream = c.GetStream();

                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
