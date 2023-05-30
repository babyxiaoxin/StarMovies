using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GUANLI : Form
    {
        public GUANLI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Down down = new Down();
            down.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GLxiugai glxg = new GLxiugai();
            glxg.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Glxinzengdy xz = new Glxinzengdy();
            xz.Show();
            this.Close();
        }
    }
}
