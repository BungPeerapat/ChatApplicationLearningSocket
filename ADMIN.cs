using BunifuAnimatorNS;
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
using Microsoft.Owin.BuilderProperties;

namespace ChatApplicationLearningSocket
{
    public partial class ADMIN : Form
    {
        public string CO = "Close"; //เปิดปิด Menu
        public string Namesend; //ส่งชื่อ

        public Socket Connect { get; private set; }

        public void PM(string CodeSend) //ส่ง Code
        {
            Permission.Text = CodeSend.ToString();
            Permission.Visible = false;
        }

        public void StartSeverAdmin()
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
            sock.Listen(10);
            while (true)
            {
                this.StatusServer.Image = (Image) Properties.Resources.ResourceManager.GetObject("Green Point");
                Socket connection = sock.Accept();
                Thread clientThread = new Thread(new ParameterizedThreadStart(MultiUser));
                clientThread.Start(connection);

                if (connection.Connected)
                {
                    Console.Beep();
                    StatusServer.Refresh();
                    MessageBox.Show("Client Connected!");
                }
            }
        }

        public ADMIN() // Main
        {
            InitializeComponent();
        }

        //Create Client ====================
        public void StartClient()
        {
            byte[] bytes = new byte[1024];
                // Connect to a Remote server  
                // Get Host IP Address that is used to establish a connection  
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
                // If a host has multiple addresses, you will get a list of addresses  
                IPHostEntry host = Dns.GetHostEntry("127.0.0.1");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 1433);
            // Create a TCP/IP  socket.    
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

            // Connect the socket to the remote endpoint. Catch any errors.
            while (sender == null || !sender.Connected)
            {
                Console.Beep(); //Test
                Console.Beep(); //Test
                Console.Beep(); //Test
                Task.Delay(5000);
                try
                {
                    sender.Connect(remoteEP);                            // Connect to Remote EndPoint  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            try
            {
                try
                {
                    if (sender.Connected)
                    {
                        Console.Beep();
                        StatusServer.Refresh();
                        MessageBox.Show("Connected to Server.");
                        this.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Green Point");
                    }
                    else
                    {
                        MessageBox.Show("Wait responed from Server.");
                        this.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Red Point");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RealtimeChat.Text = "Connected to Server" + "\n";
                sender.RemoteEndPoint.ToString();

                // Encode the data string into a byte array.    
                byte[] NCT = Encoding.ASCII.GetBytes(USERNAME.Text + " : " + " Connected " + " \r\n ");
                // USERNAME.Text + " : " + " Connected " + " \r\n "

                // Send the data through the socket.    
                int bytesSentNCT = sender.Send(NCT);

                // Receive the response from the remote device.    
                int bytesRecNCT = sender.Receive(bytes);
                Console.WriteLine("Echoed test = {0}",
                Encoding.ASCII.GetString(bytes, 0, bytesRecNCT));

            }
            catch (ArgumentNullException ane)
            {
                RealtimeChat.Text = "ArgumentNullException : " + ane.Message;
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }

            // Encode the data string into a byte array.    

            byte[] msg = Encoding.ASCII.GetBytes(USERNAME.Text + " : " + IPAddress.Any + " : " + " Connected " + " \r\n ");

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

        //Create Client ============

        public void MultiUser(object connection)
        {
            byte[] serverBuffer = new byte[10025];
            string message = string.Empty;

            int bytes = ((Socket)connection).Receive(serverBuffer, serverBuffer.Length, 0);
            message += Encoding.ASCII.GetString(serverBuffer, 0, bytes);
            RealtimeChat.Text = " : " + message + "\n";

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

        private void ADMINSIZE_Load(object sender, EventArgs e) //Frist Command
        {
            this.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Red Point");
            if (Permission.Text == "AdminCode")
            {
                MessageBox.Show("AdminCode Permission");
                this.Text = "USER : ADMIN";
                StartSeverAdmin();
            }else if (Permission.Text == ("Member"))
            {
                MessageBox.Show("Member Permission");
                this.Text = "USER : MEMBER";
                Thread ClientThread = new Thread(StartClient);
                ClientThread.Start();
            }
        }
    }
}
