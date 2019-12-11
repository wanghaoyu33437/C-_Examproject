using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业
{
    class SpDao 
    {
        string strCon = "server = 127.0.0.1; port = 3306 ;user = root; password = 123456; database = market";
       /* public void select(DataGridView dataGridView)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from sp", con);// where date= '" + str + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }*/
        /*
        public void select_cate_good(ComboBox comboBox)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select cate_name from cate_good ", con);// where date= '" + str + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter();
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
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select com_name from sp ", con);// where date= '" + str + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter();
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
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select cate_id from cate_good where cate_name= '" + str + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds.Tables[0].Rows[0][0].ToString().Trim();
        }
        public string select_com_num(string str)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select com_num from sp where com_id= '" + str + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds.Tables[0].Rows[0][0].ToString().Trim();
        }
        public void insert(string str1,string str2,string str3,string str4,string str5,string str6,
                            string str7,string str8,string str9,string str10)
        {
            MySqlConnection conn = new MySqlConnection(strCon);
            conn.Open();
            string str11;
            //str11 = select_cate_id(str2);
            string MySql = "insert into good(good_typeId,good_num,good_name,good_sum,good_insale,good_outsale,good_vipsale,good_start,good_end,good_producter) values('" + str1 + "','"+ str2 +"','" + str3 + "','" + str4 + "'" +
                ",'" + str5 + "','" + str6 + "','" + str7 + "','" + str8 + "','" + str9 + "','" + str10 + "')";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = MySql;
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
                MySqlConnection conn = new MySqlConnection(strCon);
                num = num - com_num;
                conn.Open();
                string MySql = "update sp set com_num ='" + num.ToString() + "'where com_id='" + com_name + "'";
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = MySql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功");
                conn.Close();
            }
            else if(num==com_num)
            {
                MySqlConnection conn = new MySqlConnection(strCon);
                num = num - com_num;
                conn.Open();
                string MySql = "delete from sp where com_name='" + com_name + "'";
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = MySql;
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
