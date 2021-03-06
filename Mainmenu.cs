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
using Microsoft.Owin.BuilderProperties;
using ChatSizeClient2;
using ChatSizeClient;

namespace ChatApplicationLearningSocket
{
    public partial class MainMenu : Form
    {
        public static MainMenu mainMenu = null;
        public static int Cheackstatusserver;
        public string CO = "Close"; //เปิดปิด Menu
        public string Namesend; //ส่งชื่อ
        public int ConnectedtoserverText = 0;

        public void PM(string CodeSend) //ส่ง Code
        {
            Permission.Text = CodeSend.ToString();
            Permission.Visible = false;
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

        public MainMenu() // Main
        {
            Client.admin = this;
            mainMenu = this;
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
            if (Permission.Text == "AdminCode")
            {
                Server.broadcast(USERNAME.Text, TextAdminSend.Text);
                RealtimeChat.Text += TextAdminSend.Text + "\n";
                TextAdminSend.Text = "";
            }
        }

        public static void recieveData()
        {

        }

        async public void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (CO == "Close")
            {
                MenuOpen();
                USERNAME.Visible = true;
                Permission.Visible = true;
                await Task.Delay(250);
                chatzonebutton.Visible = true;
                await Task.Delay(250);
                ccmodebutton.Visible = true;
                await Task.Delay(250);
                bunifuFlatButton2.Visible = true;
                await Task.Delay(250);
                Coronamap.Visible = true;
                await Task.Delay(250);
                CO = "Open";
            }
            else if (CO == "Open")
            {
                USERNAME.Visible = false;
                chatzonebutton.Visible = false;
                ccmodebutton.Visible = false;
                bunifuFlatButton2.Visible = false;
                Permission.Visible = false;
                Coronamap.Visible = false;
                MenuClose();
                CO = "Close";
            }
        }

        private void MenuOpen()
        {
            while (MenuZone.Width <= 270)
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
            else
            {
                ChatSizeClient.ChatSizeClientMain CSC = new ChatSizeClient.ChatSizeClientMain();
                string namesend = USERNAME.Text;
                CSC.Receivename(namesend);
                CSC.Show();
                Thread URCS = new Thread(UpdateRealtimechatClientSizeLoop);
                URCS.Start();
            }
        }
        public string RealtimeupdateClientSize;
        public void UpdateRealtimechatClientSizeLoop() //อัพเดต Chat ฝั่ง Client
        {
            //while (true)
            //{
                RealtimeupdateClientSize = RealtimeChat.Text;
                ChatSizeClient.ChatSizeClientMain TEST = new ChatSizeClient.ChatSizeClientMain();
                TEST.UpdateRealtimechatClientSize(RealtimeupdateClientSize);
                TEST.REChat(RealtimeupdateClientSize);
            //}
        }

        private delegate void ChatDelegate(string msg);

        // Static method, call the non-static version if the form exist.
        public static void UpdateRealtimeChat(string msg)
        {
            if (mainMenu != null)
                mainMenu.updateRealtimeChat(msg);
        }

        private void updateRealtimeChat(string msg)
        {
            // If this returns true, it means it was called from an external thread.
            if (InvokeRequired)
            {
                // Create a delegate of this method and let the form run it.
                this.Invoke(new ChatDelegate(updateRealtimeChat), new object[] { msg });
                return; // Important
            }

            // Set textBox

            RealtimeChat.Text += msg;
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
                Coronamap.Navigate("https://www.youtube.com/watch?v=N5HxbW_OcJI&list=RDIFd-5K7WWEk&index=9");
                StartSeverAdmin();
            }
            else if (Permission.Text == ("Member"))
            {
                MessageBox.Show("Member Permission");
                this.Text = "USER : MEMBER";
                ASB.Visible = false;
                TextAdminSend.Visible = false;
                TextAdminSend.Enabled = false;
                Thread Startclient = new Thread(StartClient);
                Startclient.Start();
            }
        }

        public void StartClient()
        {
            Client.Start();
            Client.UpdateRealtimechat = this;
        }

        private void ASB_Click(object sender, EventArgs e) //Admin SendText Button
        {
            if (TextAdminSend.Text != null && !string.IsNullOrWhiteSpace(TextAdminSend.Text))
            {
                Server.broadcast(USERNAME.Text, " " + TextAdminSend.Text);
                this.RealtimeChat.Text += (USERNAME.Text + " : " + TextAdminSend.Text + "\r\n");
                TextAdminSend.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            System.Windows.Forms.Application.Exit();
            //System.Environment.Exit(0);
            this.Close();
        }

        private void Coronamap_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void MenuZone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void RealtimeChat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
