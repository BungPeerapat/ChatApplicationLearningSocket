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
    public static class Client
    {
        public static NetworkStream ns;
        public static TcpClient client;
        public static Thread thread;
        public static MainMenu admin;
        public static MainMenu usersend;
        public static IPAddress ip;
        public static int port;
        public static readonly object _lock = new object();
        public static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();



        public static async void Start()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 1443;
            client = new TcpClient();
            try
            {
                client.Connect(ip, port);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            //*****
            if (!client.Connected)
            {
                admin.RealtimeChat.Text += "Loading..." + " \n ";
                MessageBox.Show("Server Don't Online. and will reconnected now.");

            }
            while (!client.Connected)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(ip, port);
                    Console.Beep();
                    await Task.Delay(3000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                await Task.Delay(1500);
            }
            string textConnectedtoserver = usersend.USERNAME.Text + " : " + " Conneceted ";
            admin.RealtimeChat.Text += "Connected To Server" + " \r\n ";
            await Task.Delay(1000);
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textConnectedtoserver);
            Console.WriteLine(textConnectedtoserver);
            ns.Write(bytesToSend, 0, bytesToSend.Length);
            MessageBox.Show("เข้าสู่ BytesToSend ไปแล้ว Edit2");
            Console.Beep();
            //*****
            ns = client.GetStream();
            thread = new Thread(o => ReceiveData((TcpClient)o));
            thread.Start(client);
            Cheackstatusserver();
        }

        public static void sendData(String usernamesend, String bytesToSend)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(bytesToSend);
            ns.Write(buffer, 0, buffer.Length);

        }
        public static void disconnect()
        {
            client.Client.Shutdown(SocketShutdown.Send);
            thread.Join();
            ns.Close();
            client.Close();
            MessageBox.Show("disconnect from server!!");
            //Console.ReadKey();
        }

        public static void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                //Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
                admin.updateChat(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
            }
        }

        public static void Cheackstatusserver()
        {
            if (Client.client.Connected)
            {
                admin.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Green Point");
                MessageBox.Show("Connected!");
            }
            if (!Client.client.Connected)
            {
                admin.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Red Point");
            }
        }
    }
}
