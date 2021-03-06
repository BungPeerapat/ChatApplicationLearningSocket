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
        public static MainMenu UpdateRealtimechat;
        public static int ConnectedtoserverText;
        public static MainMenu Cheackstatusserver;
        public static Thread thread;
        public static MainMenu admin;
        public static IPAddress ip;
        public static int port;



        public static void Start()
        {   
            string hostname = "mashirotan.ddns.net";

            IPAddress[] hostIP = Dns.GetHostAddresses(hostname);

            //IPAddress ip = IPAddress.Parse("192.168.2.33"); สำหรับ IP;

            int port = 1443;
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(hostIP, port); //ถ้าจะเปลี่ยนเป็น IP ให้เปลี่ยน hostIP เป็น ip
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            //*****
            while (!client.Connected)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(hostIP, port);
                    Console.Beep();
                    Task.Delay(3000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            ns = client.GetStream();
            //byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(admin.USERNAME.Text + " : " + " Conneceted ");
            //ns.Write(bytesToSend, 0, bytesToSend.Length);
            Console.Beep();
            //*****
            MessageBox.Show("Connected");
            
            MainMenu.mainMenu.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Green Point");
            Thread clientReceive = new Thread(o => ReceiveData((TcpClient)o));
            clientReceive.Start(client);
            sendData("[" + admin.Permission.Text + "]",":" + admin.USERNAME.Text, "Connected to Server" + "\r\n");
            

            //if (client.Connected)
            //{
            //    admin.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Green Point");
            //    admin.RealtimeChat.Text += "Connected To Server" + " \r\n ";
            //}
            //if (!client.Connected)
            //{
            //    admin.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Red Point");
            //    admin.RealtimeChat.Text += "Disconect from Server" + " \r\n ";
            //}

            MainMenu.mainMenu.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Green Point");


            //Thread cheackstatusserver = new Thread(ConnectedStatusclient);
            //cheackstatusserver.Start();
        }
        public static void sendData(string PermissionText, String usernamesend, String bytesToSend)
        {
            MessageBox.Show(bytesToSend);
            byte[] buffer = Encoding.ASCII.GetBytes(PermissionText + usernamesend + " : " + bytesToSend);
            ns.Write(buffer, 0, buffer.Length);
        }
        public static void disconnect()
        {
            client.Client.Shutdown(SocketShutdown.Send);
            MainMenu.mainMenu.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Red Point");
            MessageBox.Show("Server Down.");
            ns.Close();
            client.Close();
            Start();
            //Console.ReadKey();
        }

        public static void ReceiveData(TcpClient client)
        {
            while (true)
            {

                try
                {
                    NetworkStream ns = client.GetStream();
                    Client.client = client;
                    byte[] receivedBytes = new byte[1024];
                    int byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length);
                    while ((byte_count) > 0)
                    {
                        //Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
                        MainMenu.UpdateRealtimeChat(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
                        break;
                    }
                    if ((byte_count) == 0)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    disconnect();
                }
            }
        }

        public static void ConnectedStatusclient()
        {
            while (client.Connected)
            {
                MainMenu.Cheackstatusserver = 1;
            }
            MainMenu.Cheackstatusserver = 0;
        }
    }
}
