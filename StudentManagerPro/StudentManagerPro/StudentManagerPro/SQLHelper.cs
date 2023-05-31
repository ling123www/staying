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
using System.Data;//@

namespace StudentManagerPro
{
    internal class SQLHelper
    {
        private static readonly string  connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;//通过修改配置文件来实现调用 
        public object ExecuteScalar(string sql, params SqlParameter[] paraArray)//接收数据
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
        public static DataTable GetDataTable(string sql,params SqlParameter[] sqlParameters) //填充数据
        {
            DataTable dataTable = new DataTable();
            //1.建立连接
            using (SqlConnection connection = new SqlConnection(connString))
            {

                //3.创建Command对象
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                if (sqlParameters!=null) 
                {
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;

                sqlDataAdapter.Fill(dataTable);
            }
            //根据返回结果进行不同的提示
            return dataTable;
        }
    }
}
