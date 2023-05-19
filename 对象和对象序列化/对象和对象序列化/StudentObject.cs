using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace 对象和对象序列化
{
    internal class StudentObject
    {
        //编写对象保存和读取的方法

        public void Write() 
        {
            Student student = new Student();
            //1.创建文件流
            FileStream fileStream = new FileStream("Student.stu", FileMode.Create);
            //2.创建二进制格式化器
            BinaryFormatter binaryFormatter = new BinaryFormatter();//使文件内容变为二进制乱码
            //3.调用序列化方法
            binaryFormatter.Serialize(fileStream, student);
            //4.关闭文件流
            fileStream.Close();
        }
        public void Read() 
        {
           
                FileStream fileStream = new FileStream("Student.stu", FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Student student = (Student)binaryFormatter.Deserialize(fileStream);//调用反序列化方法
                fileStream.Close();
           //显示  
            

        }
    }
}
