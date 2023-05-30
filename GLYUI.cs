using System;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class GLYUI : Form
    {
        public GLYUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Down down = new Down();
            down.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("需要输入账号和密码", "提示");
            }
            else
            {
                String ssq = string.Format("select id,pwd from Denglu where id='" + textBox1.Text + "'and pwd='" + textBox2.Text + "'");//SQL语句实现表数据的读取

                //判断
                if (DBHelpr.ChaXun(ssq).HasRows)
                {
                    MessageBox.Show("登录成功!", "登录提示");
                    GUANLI gUANLI = new GUANLI();
                    gUANLI.Show();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("请检查账号或密码是否正确！！！", "登录提示！");
                }

            }

        }
    }
}
