using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DbApp
{
    public class Course
    {
        public string Cno { get; set; }

        public string Cname { get; set; }

        public string Cpno { get; set; }

        public int Ccredit { get; set; }

        //根据输入的课程名查找课程列表
        public static List<Course> SelectCourse(string cname)
        {
            List<Course> list = new List<Course>();
            string sql = "select cno,cname,cpno,ccredit from course where cname like :cname";
            OracleParameter[] para = new OracleParameter[]

            {
                new OracleParameter(":cname",OracleDbType.Varchar2,40)
            };
            para[0].Value = cname + "%";
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    Course c = new Course();
                    c.Cno = odr.GetString(0);
                    c.Cname = odr.GetString(1);
                    if (odr.IsDBNull(2)) c.Cpno = null;
                    else c.Cpno = odr.GetString(2);
                    c.Ccredit = odr.GetInt32(3);
                    list.Add(c);
                }
            }
            finally
            {
                con.Close();
            }

            return list;
        }
        //根据课程号删除课程
        public static int DeleteCourse(string cno)
        {
            int result = 0;//表示影响的行数
            string sql = "delete from course where cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
        new OracleParameter(":cno",OracleDbType.Varchar2,4)
            };
            para[0].Value = cno;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        //把修改后的课程c的信息更新到数据库
        public static int UpdateCourse(Course c)
        {//课程号没有变，其他属性值可能变化
            string sql = "update course set cname=:cname,cpno=:cpno,ccredit=:ccredit where cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":cname",OracleDbType.Varchar2,40),
            new OracleParameter(":cpno",OracleDbType.Varchar2,4),
            new OracleParameter(":ccredit",OracleDbType.Int16),
            new OracleParameter(":cno",OracleDbType.Varchar2,4)
            };
            para[0].Value = c.Cname;
            if (string.IsNullOrEmpty(c.Cpno))
                para[1].Value = DBNull.Value;
            else para[1].Value = c.Cpno;
            para[2].Value = c.Ccredit;
            para[3].Value = c.Cno;
            int result = 0;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int InsertCourse(Course c)
        {
            string sql = "INSERT INTO course (cno, cname, cpno, ccredit) VALUES (:cno, :cname, :cpno, :ccredit)";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cno",OracleDbType.Varchar2,4),
                new OracleParameter(":cname",OracleDbType.Varchar2,40),
                new OracleParameter(":cpno",OracleDbType.Varchar2,4),
                new OracleParameter(":ccredit",OracleDbType.Int16)
            };
            para[0].Value = c.Cno;
            para[1].Value = c.Cname;
            if (string.IsNullOrEmpty(c.Cpno))
                para[2].Value = DBNull.Value;
            else para[2].Value = c.Cpno;
            para[3].Value = c.Ccredit;
            int result = 0;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }

    }
}
