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
        public ADMINSIZE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        async private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MenuOpen();
            USERNAME.Visible = true;
            Console.Beep();
            await Task.Delay(250);
            chatzonebutton.Visible = true;
            Console.Beep();
            await Task.Delay(250);
            bunifuFlatButton1.Visible = true;
            Console.Beep();
            await Task.Delay(250);
            bunifuFlatButton2.Visible = true;
            Console.Beep();
            await Task.Delay(250);
            bunifuFlatButton3.Visible = true;
            Console.Beep();
            await Task.Delay(250);
            bunifuFlatButton4.Visible = true;
            Console.Beep();
            await Task.Delay(250);
        }

        private void MenuOpen()
        {
            while(MenuZone.Width <= 300)
            {
                MenuZone.Width += 1;
                Task.Delay(500);
            }
        }

        private void chatzonebutton_Click(object sender, EventArgs e)
        {

        }
    }
}
