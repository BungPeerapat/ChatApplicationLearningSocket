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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (MenuSlip.Width <= 603)
            {
                MenuSlip.Width += 1;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
