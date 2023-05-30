using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class DBHelpr
    {
        //链接数据库
        static string dbConnect = "Data Source=.;Initial Catalog=Guanliyuan;Integrated Security=True";
        static SqlConnection conn = null;
        //定义数据库连接方法
        public static void lianjieDB()
        {

            if (conn == null)
            {
                conn = new SqlConnection(dbConnect);
            }

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();

            }
            else if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            else if (conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }

        //增删改
        public static bool ZengShanGai(string sql)
        {
            lianjieDB();

            SqlCommand cmd = new SqlCommand(sql, conn);

            int zsg = cmd.ExecuteNonQuery();
            conn.Close();

            if (zsg > 0)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        //查询
        public static SqlDataReader ChaXun(string sql)
        {
            lianjieDB();

            SqlCommand cmd = new SqlCommand(sql, conn);

            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

        }

        //执行聚合函数
        public static object JvHe(string sql)
        {
            lianjieDB();
            SqlCommand cmd = new SqlCommand(sql, conn); ;

            object obj = cmd.ExecuteScalar();
            conn.Close();

            return obj;
        }

    }
}
