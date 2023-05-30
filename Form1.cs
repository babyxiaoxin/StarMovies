using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i <= 100; i++)
            {
                //进度条的实现
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

            //窗体之间的切换
            Down form1 = new Down();
            form1.Show();
            this.Hide();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //窗体之间的切换
            Down form1 = new Down();
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


