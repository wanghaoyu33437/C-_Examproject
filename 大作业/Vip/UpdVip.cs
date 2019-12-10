using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 大作业.Sql;

namespace 大作业
{
    public partial class UpdVip : Form
    {
        string id=null;
        string num = null;
        string str;
        public static UpdVip  f = null;
        public static UpdVip GetForm(Form f1, string str)
        {
            if (f == null||f.IsDisposed)
            {
                f = new UpdVip(f1,str);
            }

            return f;
        }
        public UpdVip(Form f, string str)
        {

            InitializeComponent();
            this.str = str;
            label1.Text = str;

        }
        public UpdVip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = textBox1.Text;
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            DataSet d = s._Select("*","vip","vip_num",textBox1.Text);
            if (d.Tables[0].Rows.Count==0&&d.Tables.Count==1)//判断是否有数据
            {
                MessageBox.Show("该会员号不存在");
                ClearInfo();
            }
            else
            {
                id = d.Tables[0].Rows[0][0].ToString();
                textBox2.Text = d.Tables[0].Rows[0][2].ToString();
                textBox3.Text = d.Tables[0].Rows[0][3].ToString();
                textBox4.Text = d.Tables[0].Rows[0][4].ToString();
                textBox5.Text = d.Tables[0].Rows[0][5].ToString();
                textBox6.Text = d.Tables[0].Rows[0][6].ToString();
                textBox7.Text = d.Tables[0].Rows[0][7].ToString();
            }
            
        }

        private void UpdVip_Load(object sender, EventArgs e)
        {

        }
        private void ClearInfo()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (num == textBox1.Text)
            {
                SFact sFact = new SFact();
                string name = textBox2.Text;
                string sex = textBox3.Text;
                string age = textBox4.Text;
                string money = textBox5.Text;
                string pwd = textBox6.Text;
                string phone = textBox7.Text;
                SOperate s = sFact.Update();
                s._Update("vip", "vip_name = '" + name + "',vip_sex= '" + sex + "',vip_age=" + age + ",vip_money= '" + money + "',vip_pwd='" + pwd + "',vip_phone='" + phone+ "'", "id", id);

            }
            else {
                MessageBox.Show("会员号不可更改");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SFact sFact = new SFact();
            SOperate s = sFact.Delete();
            s._Del("vip", "id",id);
            ClearInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdVip_Closed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
