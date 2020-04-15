using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WMPLib;


namespace ChatApplicationLearningSocket
{
    public partial class Login : Form
    {
        String CodeSend;
        public Login()
        {
            InitializeComponent();
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
                MainMenu ADMINSIZEOPEN = new MainMenu();
                CodeSend = USERNAMETEXT.Text;
                ADMINSIZEOPEN.PM(CodeSend);
                ADMINSIZEOPEN.Show();
                this.Hide();


            }
            if (USERNAMETEXT.Text == "Member" && PASSWORDTEXT.Text == "Pass")
            {
                USERNAMETEXT.ForeColor = Color.Green;
                Console.Beep();
                PASSWORDTEXT.ForeColor = Color.Green;
                Console.Beep();
                MessageBox.Show("Welcome Member");
                MainMenu MainMenu = new MainMenu();
                CodeSend = USERNAMETEXT.Text;
                MainMenu.PM(CodeSend);
                MainMenu.Show();
                this.Hide();
            }
        }

        private void BGLOGIN_Click(object sender, EventArgs e)
        {

        }
    }
}
