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

        public void updateChat(string msg)
        {
            RealtimeChat.Text += msg;
        }

        public void StartSeverAdmin()
        {
            try
            {
                Thread t = new Thread(Server.Start);
                t.Start();

                this.StatusServer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Green Point");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ADMIN() // Main
        {
            Client.admin = this;
            InitializeComponent();
        }

        //Create Client ============

        public void MultiUser2(object connection)
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
            Server.broadcast(USERNAME.Text, TextAdminSend.Text);
            TextAdminSend.Text = "";
        }

        public static void recieveData()
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

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Permission_Click(object sender, EventArgs e)
        {

        }

        public void ADMINSIZE_Load(object sender, EventArgs e) //Frist Command
        {
            if (Permission.Text == "AdminCode")
            {
                MessageBox.Show("AdminCode Permission");
                this.Text = "USER : ADMIN";
                ASB.Visible = true;
                TextAdminSend.Visible = true;
                StartSeverAdmin();
            }else if (Permission.Text == ("Member"))
            {
                MessageBox.Show("Member Permission");
                this.Text = "USER : MEMBER";
                ASB.Visible = false;
                TextAdminSend.Visible = false;
                TextAdminSend.Enabled = false;
                Thread scn = new Thread(StartClient);
                scn.Start();
            }
        }

        public void StartClient()
        {
            Client.Start();
            
        }
        string SendTextClient;

        private void ASB_Click(object sender, EventArgs e) //Admin SendText Button
        {
            Server.broadcast(USERNAME.Text,"Hello Client");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            System.Windows.Forms.Application.Exit();
            //System.Environment.Exit(0);
            this.Close();
        }
    }
}
