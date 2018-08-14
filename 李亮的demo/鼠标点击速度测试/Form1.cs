using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鼠标点击速度测试
{
    public partial class Form1 : Form
    {
        int time = 10;
        public Form1()
        {
            InitializeComponent();
            button1.Tag = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Tag=Convert.ToInt32(button1.Tag) + 1;
            this.label1.Text = button1.Tag.ToString();
            this.timer1.Interval = 1000;
            this.timer1.Start();

        }

    
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                this.label2.Text = time.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show(button1.Tag.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Tag = 0;
            this.label1.Text = button1.Tag.ToString();
            time = 10;
            this.label2.Text = time.ToString();
        }
    }
}
