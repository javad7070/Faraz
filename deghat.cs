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
    public partial class deghat : Form
    {
        bool palay = false;
        public deghat()
        {
            InitializeComponent();
        }

        private void deghat_MouseEnter(object sender, EventArgs e)
        {
            if (palay)
            {


                MessageBox.Show("بازی رو باختی!", "gameover", MessageBoxButtons.OK, MessageBoxIcon.Information);
                palay = false;
            }
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            if (palay)
            {
                MessageBox.Show("بازی رو بردی هوراا!!", "game to win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                palay = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            palay = true;
        }

        private void deghat_Load(object sender, EventArgs e)
        {

        }
    }
}
