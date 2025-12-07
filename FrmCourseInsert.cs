using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbApp
{
    public partial class FrmCourseInsert : Form
    {
        public FrmCourseInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //把用户输入的课程信息存储到数据库
            Course c = new Course();
            c.Cno = tbCno.Text;
            c.Cname = tbCname.Text;
            c.Cpno = tbCpno.Text;
            c.Ccredit = Convert.ToInt32(tbCcredit.Text);
            //调用Course.insertCourse(c)插入数据到数据库
            try
            {
                Course.InsertCourse(c);//插入成功肯定是一条数据
                MessageBox.Show("插入成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
