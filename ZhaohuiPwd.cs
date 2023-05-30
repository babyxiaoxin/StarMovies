using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ZhaohuiPwd : Form
    {
        public ZhaohuiPwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //连接数据库
            string sql = "Data Source=.;Initial Catalog=Guanliyuan;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sql);
            //打开数据库
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                String ssq = string.Format("select Usname,pwd,phone from Uname where phone='{0}'", textBox1.Text);//SQL语句实现表数据的读取
                SqlCommand sqlCommand = new SqlCommand(ssq, conn);
                SqlDataReader redd = sqlCommand.ExecuteReader();
                //判断
                if (redd.Read())
                {
                    string sqlus = redd.GetString(0);
                    string sqlpwd = redd.GetString(1);
                    DialogResult ad = MessageBox.Show("账号是:" + sqlus + "\n密码是:" + sqlpwd, "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (ad == DialogResult.OK)
                    {

                        Usdenglu ud = new Usdenglu();
                        ud.Show();
                        this.Close();
                    }

                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入手机号！,登录提示！");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("手机号不存在，是否注册？", "登录失败", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)//打开注册界面
                    {
                        /*跳转注册界面*/
                        Zhuce zc = new Zhuce();
                        zc.Show();
                        this.Close();

                    }

                }
                /*关闭数据库*/
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usdenglu ud = new Usdenglu();
            ud.Show();
            this.Close();
        }
    }
}
