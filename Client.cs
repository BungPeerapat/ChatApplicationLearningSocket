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
        public static IPAddress ip;
        public static int port;

        public static void Start()
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
            MessageBox.Show("Server Don't Online. and will reconnected now.");
            while (!client.Connected)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(ip, port);
                    Console.Beep();
                    Task.Delay(3000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Task.Delay(1500);
            }
            MessageBox.Show("หลุด While !client.Connected");
            Console.Beep();
            //*****
            ns = client.GetStream();
            thread = new Thread(o => ReceiveData((TcpClient)o));
            thread.Start(client);
            Cheackstatusserver();
        }

        public static void sendData(String username, String TextAdminSend)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(TextAdminSend);
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
