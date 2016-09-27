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
    public partial class Standard_weight : Form
    {
        double weight, Stature, Age,result;
        public Standard_weight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text.Trim();
            
            if (textBox1.Text.Length==0)
            {
                MessageBox.Show("کادراول نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox2.Text.Trim();
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("کادر دوم نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.Text.Trim();
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("کادر سوم نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            weight = Convert.ToDouble(textBox1.Text);
            Stature = Convert.ToDouble(textBox2.Text);
            Age = Convert.ToInt32(textBox3.Text);
            result = weight / (Stature * Stature);
            if (radioButton1.Checked)
            {
                MessageBox.Show("جنسیت:"+"مرد"+"\n" + "وزن:" + weight + "\n" + "قد:" + Stature + "\n" + "سن:" + Age, "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.Add("نتیجه"+(int)result);
                tabControl1.Visible = true;
            }
            
            else if(radioButton2.Checked)
            {
                MessageBox.Show("جنسیت:"+"زن"+"\n" + "وزن:" + weight + "\n" + "قد:" + Stature + "\n" + "سن:" + Age, "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.Add("نتیجه:"+(int)result);
                tabControl1.Visible = true;
            }
        }
    }
}
