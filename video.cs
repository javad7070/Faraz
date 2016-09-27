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
    public partial class video : Form
    {
        public video()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "mp4 files|*.mp4";

            ofd.Title = "لطفا فایل مورد نظر را انتخاب کنید";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                WindowsMediaPlayer1.URL = ofd.FileName;
            }



            WindowsMediaPlayer1.Ctlcontrols.stop();

            WindowsMediaPlayer1.Ctlcontrols.pause();

            WindowsMediaPlayer1.Ctlcontrols.previous();

            WindowsMediaPlayer1.Ctlcontrols.next();

            WindowsMediaPlayer1.Ctlcontrols.fastForward();

            WindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.pause();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
