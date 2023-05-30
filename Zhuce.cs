using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Zhuce : Form
    {
        public Zhuce()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空！", "提示信息：");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("密码不能为空！", "提示信息：");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("手机号不能为空！", "提示信息：");
            }//判断密码是否一致
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("两次密码不一致!请确认！", "提示信息：");

            }//符合以上条件再进行下一步
            else
            {
                string cxsql = String.Format("select phone from Uname where phone = '{0}'", textBox4.Text);

                //调用DB类查询上述sql语句是否存在，HasRows默认为true
                if (DBHelpr.ChaXun(cxsql).HasRows)
                {
                    //已注册，弹出提示信息
                    MessageBox.Show("该手机号已注册，请更换手机号后再试！", "提示信息：");
                }
                else
                {
                    //未注册，向数据表中插入相应的用户名和密码
                    string sql1 = String.Format(("insert Uname(Usname,pwd,phone) values('{0}','{1}','{2}')"), textBox1.Text, textBox2.Text, textBox4.Text);
                    bool com1 = DBHelpr.ZengShanGai(sql1);


                    if (com1 == true)
                    {
                        MessageBox.Show("注册成功！", "提示信息：");
                        this.DialogResult = DialogResult.Retry;
                        this.Close();

                    }
                    else if (com1 == false)
                    {
                        MessageBox.Show("注册失败！");
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Usdenglu usdl = new Usdenglu();
            usdl.Show();
            this.Close();
        }
    }
}


