using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DbApp
{
    public partial class FrmStuQuery : Form
    {
        public FrmStuQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击了“查询”按钮，执行select语句，在dataGridView中显示结果
            //string sql = "select sno,sname,ssex,sage,sdept from student where sname like '"+this.textBox1.Text+"%";
            string sql = string.Format("select sno,sname,ssex,sage,sdept from student where sname like '{0}%'", textBox1.Text);

            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    dataGridView1.DataSource = bs;

                }
                else dataGridView1.DataSource = null;
                con.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //用户点击了删除按钮，获取选中行的学号，从数据库删除该学号的学生
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (MessageBox.Show("是否删除数据","请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string sno = row.Cells[0].Value.ToString();
            string sql = string.Format("delete from student where sno={0}",sno);
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("删除成功");
                    dataGridView1.Rows.Remove(row);
                }
                   
                else
                    MessageBox.Show("没有找到对应学号的学生");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                con.Close(); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //用户双击了DataGridView的单元格内容，打开修改窗体，修改选中的学生信息
            if (dataGridView1.SelectedRows.Count == 0) return;
            FrmStuUpdate frm = new FrmStuUpdate();
            //把选中的行的内容依次填写到窗体的文本框
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            frm.tbSno.Text = row.Cells[0].Value.ToString();
            frm.tbSname.Text = row.Cells[1].Value.ToString();
            frm.tbSsex.Text = row.Cells[2].Value.ToString();
            frm.tbSage.Text = row.Cells[3].Value.ToString();
            frm.tbSdept.Text = row.Cells[4].Value.ToString();

            frm.ShowDialog(this);
        }
    }
}
