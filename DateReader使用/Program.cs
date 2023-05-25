using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DateReader使用
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义连接字符串
            string connstring = "Server=.;DataBase=StudentManagerDB;Uid=sa;Pwd=123456";
            //创建连接对象
            SqlConnection conn = new SqlConnection(connstring);

            //1,执行查询
            string sql = "select StudentID,StudentName,Gender form Students";
            SqlCommand cmd = new SqlCommand(sql, conn); //利用sql语句来查询，sql是sql语句，conn是连接对象
            conn.Open();//打开连接
            SqlDataReader objRader= cmd.ExecuteReader();//执行查询方法，返回DateReader对象
            //2.读取结果
            while (objRader.Read()) //空为false，有数据为true
            {
                Console.WriteLine(objRader["StudenID"].ToString() + "\t" + objRader["StudentName"].ToString() + "\t" +
                    objRader["Gender"].ToString());
            }
            //3.关闭读取器
            objRader.Close();
            //4.关闭连接
            conn.Close();

        }
    }
}
