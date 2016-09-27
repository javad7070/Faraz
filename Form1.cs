using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faraz
{
    public partial class Form1 : Form
    {
       
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           learn g = new learn();
            g.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game f = new game();
            f.ShowDialog();
        }

        private void کنتومترToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time t = new time();
            t.ShowDialog();
            
        }

        private void ویدیوپلیرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            video k = new video();
            k.ShowDialog();
        }

        private void موزیکپلیرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music l = new music();
            l.ShowDialog();
        }

        private void دفترچهیادداشتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad o = new notepad();
            o.ShowDialog();
        }

        private void دانلودمنیجرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            download n = new download();
            n.ShowDialog();
        }

        private void عشقسنجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            love a = new love();
            a.ShowDialog();
        }

        private void ماشینحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masin p = new masin();
            p.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            MessageBox.Show(DateTime.Now.Date.ToString());
            SoundPlayer Music = new SoundPlayer(Application.StartupPath + @"/mus.wav");
            Music.Play();
        


        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 d = new AboutBox1();
            d.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://telegram.me/javad7070");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            help h = new help();
            h.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text.Trim();
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("کادر نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string run;
            run = textBox1.Text;
            switch (run)
            {
                case "!video":
                case "/video":
                case "#video":
                    video v = new video();
                    v.ShowDialog();
                    break;
                case "!music":
                case "/music":
                case "#music":
                    music m = new music();
                    m.ShowDialog();
                    break;
                case "!game":
                case "/game":
                case "#game":
                    game g = new game();
                    g.ShowDialog();
                    break;
                case "!notepad":
                case "/notepad":
                case "#notepad":
                    notepad n = new notepad();
                    n.ShowDialog();
                    break;
                case "!download":
                case "/download":
                case "#download":
                    download d = new download();
                    d.ShowDialog();
                    break;
                case "!learn":
                case "/learn":
                case "#learn":
                    learn l = new learn();
                    l.ShowDialog();
                    break;
                case "!love":
                case "/love":
                case "#love":
                    love o = new love();
                    o.ShowDialog();
                    break;
                case "!masin":
                case "/masin":
                case "#masin":
                    masin s = new masin();
                    s.ShowDialog();
                    break;
                case "!timer":
                case "/timer":
                case "#timer":
                    time t = new time();
                    t.ShowDialog();
                    break;
                case "!weight":
                case "/weight":
                case "#weight":
                    Standard_weight u = new Standard_weight();
                    u.ShowDialog();
                    break;
                default:
                    MessageBox.Show("دستور مورد نظر یافت نشد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void اجرایدستورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button5.Visible = true;
            hide.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar)==13)
            {
                textBox1.Text.Trim();

                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("کادر نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string run;
                run = textBox1.Text;
                switch (run)
                {
                    case "!video":
                    case "/video":
                    case "#video":
                        video v = new video();
                        v.ShowDialog();
                        break;
                    case "!music":
                    case "/music":
                    case "#music":
                        music m = new music();
                        m.ShowDialog();
                        break;
                    case "!game":
                    case "/game":
                    case "#game":
                        game g = new game();
                        g.ShowDialog();
                        break;
                    case "!notepad":
                    case "/notepad":
                    case "#notepad":
                        notepad n = new notepad();
                        n.ShowDialog();
                        break;
                    case "!download":
                    case "/download":
                    case "#download":
                        download d = new download();
                        d.ShowDialog();
                        break;
                    case "!learn":
                    case "/learn":
                    case "#learn":
                        learn l = new learn();
                        l.ShowDialog();
                        break;
                    case "!love":
                    case "/love":
                    case "#love":
                        love o = new love();
                        o.ShowDialog();
                        break;
                    case "!masin":
                    case "/masin":
                    case "#masin":
                        masin s = new masin();
                        s.ShowDialog();
                        break;
                    case "!timer":
                    case "/timer":
                    case "#timer":
                        time t = new time();
                        t.ShowDialog();
                        break;
                    case "!weight":
                    case "/weight":
                    case "#weight":
                        Standard_weight u = new Standard_weight();
                        u.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("دستور مورد نظر یافت نشد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void وزناستانداردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Standard_weight s = new Standard_weight();
            s.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer Music = new SoundPlayer(Application.StartupPath + @"/mus.wav");
            Music.Stop();
            button6.Enabled = true;
            button7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            SoundPlayer Music = new SoundPlayer(Application.StartupPath + @"/mus.wav");
            Music.PlayLooping();
            button7.Enabled = true;
            button6.Enabled = false;
        }

        private void ریستToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button5.Visible = false;
            hide.Visible = false;
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show
    ("آیا واقعا میخواهید از برنامه خارج شوید؟",
    "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
               
                return;
            }

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void منبعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code with c#"+"\n"+"By javad mohammadi", "Source", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
