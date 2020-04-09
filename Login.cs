using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ChatApplicationLearningSocket
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SpeakerCute1(string url)
        {
            WMPLib.WindowsMediaPlayer SC1 = new WMPLib.WindowsMediaPlayer();
            SC1.URL = url;
            SC1.controls.play();
            SC1.settings.volume = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (USERNAMETEXT.Text == "AdminCode" && PASSWORDTEXT.Text == "74122541")
            {
                USERNAMETEXT.ForeColor = Color.Green;
                Console.Beep();
                PASSWORDTEXT.ForeColor = Color.Green;
                Console.Beep();
                MessageBox.Show("Welcome Admin");
                ADMINSIZE ADMINSIZEOPEN = new ADMINSIZE();
                ADMINSIZEOPEN.Show();
                SpeakerCute1(@"C:\\Users\\BungK\\source\\repos\\ChatApplicationLearningSocket\\ChatApplicationLearningSocket\\Sound\\Loading Sound.wav");


            }
            if (USERNAMETEXT.Text == "QUEST" && PASSWORDTEXT.Text == "QUEST")
            {
                USERNAMETEXT.ForeColor = Color.Green;
                Console.Beep();
                PASSWORDTEXT.ForeColor = Color.Green;
                Console.Beep();
                MessageBox.Show("Welcome Normal Member");
            }
        }
    }
}
