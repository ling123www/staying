using System;
using System.Collections.Generic;
using System.Data.SqlClient;//@
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;//@

namespace StudentManagerPro
{
    internal class SQLHelper
    {
        private readonly string  connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;//通过修改配置文件来实现调用 
        public object ExecuteScalar(string sql, params SqlParameter[] paraArray)
        {

            //与数据库通讯，检查输入是否和数据库一致       
                object obj = null;
                //1.建立连接
                using (SqlConnection connection = new SqlConnection(connString)) 
                {
                    
                    //3.创建Command对象
                    SqlCommand sqlCommand = new SqlCommand(sql, connection);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddRange(paraArray);
                    //4.打开连接 
                    connection.Open();
                    //5.执行命令
                     obj = sqlCommand.ExecuteScalar();//查询第一行第一列的值，忽略其他的，然后返回object类参数
                                                            //6.关闭连接    
                    //connection.Close();
                }
                //根据返回结果进行不同的提示
                return obj;         
        }
    }
}
