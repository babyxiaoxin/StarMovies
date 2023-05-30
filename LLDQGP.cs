using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LLDQGP : Form
    {
        public LLDQGP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            label1.Text = (int.Parse(label1.Text.Trim()) - 1).ToString();
            if (int.Parse(label1.Text) <= 1)
            {
                label1.Text = 0.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Text = (int.Parse(label1.Text.Trim()) + 1).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {    //当点击当前按钮时，lable值加1，且仅加1，按钮变色，获取按钮当前颜色，再次点击变回原色，且lable减一；
            label3.BackColor = Color.Red;
            label1.Text = (int.Parse(label1.Text.Trim()) + 1).ToString();

        }
    }
}
