using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Usdenglu : Form
    {
        public Usdenglu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {  //跳转user用户功能界面
            User user = new User();
            user.Show();
            this.Close();
        }

        private void Usdenglu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String ssq = string.Format("select Usname,pwd from Uname where Usname='" + textBox1.Text + "'and pwd='" + textBox2.Text + "'");//SQL语句实现表数据的读取

            //判断
            if (DBHelpr.ChaXun(ssq).HasRows)
            {
                MessageBox.Show("登录成功!", "登录提示");
                Dengluchengg deng = new Dengluchengg();
                deng.Show();
                this.Close();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("请输入账号！", "登录提示！");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("请输入密码！", "登录提示！");
            }
            else
            {
                DialogResult dr = MessageBox.Show("密码错误是否找回密码？", "登录失败", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)//打开找回密码界面
                {
                    ZhaohuiPwd zpd = new ZhaohuiPwd();
                    zpd.Show();
                    this.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zhuce zhuce = new Zhuce();
            zhuce.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ZhaohuiPwd zhpwd = new ZhaohuiPwd();
            zhpwd.Show();
            this.Close();
        }
    }
}
