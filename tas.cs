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
    public partial class tas : Form
    {
        public tas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Visible = true;
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int i;

               listBox1.Items.Clear();
               Random r = new Random();
               i = r.Next(1, 7);
               listBox1.Items.Add(i);

               
               if (i == 6)
               {
                   MessageBox.Show("آفرین!");

               }

                 
               
            
           
            
        }

        
    }
}
