using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GLxiugai : Form
    {
        public GLxiugai()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUANLI gl = new GUANLI();
            gl.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strPicPath = "";  // 存储路径
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Filter = "图片文件|*.bmp;*.jpg;*.jpeg;*.png";
            openPic.FilterIndex = 1;
            openPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//获取桌面文件夹路径为初始地址                                    
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择的文件，并判断文件大小不能超过20K，fileInfo.Length是以字节为单位的 
                FileInfo fileInfo = new FileInfo(openPic.FileName);
                if (fileInfo.Length > 20480000000)
                {
                    MessageBox.Show("上传的图片不能大于指定的");
                }
                else
                {
                    strPicPath = openPic.FileName;
                    pictureBox1.BackgroundImage = Image.FromFile(strPicPath); // picReceiptLogo是存储图片的路径

                }
            }
        }
    }
}
