using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业.Sql
{
    class VipDao
    {
        string strCon = "Data Source=(local);database=market;uid=sa;pwd=Zhang980430;";
        public void insert(string str1, string str2, string str3, string str4, string str5, string str6,
                         string str7)
        {
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = "insert into vip values('" + str1 + "','" + str2 + "','" + str3 + "','" + str4 + "'" +
                ",'" + str5 + "','" + str6 + "','" + str7 + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("成功");
            conn.Close();
        }
        public DataSet select_id(string str)
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from vip where vip_id= '" + str + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            object o = cmd.ExecuteNonQuery();
            da.Fill(ds);
            if (o == null)
            {
                con.Close();
                return null;
            }
            else
            {
                return ds;
            }
        }
    }
}
