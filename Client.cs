﻿using System;
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
        public static ADMIN admin;
        public static void Start()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 5000;
            client = new TcpClient();
            client.Connect(ip, port);
            MessageBox.Show("client connected!!");
            ns = client.GetStream();
            thread = new Thread(o => ReceiveData((TcpClient)o));
            thread.Start(client);
        }

        public static void sendData(String username, String msg)
        {
            string s;
            byte[] buffer = Encoding.ASCII.GetBytes(msg);
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
    }
}