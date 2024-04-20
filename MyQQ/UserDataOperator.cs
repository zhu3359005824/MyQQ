using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyQQ
{
    class UserDataOperator
    {
        //创建数据库连接字符串
      private static  string connectionString = "server=127.0.0.1;port=3306;user=root;password=admin;database=myqq";

        //创建数据库连接对象
        public static  MySqlConnection connection = new MySqlConnection(connectionString);

        //命令
        public static MySqlCommand command = null;

        //保存数据库读取的信息
        public static MySqlDataReader SqlResult=null;

        //读取Sql存放账户密码
        public Dictionary<int ,string> userMessage = null;

        //保存记住密码和账号
        public Dictionary<int ,string> savedUserMessage = new Dictionary<int, string>();
        //使用记住密码
        public bool IsRemember=false;

        //使用自动登录 ------------废弃
      //public bool IsAutoLogin=false;
        //使用记住密码的账户
        public Dictionary<int, string> RememberUser = new Dictionary<int, string>();


        //首次登陆,获取数据库中账号信息
        public void LoadUserMessage()
        {
            string search = "select ID,Password from myqq_user ";
           
            connection.Open();

            command = new MySqlCommand(search, connection);

            SqlResult = command.ExecuteReader();

           userMessage = new Dictionary<int ,string>();

            //将数据库中的账号信息保存到 userMessage字典中
            while(SqlResult.Read())
            {
                userMessage.Add(Convert.ToInt32( SqlResult[0]), SqlResult[1].ToString());
            }

            connection.Close();

        }

        //注册账户
        public int InsertUserMessage(string sql)
        {
            connection.Open();
           
            command = new MySqlCommand( sql,connection);

            int result=    command.ExecuteNonQuery();
            connection.Close();
            return result;
        }


        //修改用户密码
        public void UpdataUserPassword(int ID,string Password)
        {
            string sql = $"Updata myqq_user set Password={Password} where ID={ID}"; 
            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //修改账户状态
        public void SetRememberStatus(int ID)
        {
            string sql = $"UPDATE myqq_user set Remember='y' where ID={ID} ";
            connection.Open();
            command= new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
       
 

        //获取记住密码的ID
        public List<int> GetRememberUserIds()
        {
            var rememberUserIds = new List<int>();
            string sql = "SELECT ID FROM myqq_user WHERE Remember = 'y'";

            connection.Open();
            using (var command = new MySqlCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rememberUserIds.Add(reader.GetInt32(0)); // 假设ID是整型
                    }
                }
            }
            connection.Close();
            return rememberUserIds;
        }

        

        // 根据ID获取用户的账户信息
        public void GetUserInfoById(List<int> rememberUserIds)
        {
            int userId=-1 ;
            foreach (var item in rememberUserIds)
            {
                userId = item;
                break;
            }

            string sql = $"SELECT ID, Password FROM myqq_user WHERE ID = {userId}";

            connection.Open();
            using (var command = new MySqlCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                       IsRemember = true;
                      
                       RememberUser.Add(reader.GetInt32(0), reader.GetString(1)); // 假设ID是第一个字段，Password是第二个字段
                    }
                }
            }
            connection.Close();

            
        }

    }
}
