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
    public partial class FrmStuUpdate : Form
    {
        public FrmStuUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //用户点击了“修改”按钮，把修改后的信息存储到数据库
            string sql = string.Format("update student set sname='{0}',ssex='{1}',sage='{2}',sdept='{3}' where sno='{4}'",
                tbSname.Text, tbSsex.Text, tbSage.Text, tbSdept.Text, tbSno.Text);
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }

                else
                    MessageBox.Show("没有找到对应学号的学生");
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
