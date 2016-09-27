using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faraz
{
    public partial class time : Form
    {
        byte hour, second, minutes;
        public time()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            hour = minutes = second = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second += 1;
            if (second==60)
            {
                second = 0;
                minutes += 1;

            }
            if (minutes==60)
            {
                minutes = 0;
                hour += 1;
            }
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}",hour,minutes,second);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
