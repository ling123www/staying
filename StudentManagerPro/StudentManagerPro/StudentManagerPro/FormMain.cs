using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagerPro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ClosePreForm() //关闭先前的窗体
        {
            //首先先将存在的相同窗体删去
            foreach (Control control in spContainer.Panel2.Controls) //遍历这个容器（spContainer.Panel2）里的所有的控件
            {
                if (control is Form) //如果有窗体
                {
                    Form form = (Form)control;//把这个窗体赋值到form中，为什么要转换，因为Control中没有Close这个方法
                    form.Close();//删去这个窗体
                }
            }
        }
        private void OpenForm(Form form) //窗体打开
        {
            form.TopLevel = false;//将子窗体设置为非顶级控件
            form.WindowState = FormWindowState.Maximized;//让子窗体设置为最大化
            form.FormBorderStyle = FormBorderStyle.None;//去掉边框
            form.Parent = spContainer.Panel2;//将他显示的容器设置为solitContainer1.Panel2这个窗体中
            form.Show();//调用显示
        }

        private void btnAddstudent_Click(object sender, EventArgs e)//按下添加学生这个按钮发生的事
        {
            ClosePreForm();//调用关闭窗体，避免连续点击按钮打开多个窗体
            FrmAddStudent form = new FrmAddStudent();//引用添加学员窗口
            OpenForm(form);//将这个参数传给窗体打开方法并调用
           
        }

        private void btnStudentManager_Click(object sender, EventArgs e)
        {
            ClosePreForm();//初始化
            FrmStudentManager form = new FrmStudentManager();
            OpenForm(form);//设置和打开窗体
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)//按下关闭按钮
        {

            this.Hide();//隐藏页面
            e.Cancel = true;//将关闭页面标签定义为true
            FrmUserLogin frmUserLogin = new FrmUserLogin();//引用登录页面类
            frmUserLogin.ShowDialog();//展示

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏页面
            FrmUserLogin frmUserLogin = new FrmUserLogin();//引用登录页面类
            frmUserLogin.ShowDialog();//展示
        }

        private void 添加学员AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClosePreForm();//调用关闭窗体，避免连续点击按钮打开多个窗体
            FrmAddStudent form = new FrmAddStudent();//引用添加学员窗口
            OpenForm(form);//将这个参数传给窗体打开方法并调用
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏页面
            FrmUserLogin frmUserLogin = new FrmUserLogin();//引用登录页面类
            frmUserLogin.ShowDialog();//展示
        }
    }
}
