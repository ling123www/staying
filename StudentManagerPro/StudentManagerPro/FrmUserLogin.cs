﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace StudentManagerPro
{
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取用户输入信息
            string uName = txtUseName.Text.Trim();//获取登录账号
            string uKey = txtKey.Text.Trim();//获取密码
            //判断是否为空
            if (string.IsNullOrEmpty(uName))//判断账号是否为空 
            {
                MessageBox.Show("请输入账号！","登录错误",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtUseName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(uKey))//判断密码 
            {
                MessageBox.Show("请输入密码！", "登录错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtKey.Focus();
                return;
            }
            //与数据库通讯，检查输入是否和数据库一致
            {
                //1.建立连接
                /*string connString ="Server=.;database=StudentManageDB;Integrated Security=true";window身份验证*/
                string connString = "Server=.;database=StudentManageDB;uid=sa;pwd=123456;";//SQLServer身份验证
                SqlConnection connection = new SqlConnection(connString);//连接字符串，就是一把钥匙
                //2.写查询语句
                string sql = "select count(1) from Admins where LoignID='"+uName+"'and LoignKey='"+uKey+"'";//查询语句，用字符串表示
                //3.创建Command对象
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                //  sqlCommand.CommandType = CommandType.StoredProcedure;//表示存储过程
                //4.打开连接 
                connection.Open();
                //5.执行命令
                object o = sqlCommand.ExecuteScalar();//查询第一行第一列的值，忽略其他的，然后返回object类参数
                //6.关闭连接    
                connection.Close();
                //根据返回结果进行不同的提示

                if (o == null || o == DBNull.Value || ((int)o) == 0)//结果不存在 
                {
                    MessageBox.Show("输入密码或者账号错误！", "登录错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtKey.Focus();
                    return;
                }
                else 
                {
                    int count = (int)o;
                    MessageBox.Show("登录成功", "成功页面", MessageBoxButtons.OKCancel);
                    return;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏页面
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            frmUserLogin.Close();
        }
    }
}
