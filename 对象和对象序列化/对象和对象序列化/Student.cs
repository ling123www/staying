using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace 对象和对象序列化
{
    [Serializable]//对象可序列化标记 
    internal class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; } 
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
    }   
}
