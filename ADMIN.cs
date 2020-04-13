﻿using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using ChatSize_ADMIN_;
using System.Threading;
using Microsoft.AspNet.SignalR.Infrastructure;
using System.Drawing.Imaging;

namespace ChatApplicationLearningSocket
{
    public partial class ADMINSIZE : Form
    {
        public string CO = "Close"; //เปิดปิด Menu
        public string Namesend; //ส่งชื่อ

        public Socket Connect { get; private set; }

        public void PM(string CodeSend) //ส่ง Code
        {
            Permission.Text = CodeSend.ToString();
            Permission.Visible = false;
        }

        public void StartSever()
        {
            try
            {

                Thread serverThread = new Thread(listenToClient);
                serverThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listenToClient()
        {
            IPAddress SetupServer = IPAddress.Parse("127.0.0.1");
            IPEndPoint SetupServerEP = new IPEndPoint(SetupServer, 1433);
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            sock.Bind(SetupServerEP);
            sock.Listen(5);
            while (true)
            {
                this.StatusServer.Image = (Image) Properties.Resources.ResourceManager.GetObject("Green Point");
                Socket connection = sock.Accept();
                Thread clientThread = new Thread(new ParameterizedThreadStart(MultiUser));
                clientThread.Start(connection);

                if (connection.Connected)
                {
                    Console.Beep();
                    MessageBox.Show("Client Connected!");
                    StatusServer.Refresh();
                }
            }
        }
        public ADMINSIZE()
        {
            InitializeComponent();
            this.StatusServer.Image = (Image) Properties.Resources.ResourceManager.GetObject("Red Point");
            if (Permission.Text == "AdminCode Permission")
            {
                StartSever();
            }else
            {
                MessageBox.Show("Quest Permission");
            }
        }

        //Create Client ====================
        publice static void StartClient()
        {
            try
            {
                // Connect to a Remote server  
                // Get Host IP Address that is used to establish a connection  
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
                // If a host has multiple addresses, you will get a list of addresses  
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP  socket.    
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.    
                try
                {
                    // Connect to Remote EndPoint  
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.    
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                    // Send the data through the socket.    
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.    
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // Release the socket.    
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    //Create Client ============

        public static void MultiUser(object connection)
        {
            byte[] serverBuffer = new byte[10025];
            string message = string.Empty;

            int bytes = ((Socket)connection).Receive(serverBuffer, serverBuffer.Length, 0);
            message += Encoding.ASCII.GetString(serverBuffer, 0, bytes);
            Console.WriteLine(message);

            TcpClient client = new TcpClient();
            client.Client = ((Socket)connection);
            IntPtr handle = client.Client.Handle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        async private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (CO == "Close")
            {
                MenuOpen();
                USERNAME.Visible = true;
                Permission.Visible = true;
                await Task.Delay(250);
                chatzonebutton.Visible = true;
                await Task.Delay(250);
                bunifuFlatButton1.Visible = true;
                await Task.Delay(250);
                bunifuFlatButton2.Visible = true;
                await Task.Delay(250);
                bunifuFlatButton3.Visible = true;
                await Task.Delay(250);
                bunifuFlatButton4.Visible = true;
                await Task.Delay(250);
                CO = "Open";
            }else if ( CO == "Open")
            {
                USERNAME.Visible = false;
                chatzonebutton.Visible = false;
                bunifuFlatButton1.Visible = false;
                bunifuFlatButton2.Visible = false;
                bunifuFlatButton3.Visible = false;
                bunifuFlatButton4.Visible = false;
                Permission.Visible = false;
                MenuClose();
                CO = "Close";
            }
        }

        private void MenuOpen()
        {
            while(MenuZone.Width <= 270)
            {
                MenuZone.Width += 1;
                Task.Delay(500);
            }
        }
        private void MenuClose()
        {
                MenuZone.Width -= 210;
                Task.Delay(500);
        }

        private void chatzonebutton_Click(object sender, EventArgs e)
        {
            if (Permission.Text == "AdminCode")
            {
                Namesend = USERNAME.Text;

                ChatSize_ADMIN_.ChatAppAdminSize CSA = new ChatSize_ADMIN_.ChatAppAdminSize();
                CSA.ADMINNAME(Namesend);
                CSA.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Permission_Click(object sender, EventArgs e)
        {

        }
    }
}
