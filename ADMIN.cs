using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplicationLearningSocket
{
    public partial class ADMINSIZE : Form
    {
        public string CO = "Close"; //เปิดปิด Menu

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
            while(MenuZone.Width >= 10)
            {
                MenuZone.Width -= 1;
            }
        }

        private void chatzonebutton_Click(object sender, EventArgs e)
        {
            ChatZone ChatZoneopen = new ChatZone();
            ChatZoneopen.Show();
        }
    }
}
