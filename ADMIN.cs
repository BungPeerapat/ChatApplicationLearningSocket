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

namespace ChatApplicationLearningSocket
{
    public partial class ADMINSIZE : Form
    {
        public string CO = "Close"; //เปิดปิด Menu
        //Server Zone============================================
        private static byte[] buffer = new byte[1024];
        private static List<Socket> clientsockets = new List<Socket>();
        private static Socket SocketServer = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //Server Zone============================================


        private void SetupServer()
        {
            RealtimeChat = ("Server Setting...\n");
            SocketServer.Bind(new IPEndPoint(IPAddress.Any, 1443));
            SocketServer.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = SocketServer.EndAccept(AR);
            clientsockets.Add(socket);
            socket.BeginReceive(buffer, 0,buffer.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            SocketServer.BeginAccept(new AsyncCallback(AcceptCallback), null);

        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(buffer, dataBuf, received);
            string text = Encoder.ASCII.GetString(dataBuf);
            string ShowTextinRealtimechat = text;                   //*****************
            RealtimeChat.Text += ShowTextinRealtimechat + "\r\n";  //*****************



            byte[] data = Encoding.ASCII.GetBytes(text);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback);

        }
        private static void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }


        //Server Zone============================================

        public ADMINSIZE()
        {
            InitializeComponent();
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
                MenuClose();
                CO = "Close";
            }
        }

        private void MenuOpen()
        {
            while(MenuZone.Width <= 300)
            {
                MenuZone.Width += 1;
                Task.Delay(500);
            }
        }
        private void MenuClose()
        {
                MenuZone.Width -= 240;
        }

        private void chatzonebutton_Click(object sender, EventArgs e)
        {
            ChatZone ChatZoneopen = new ChatZone();
            ChatZoneopen.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
