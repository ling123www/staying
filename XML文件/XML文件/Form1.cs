using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML文件
{
    public partial class FrmReadXML : Form
    {
        public FrmReadXML()
        {
            InitializeComponent();
        }

        private void btnLoadXML_Click(object sender, EventArgs e)//显示版本信息
        {
            //创建XML读取器
            XmlTextReader xmlTextReader = new XmlTextReader("StuScore.xml");//下面那个方法也可用
            string into = string.Empty;//只读的空字符串

            while (xmlTextReader.Read())//读节点，读到就一直为true 
            {
                if (xmlTextReader.Name== "Version") //读到xml的这段
                {
                    into = "版本："+xmlTextReader.GetAttribute("vNo")//获取vNo这个名称的值 
                       + "发布时间：" + xmlTextReader.GetAttribute("pTime");//获取pTime这个标记的值
                    break;//跳出循环
                }
                        
            }
            MessageBox.Show(into);
        }

        private void btnLoad_Click(object sender, EventArgs e)//按下加载xml
        {
            //1.创建XML文档操作对象
            XmlDocument xmlDocument = new XmlDocument();
            //2,加载XML文件到文档对象中
            xmlDocument.Load("StuScore.xml");
            //3.获取XML文档根目录
            XmlNode xmlnode = xmlDocument.DocumentElement;
            //创建对象集合，保存对象
            List<Student> studentsList = new List<Student>();
            //遍历根节点
            foreach (XmlNode xmlNode in xmlnode.ChildNodes) //遍历所有根目录的根节点（自建读写器）
            {
                if (xmlNode.Name == "Student")//如果根节点名称等于我们的xml文件根节点                
                {
                    Student student = new Student();
                    foreach (XmlNode xmlson in xmlNode) //遍历所有的子节点,这是xmlNode里是遍历的子节点
                    {
                        switch (xmlson.Name) //name是获取名称
                        {
                            case "StuName":
                                student.StuName = xmlson.InnerText;
                                break;
                            case "StuAge":
                                student.StuAge = Convert.ToInt32(xmlson.InnerText);
                                break;
                            case "Gander":
                                student.Gander = xmlson.InnerText;
                                break;
                            case "StuClass":
                                student.StuClass = xmlson.InnerText;
                                break;



                        }
                    }
                    studentsList.Add(student);//把遍历的数据加入到集合中
                }
            }
            dgvStu.DataSource = studentsList;//把集合复制给数据容器，显示
        }

    }
}
