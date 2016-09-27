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
    public partial class hads : Form
    {
        string t1;
        int coin = 0;
        public hads()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text.Trim();

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("کادر نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                 t1 = textBox1.Text;
                 
                    switch (t1)
                    {
                        case "گنجشک سربی":
                          MessageBox.Show("عالی بود!");
                            coin += 1;
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = true;
                            
                            break;


                        case "توکای سیاه":
                            MessageBox.Show("عالی بود!");
                            coin += 2;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = true;
                            break;
                        case "بوف کوچک":
                           MessageBox.Show("عالی بود!");
                            coin += 2;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = true;
                            break;
                        case "حواصیل خاکستری":
                            MessageBox.Show("عالی بود!");
                            coin += 2;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = true;
                            break;
                        case "پیتای بال‌آبی":
                         MessageBox.Show("عالی بود!");
                         coin += 2;
                         pictureBox5.Visible = false;
                            pictureBox6.Visible = true;
                            break;
                        case "پیتای زنگارگون":
                           MessageBox.Show("عالی بود!");
                           coin += 2;
                           pictureBox6.Visible = false;
                            pictureBox7.Visible = true;
                            break;
                        case "سرسبز":
                            MessageBox.Show("عالی بود!");
                            coin += 2;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = true;
                            break;
                        case "باکلان بزرگ":
                            MessageBox.Show("عالی بود!");
                            coin += 2;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = true;
                            break;
                        case "صدف‌خوار ابلق":
                            MessageBox.Show("عالی بود!");
                            coin += 2;
                            pictureBox9.Visible = false;
                            pictureBox10.Visible = true;
                            break;
                        case "زنبورخوار اروپایی":
                            MessageBox.Show("عالی بود!");
                            coin += 2;
                            pictureBox10.Visible = false;
                            pictureBox11.Visible = true;
                            break;
                        case "ماکائو آبی و زرد":
                          MessageBox.Show("عالی بود!");
                          coin += 2;
                          pictureBox11.Visible = false;
                            pictureBox12.Visible = true;
                            break;
                        case "هما":
                           MessageBox.Show("عالی بود!");
                           coin += 2;
                           pictureBox12.Visible = false;
                            pictureBox13.Visible = true;
                            break;
                        case "ماکائو آبی سنبلی":
                        MessageBox.Show("عالی بود!");
                        coin += 2;
                        pictureBox13.Visible = true;
                            pictureBox14.Visible = true;
                            break;
                        case "پی‌پت پا دراز":
                            MessageBox.Show("عالی بود!");
                            coin += 2;
                            pictureBox14.Visible = false;
                            pictureBox15.Visible = true;
                            break;
                        case "جغد سوراخ‌نشین":
                            MessageBox.Show("عالی بود!");
                            coin += 2;

                            break;

                        default:
                            MessageBox.Show("اشتباه بود:(");
                            break;
                           }
                            label1.Text = coin.ToString();
                    
                    
                }

        private void button2_Click(object sender, EventArgs e)
        {
              
        
        }

        private void دریافتسکهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حالا ازت یه سوال میکنم اگه جواب دادی سکه میبری!","دریافت سکه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label2.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string q;
            textBox2.Text.Trim();

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("کادر نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           q= textBox2.Text;
           if (q=="آدا لاولیس")
           {
               MessageBox.Show("هورااا!100سکه جایزه شما");
               coin += 100;
               label1.Text = coin.ToString();
               label2.Visible = false;
               textBox2.Visible = false;
               button3.Visible = false;
           }
            else
	{
               MessageBox.Show("اشتباه بود مجدد تلاش کن");
	}
        }

        }
    }

