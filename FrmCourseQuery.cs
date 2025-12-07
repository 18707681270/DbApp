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
    public partial class FrmCourseQuery : Form
    {
        public FrmCourseQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = Course.SelectCourse(this.textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //用户单击了datagridview1的单元格，参数e会记录你单击的是哪一行、哪一列
            //MessageBox.Show(e.RowIndex.ToString() + "," + e.ColumnIndex.ToString());
            if (e.RowIndex < 0) return;//标题行的编号是-1
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Course c = (Course)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 4)
                {//点击了第e.RowIndex行的删除按钮，删除课程号等于c.cno的课程
                    if (MessageBox.Show("是否删除数据", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == Course.DeleteCourse(c.Cno))
                        MessageBox.Show("删除成功");
                    else MessageBox.Show("没有找到对应课程号的课程");
                }
                else if (e.ColumnIndex == 5)
                {//点击了第e.RowIndex行的修改按钮，那么打开一个窗体修改课程c
                    FrmCourseUpdate frm = new FrmCourseUpdate();
                    //在显示之前，把需要修改的课程信息填写到对话框的文本框
                    frm.tbCno.Text = c.Cno;
                    frm.tbCname.Text = c.Cname;
                    frm.tbCpno.Text = c.Cpno;
                    frm.tbCcredit.Text = c.Ccredit.ToString();
                    frm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
