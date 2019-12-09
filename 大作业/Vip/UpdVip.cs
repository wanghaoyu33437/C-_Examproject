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
            id = textBox1.Text;
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            DataSet d = s._Select("*","vip","vip_id",textBox1.Text);
            if (d.Tables[0].Rows.Count==0&&d.Tables.Count==1)//判断是否有数据
            {
                MessageBox.Show("该会员号不存在");
            }
            else
            {
                textBox2.Text = d.Tables[0].Rows[0][1].ToString();
                textBox3.Text = d.Tables[0].Rows[0][2].ToString();
                textBox4.Text = d.Tables[0].Rows[0][3].ToString();
                textBox5.Text = d.Tables[0].Rows[0][4].ToString();
                textBox6.Text = d.Tables[0].Rows[0][5].ToString();
                textBox7.Text = d.Tables[0].Rows[0][6].ToString();
            }
            
        }

        private void UpdVip_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id == textBox1.Text)
            {
                SFact sFact = new SFact();
                SOperate s = sFact.Delete();
                s._Del("vip", "vip_id", textBox1.Text);
                SOperate s1 = sFact.Add();
                s1._Add("vip", textBox1.Text, textBox2.Text, textBox3.Text,
                    textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            }
            else {
                MessageBox.Show("会员号不可更改");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SFact sFact = new SFact();
            SOperate s = sFact.Delete();
            s._Del("vip", "vip_id", textBox1.Text);
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
    }
}
