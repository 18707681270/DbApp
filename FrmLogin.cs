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
    public partial class FrmLogin : Form
    {
        public static string loginName = null;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //判断用户名和密码是否正确，如果登录成功，设置登录框的DialogResult为DialogResult.OK,
            //否则显示“用户名或密码错误”
            string username = tbUsername.Text;
            string pwd = tbPwd.Text;
            string sql = "select sno,sname from student where sno=:sno and pwd =:pwd";
            OracleParameter[] para =new OracleParameter[]
            {
                new OracleParameter(":sno",OracleDbType.Varchar2,9),
                new OracleParameter(":pwd",OracleDbType.Varchar2,20)
            };
            para[0].Value = username;
            para[1].Value = pwd;    
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    loginName = odr.GetString(0);
                    this.DialogResult = DialogResult.OK;

                }
                else MessageBox.Show("用户名或密码错误");
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
    }
}
