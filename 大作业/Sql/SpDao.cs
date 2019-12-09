using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业
{
    class SpDao 
    {
        string strCon = "Data Source=(local);database=market;uid=sa;pwd=Zhang980430;";
       /* public void select(DataGridView dataGridView)
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from sp", con);// where date= '" + str + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }*/
        /*
        public void select_cate_good(ComboBox comboBox)
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select cate_name from cate_good ", con);// where date= '" + str + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
            }
            comboBox.DisplayMember = "shang";
            comboBox.ValueMember = "id";
            con.Close();
        }
        */
        public void select_com_name(ComboBox comboBox)
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select com_name from sp ", con);// where date= '" + str + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
            }
            comboBox.DisplayMember = "shang";
            comboBox.ValueMember = "id";
            con.Close();
        }
        public string select_cate_id(string str)
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select cate_id from cate_good where cate_name= '" + str + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds.Tables[0].Rows[0][0].ToString().Trim();
        }
        public string select_com_num(string str)
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select com_num from sp where com_id= '" + str + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds.Tables[0].Rows[0][0].ToString().Trim();
        }
        public void insert(string str1,string str2,string str3,string str4,string str5,string str6,
                            string str7,string str8,string str9,string str10)
        {
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string str11;
            str11 = select_cate_id(str2);
            string sql = "insert into sp values('" + str1 + "','"+ str11 +"','" + str3 + "','" + str4 + "'" +
                ",'" + str5 + "','" + str6 + "','" + str7 + "','" + str8 + "','" + str9 + "','" + str10 + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("成功");
            conn.Close();
        }
        public void update(int com_num,string com_name)
        {
            int num;
            num = int.Parse(select_com_num(com_name));
            if (num > com_num)
            {
                SqlConnection conn = new SqlConnection(strCon);
                num = num - com_num;
                conn.Open();
                string sql = "update sp set com_num ='" + num.ToString() + "'where com_id='" + com_name + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功");
                conn.Close();
            }
            else if(num==com_num)
            {
                SqlConnection conn = new SqlConnection(strCon);
                num = num - com_num;
                conn.Open();
                string sql = "delete from sp where com_name='" + com_name + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功");
                conn.Close();
            }
            else
            {
                MessageBox.Show("库存不足");
            }
        }
   

        public void Select()
        {
            throw new NotImplementedException();
        }
    }
}
