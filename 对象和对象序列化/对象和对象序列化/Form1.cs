using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;//@
using System.Runtime.Serialization.Formatters.Binary;//@
using Microsoft.SqlServer.Server;

namespace 对象和对象序列化
{
    public partial class FormFile : Form
    {
        public FormFile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)//保存文件按下
        {
            Student student = new Student()
            {
                Name = this.txtName.Text.Trim(),
                Age = Convert.ToInt32(this.txtAge.Text.Trim()),
                Birthday = Convert.ToDateTime(this.txtBithday.Text.Trim()),
                Gender = this.txtGender.Text.Trim(),//将txtName等控件文本放入这些属性
            };
            FileStream fileStream = new FileStream("D:\\vs console\\winform\\文件操作\\文件操作\\bin\\Debug\\Student.txt", FileMode.Create);//创建文件流，在指定目录下生成文件
            StreamWriter writer = new StreamWriter(fileStream);//写入器
            writer.WriteLine(student.Name);
            writer.WriteLine(student.Age);
            writer.WriteLine(student.Birthday);
            writer.WriteLine(student.Gender);//写入信息
            writer.Close();//关闭流和写入器
            fileStream.Close();
            
        }

        private void btnRead_Click(object sender, EventArgs e)//读取文件按下
        {
            FileStream fileStream = new FileStream("D:\\vs console\\winform\\文件操作\\文件操作\\bin\\Debug\\Student.txt", FileMode.Open);//打开这个目录的文件
            StreamReader reader = new StreamReader(fileStream);
            Student student = new Student()
            {
                Name = reader.ReadLine(),
                Age = Convert.ToInt32(reader.ReadLine()),
                Birthday = Convert.ToDateTime(reader.ReadLine()),
                Gender = reader.ReadLine(),//将文件的数据读入属性
            };
            reader.Close();
            fileStream.Close();
            
            txtName.Text = student.Name;
            txtAge.Text = Convert.ToString(student.Age);
            txtGender.Text =student.Gender;
            txtBithday.Text = Convert.ToString(student.Birthday);//将读取到的数据显示到各个控件

        }

        private void btnCheak_Click(object sender, EventArgs e)
        {
            string path = "D:\\vs console\\winform\\文件操作\\文件操作\\bin\\Debug\\Student.txt";
            if (Directory.Exists(path))
            {
                MessageBox.Show("创建成功");
            }
            else
            {
                MessageBox.Show("创建失败");
            }
        }

        //利用序列化来保护文件的信息
        private void btnSetSave_Click(object sender, EventArgs e)//使用序列化写入
        {
            Student student = new Student()
            {
                Name = this.txtName.Text.Trim(),
                Age = Convert.ToInt32(this.txtAge.Text.Trim()),
                Birthday = Convert.ToDateTime(this.txtBithday.Text.Trim()),
                Gender = this.txtGender.Text.Trim(),//将txtName等控件文本放入这些属性
            };
            StudentObject studentObject = new StudentObject();
            studentObject.Write();
           

        }

        private void btnSetRead_Click(object sender, EventArgs e)//使用反序列化读出
        {
            Student student = new Student();
            StudentObject studentObject = new StudentObject();
            studentObject.Read();
            txtName.Text = student.Name;
            txtAge.Text = Convert.ToString(student.Age);
            txtGender.Text = student.Gender;
            txtBithday.Text = Convert.ToString(student.Birthday);//将读取到的数据显示到各个控件
        }
    }
}
