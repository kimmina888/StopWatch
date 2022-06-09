using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
           /* printtext.Text += "*";*/

            Button btn = (Button)sender;
            btn.Text = "또 눌러?";
            printtext.Text += "*";
            tb.Text += "*";
            if(timer1.Enabled  == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapasedTime++;
            printtext.Text = elapasedTime + "초 경과";
            tb.Text = elapasedTime + "초 경과";
            ProgressBar.Value = elapasedTime;
        }

        private int elapasedTime = 0;
    }
}
