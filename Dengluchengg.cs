using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dengluchengg : Form
    {
        public Dengluchengg()
        {
            InitializeComponent();
        }

        private void Dengluchengg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LiuLang manager = new LiuLang();
            manager.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            XingQiu xingQiu = new XingQiu();
            xingQiu.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usdenglu usdenglu = new Usdenglu();
            usdenglu.Show();
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {


        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // 加载图片
            pictureBox1.Image = Image.FromFile("image.png");

            // 将PictureBox控件添加到窗体中
            this.Controls.Add(pictureBox1);

            // 调整PictureBox控件的大小
            pictureBox1.Size = new Size(100, 80);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // 加载图片
            pictureBox1.Image = Image.FromFile("HLW.png");

            // 将PictureBox控件添加到窗体中
            this.Controls.Add(pictureBox1);

            // 调整PictureBox控件的大小
            pictureBox1.Size = new Size(200, 300);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XiaoFuRen xiaoFuRen = new XiaoFuRen();
            XiaoFuRen.show();
            this.Close();
        }
    }
}
