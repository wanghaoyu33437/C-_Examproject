using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 大作业
{
    interface SOperate
    {
        DataSet _Select(string str);    //查表中的所有字段
        DataSet _Select(string str, string str1);    //查表中的某个字段
        DataSet _Select(string str, string str1, string str2, string str3);    //通过对应数据查表中的某个字段
        void _Update(string table, string field, string value, string colunm, string value2);           //通过某字段修改指定表中另个字段的值
        void _Update(string table, string columAndvalue,string colunm, string value);
        void _Add(string str, string str1);
        void _Add(string str, string str1, string str2, string str3, string str4, string str5, string str6, string str7);
        void _Del(string str, string str1, string str2);  //从表中通过某个字段进行删除
        void _Add(string v1, string v2, string v3);
        void _Add(string v, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8);
    }
    class Select : SOperate
    {
        String constr = "server = 127.0.0.1; port = 3306 ;user = root; password = 123456; database = market";

        public DataSet Add(string str, string str1)
        {
            throw new NotImplementedException();
        }

        public DataSet _Select(string str)
        {
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            try
            {
                string s = "select * from " + str;
                MySqlCommand cmd = new MySqlCommand(s, con);// where date= '" + str + "'", con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw new SyntaxErrorException("Failed to select result route", e);
            }
            finally
            {
                con.Close();
            }
        }
        //同时作为多表联查
        public DataSet _Select(string column, string table)
        {
            string s = "select " + column + " from " + table;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(s, con);// where date= '" + str + "'", con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw new SyntaxErrorException("Failed to select result route", e);
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet _Select(string column, string table, string field ,string value)
        {
            string s = "select " + column + " from " + table + " where " + field + " = '" + value+"'";
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(s, con);// where date= '" + str + "'", con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception e)
            {
                throw new SyntaxErrorException("Failed to select result route", e);
            }
            finally
            {
                con.Close();
            }
        }

        public void _Add(string str, string str1)
        {
            throw new NotImplementedException();
        }

        public void _Add(string str, string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            throw new NotImplementedException();
        }

        public void _Del(string str, string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public void _Update(string str, string str1, string str2, string str3, string str4)
        {
            throw new NotImplementedException();
        }

        public void _Add(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void _Add(string v, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            throw new NotImplementedException();
        }

        public void _Update(string table, string columAndvalue, string colunm, string value)
        {
            throw new NotImplementedException();
        }
    }
    class Update : SOperate
    {
        string strCon = "server = 127.0.0.1; port = 3306 ;user = root; password = 123456; database = market";
        public DataSet _Select(string str)
        {
            throw new NotImplementedException();
        }

        public DataSet _Select(string str, string str1)
        {
            throw new NotImplementedException();
        }

        public DataSet _Select(string str, string str1, string str2, string str3)
        {
            throw new NotImplementedException();
        }

        public void _Add(string str, string str1)
        {
            throw new NotImplementedException();
        }

        public void _Add(string str, string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            throw new NotImplementedException();
        }

        public void _Del(string str, string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public void _Update(string table, string field, string value, string colunm, string value2)
        {

            string MySql = "update " + table + " set " + field+" = "+value+" where "+colunm +" = "+value2;
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = MySql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功");
                con.Close();
            }
            catch (Exception e)
            {
                throw new SyntaxErrorException("Failed to update result route", e);
            }
            finally
            {
                con.Close();
            }
        }
        public void _Update(string table, string columAndvalue, string colunm, string value)
        {
            string MySql = "update " + table + " set " + columAndvalue+ " where " + colunm + " = " + value;
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = MySql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功");
                con.Close();
            }
            catch (Exception e)
            {
                throw new SyntaxErrorException("Failed to update result route", e);
            }
            finally
            {
                con.Close();
            }
        }
        public void _Add(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void _Add(string v, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            throw new NotImplementedException();
        }

   
    }
    class Delete : SOperate
    {
        public DataSet Add(string str, string str1)
        {
            throw new NotImplementedException();
        }

        public DataSet _Select(string str)
        {
            throw new NotImplementedException();
        }

        public DataSet _Select(string str, string str1)
        {
            throw new NotImplementedException();
        }

        public DataSet _Select(string str, string str1, string str2, string str3)
        {
            throw new NotImplementedException();
        }

        public void _Update(string str, string str1, string str2, string str3, string str4)
        {
            throw new NotImplementedException();
        }

        public void _Del(string table, string str1, string str2)
        {
            string strCon = "server = 127.0.0.1; port = 3306 ;user = root; password = 123456; database = market";
            MySqlConnection conn = new MySqlConnection(strCon);
            conn.Open();
            try
            {
                string MySql = "delete from " + table + " where " + str1 + " = '" + str2+"'";
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = MySql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功");
                conn.Close();
            }
            catch (Exception e)
            {
                throw new SyntaxErrorException("Failed to delete result route", e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void _Add(string str, string str1)
        {
            throw new NotImplementedException();
        }

        public void _Add(string str, string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            throw new NotImplementedException();
        }

        public void _Add(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void _Add(string v, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            throw new NotImplementedException();
        }

        public void _Update(string table, string columAndvalue, string colunm, string value)
        {
            throw new NotImplementedException();
        }
    }
    class Add : SOperate
    {
        string strCon = "server = 127.0.0.1; port = 3306 ;user = root; password = 123456; database = market";
        public void _Add(string str, string str1)
        {
            MySqlConnection conn = new MySqlConnection(strCon);
            conn.Open();
            string MySql = "insert into " + str + " values("+str1+")";
            MySqlCommand cmd = new MySqlCommand(MySql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功");
            conn.Close();
        }
        public DataSet _Select(string str)
        {
            throw new NotImplementedException();
        }

        public DataSet _Select(string str, string str1)
        {
            throw new NotImplementedException();
        }

        public DataSet _Select(string str, string str1, string str2, string str3)
        {
            throw new NotImplementedException();
        }

        public void _Del(string str, string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public void _Update(string table, string field, string value, string colunm, string value2)
        {
            throw new NotImplementedException();
        }

        public void _Add(string str, string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            MySqlConnection conn = new MySqlConnection(strCon);
            conn.Open();
            string MySql = "insert into " + str + " values('" + str1 + "','" + str2 + "','" + str3 + "','" + str4 + "'" +
                ",'" + str5 + "','" + str6 + "','" + str7 + "')";
            MySqlCommand cmd = new MySqlCommand(MySql,conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功");
            conn.Close();
        }

        public void _Add(string str, string str1, string str2)
        {
            MySqlConnection conn = new MySqlConnection(strCon);
            conn.Open();
            string MySql = "insert into " + str + " values('" + str1 + "','" + str2 +  "')";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = MySql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功");
            conn.Close();
        }

        public void _Add(string str, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8)
        {
            MySqlConnection conn = new MySqlConnection(strCon);
            conn.Open();
            string MySql = "insert into " + str + " values('" + str1 + "','" + str2 + "','" + str3 + "','" + str4 + "'" +
                ",'" + str5 + "','" + str6 + "','" + str7 + "','" + str8 + "')";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = MySql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功");
            conn.Close();
        }

        public void _Update(string table, string columAndvalue, string colunm, string value)
        {
            throw new NotImplementedException();
        }
    }
}
