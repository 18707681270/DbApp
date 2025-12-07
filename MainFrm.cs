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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //用户点击了菜单“查询学生”，打开一共“查询学生的窗体”进行学生查询
            FrmStuQuery frm = new FrmStuQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //用户点击了菜单“添加学生”，打开一个添加学生的窗体
            FrmStuInsert frm = new FrmStuInsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开一个查询课程的窗体
            FrmCourseQuery frm = new FrmCourseQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourseInsert frm = new FrmCourseInsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStatistics  frm=new FrmStatistics();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            this.Text = "学生信息管理系统，当前登录的用户名是：" + FrmLogin.loginName;
            if (FrmLogin.loginName == "201215121")
            {
                学生管理ToolStripMenuItem.Visible = false;
            }
            else
            {
                统计信息ToolStripMenuItem.Visible = false;
            }
        }
    }
}
