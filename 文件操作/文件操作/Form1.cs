using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//引用IO
using System.Reflection;

namespace 文件操作
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

      

        private void btnWriteAll_Click(object sender, EventArgs e)//写入文件
        {
            //写入文件的步骤
            //1.创建文件流
            FileStream fileStream = new FileStream("D:\\myfile.txt",FileMode.Create);//给定路径，设定枚举类型，需要执行什么操作
            //2.创建写入器
            StreamWriter streaWriter = new StreamWriter(fileStream);//引用命名空间，
            //3.以流的方式写入数据
            streaWriter.Write(txtContent.Text.Trim()) ; //检测winform右边构件的字段，将字段写入
            //4.将对象释放
            streaWriter.Close();//关闭写入器
            //5.关闭文件流
            fileStream.Close(); //关闭文件流
        }

        private void btnReadAll_Click(object sender, EventArgs e)//读取文件
        {
            //1.创建文件流
            FileStream fileStream = new FileStream("D:\\myfile.txt", FileMode.Open);//打开文件
            //2.创建读取器
            StreamReader streamReader = new StreamReader(fileStream);
            //3.以流的方式读取数据
            txtContent.Text = streamReader.ReadToEnd() ;//读取全部数据
            //4.关闭读取器
            streamReader.Close();
            //5.关闭文件流
            fileStream.Close();
        }

        private void btnWriteLine_Click(object sender, EventArgs e)//模拟写入日志
        {
            FileStream fileStream = new FileStream("D:\\myfile.txt", FileMode.Append);//枚举方式改为Append，追加一个文件
            StreamWriter streamReader = new StreamWriter(fileStream);//写入器
            streamReader.WriteLine(DateTime.Now.ToString()+"文件操作正常");//写入内容 
            streamReader.Close();
            fileStream.Close(); 

        }

        private void btnDel_Click(object sender, EventArgs e)//删除按钮
        {
            File.Delete(txtFrm.Text);//删除txtFrm这个路径指定的文件里的文本
        }

        private void btnCopy_Click(object sender, EventArgs e)//复制文件
        {
            try {
                if (File.Exists(txtTo.Text.Trim())) //判断txtTo这个控件中有没有相同的文件
                {
                    File.Delete(Text);//如果有，删除这个文件
                }
                File.Copy(txtFrm.Text.Trim(), txtTo.Text.Trim());//将txtFrm的文件复制到txtTo文件中
            }
            catch (ArgumentException)
            {
                MessageBox.Show("请输入文件");
            }
            catch (FileNotFoundException) 
            {
                MessageBox.Show("输入的路径不存在指定文件");
            }

        }

        private void btnMove_Click(object sender, EventArgs e)//移动文件
        {
            if (File.Exists(txtTo.Text.Trim())) //判断移动目的地是否已经有这个文件
            {
                File.Delete(txtTo.Text.Trim());//有则删除
            }
            if (File.Exists(txtFrm.Text.Trim()))//判断是否有这个文件
            {
                File.Move(txtFrm.Text.Trim(), txtTo.Text.Trim());//有则移动
            }
            else 
            {
                MessageBox.Show("文件不存在！");//没有报错
            }

            
        }

        private void btnGetFile_Click(object sender, EventArgs e)//获取目录的所有文件
        {
            string[] files = Directory.GetFiles("D:\\myfile");//获取这个文件目录的所有文件并且保存在files中
            txtContent.Clear();//清除这个控件的所有文本
            foreach (string temp in files) //遍历所有的目录下文件
            {
                txtContent.Text += temp + " ";//获取这个遍历后的文本
            }
        }

        private void btnShowAllFile_Click(object sender, EventArgs e)//显示指定目录   下的所有子目录
        {
            string[] files = Directory.GetDirectories("D:\\myfile");
            txtContent.Clear();//清除
            foreach (string temp in files)
            {
                txtContent.Text += temp + " ";
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)//指定目录下创建新目录
        {
            Directory.CreateDirectory("D:\\myfile\\newfile");
        }

        private void btnDelfile_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("D:\\myfile");//删除这个目录
            directoryInfo.Delete(true);
        }
    }
}
