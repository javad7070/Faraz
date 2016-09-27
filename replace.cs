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
    public partial class replace : Form
    {
        public String findWord;
        public String replaceWord;
        public replace()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            findWord = "";
            replaceWord = "";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findWord = findText.Text;
            replaceWord = replaceText.Text;
            this.Close();
        }
    }
}
