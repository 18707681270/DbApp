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
    public partial class FrmCourseUpdate : Form
    {
        public FrmCourseUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //把修改后的课程信息存储到数据库
            Course c = new Course();
            c.Cno = this.tbCno.Text;
            c.Cname = tbCname.Text;
            c.Cpno = tbCpno.Text;
            c.Ccredit = Convert.ToInt32(tbCcredit.Text);
            //调用course类的函数，把修改后的课程c的信息更新到数据库；
            try
            {
                if (1 == Course.UpdateCourse(c))
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else MessageBox.Show("没有找到对应课程号的课程");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
