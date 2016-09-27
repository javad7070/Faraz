using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace faraz
{
    public partial class notepad : Form
    {
        string textData;
        public notepad()
        {
            InitializeComponent();
        }

        private void فایلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            menuStrip1.BackColor = colorDialog1.Color;
        }

        private void جدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentText.Text = "";
        }

        private void کپیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentText.Copy();
        }

        private void چسباندنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentText.Paste();
        }

        private void ذخیرهکردنفایلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "باز کردن فایل";
            openFileDialog1.Filter = "فایل متنی (*.txt)|*.txt|انواع فایل ها (*.*)|*.*";
            textData = "" + fileContentText.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textData);
            }
            MessageBox.Show("فایل با موفقیت ذخیره شد", "ثبت فایل جدید");

        }

        private void بازکردنفایلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";

            openFileDialog1.FileName = String.Empty;


            DialogResult result = openFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                Stream fs = openFileDialog1.OpenFile();

                StreamReader reader = new StreamReader(fs);

                fileContentText.Text = reader.ReadToEnd();

                reader.Close();
            }
        }

        private void بریدنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentText.Cut();
        }

        private void پرینتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ذخیرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "فایل متنی (*.txt)|*.txt|انواع فایل ها (*.*)|*.*";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
                    fileContentText.SaveFile(saveFileDialog1.FileName.ToString(), RichTextBoxStreamType.PlainText);
            }
            catch (Exception ex)
            {
                // Show the error to the user.
                MessageBox.Show("خطا در ذخیره فایل" + Environment.NewLine + "نام فایل یا سطح دسترسی به فایل را بررسی کنید." + Environment.NewLine + Environment.NewLine + "Exception: " + ex.Message);

            }
        }

        private void تغییرترازبهراستToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentText.RightToLeft = RightToLeft.Yes;
        }

        private void تغییرترازبهچپToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentText.RightToLeft = RightToLeft.No;
        }

        private void تغییرترازبهوسطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            right.Checked = false;
            left.Checked = false;
            center.Checked = true;
            fileContentText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void دیدنپرینتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog PrintPreviewDialog = new PrintPreviewDialog();

            PrintPreviewDialog.Document = printDocument1;

            if (PrintPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(fileContentText.Text);
                reader = new StringReader(fileContentText.Text);



                printDocument1.Print();

            }
        }

        private void تنظیماتبرگهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
   ("آیا واقعا میخواهید از برنامه خارج شوید؟\n تمام فایل ها باز شده بسته شوند",
   "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                //code for Cancel
                return;
            }
        }

        private void فونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            fileContentText.Font = fontDialog1.Font;
        }

        private void رنگپسزمینهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            fileContentText.BackColor = colorDialog1.Color;
        }

        private void رنگمتنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            fileContentText.ForeColor = colorDialog1.Color;
        }

        private void پاککردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentText.Clear();
            fileContentText.Focus();
        }

        private void انتخابهمهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentText.SelectAll();
        }

        private void جستوجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find f1 = new find();
            f1.ShowDialog();
            if (f1.getFindWord() != "")
            {

                int index = 0;
                while (index != -1 && index < fileContentText.Text.Length)
                {
                    index = fileContentText.Text.IndexOf(f1.getFindWord(), index);
                    if (index != -1)
                    {
                        fileContentText.Select(index, f1.getFindWord().Length);
                        index++;
                        f1.ShowDialog();
                    }
                }
            }
            MessageBox.Show("عملیات پایان یافت", "جستوجو");

        
        
        }

        private void جستوجووجایگزینیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replace r1 = new replace();
            r1.ShowDialog();
            String findWord = r1.findWord;
            String replaceWord = r1.replaceWord;
            if (findWord != "")
            {
                fileContentText.Text = fileContentText.Text.Replace(findWord, replaceWord);
                MessageBox.Show("پایان جایگزینی", "پایان", MessageBoxButtons.OK);
            }
          
            
        }
    }
}
