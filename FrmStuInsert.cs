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
    public partial class FrmStuInsert : Form
    {
        public FrmStuInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击了“添加学生”按钮，把输入的学生信息存储到数据库
            string sql = string.Format("insert into student(sno,sname,ssex,sage,sdept)values('{0}','{1}','{2}','{3}','{4}')",
                tbSno.Text,tbSname.Text,tbSsex.Text,tbSage.Text,tbSdept.Text);
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("插入成功");
                   // this.Close();
                }
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
    }
}
