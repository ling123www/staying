using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagerPro
{
    public partial class FrmStudentManager : Form
    {
       
        public FrmStudentManager()
        {
            InitializeComponent();
        }
       

        //根据班级查询
        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql = "select StudentID,StudentName,Gender,Birthday,ClassName from StudentClass a," +
                        " Students b where a.ClassID=b.CalssID";
            DataTable dataTable = SQLHelper.GetDataTable(sql);//将sql中的数据封装到DataTable中
            dataGridView1.DataSource = dataTable;//传入datagridview控件中
        }
        //根据学号查询
        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
