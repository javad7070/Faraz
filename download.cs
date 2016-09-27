using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;

namespace faraz
{
    public partial class download : Form
    {
        int a;

        WebClient wc = new WebClient();
        public download()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
            string select = textBox1.Text.ToString();
            string[] wordarry = select.Split('/');
            for (int i = 0; i < Int32.Parse(wordarry.Length.ToString()); i++)
            {
                if (i == Int32.Parse(wordarry.Length.ToString()) - 1)
                {
                    textBox2.Text += "\\" + wordarry[i].ToString();
                }

            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text.Trim();

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("کادر نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(textBox1.Text.Trim().ToString()), textBox2.Text.Trim());
                label3.Visible = true;
                label4.Visible = false;
            }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("فایل به طور کامل دانلود شد!");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "باز کردن فایل";
            openFileDialog1.Filter = "فایل متنی (*.txt)|*.txt|انواع فایل ها (*.*)|*.*";
            string textData = "" + textBox1.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textData);
            }
            MessageBox.Show("فایل با موفقیت ذخیره شد", "ذخیره فایل");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
