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
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tas g= new tas();
            g.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hads h = new hads();
            h.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deghat y = new deghat();
            y.ShowDialog();
        }
    }
}
