using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业.Staff
{
    public partial class UpdSta : Form
    {
        string str;
        string id = null;
        public static UpdSta f = null;
        public static UpdSta GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new UpdSta(f1,str);
            }

            return f;
        }
        public UpdSta(Form f, string str)
        {
            InitializeComponent();
            this.str=str;
            label4.Text = str;
        }
        public UpdSta()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            id = textBox1.Text;
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            DataSet d = s._Select("*", "staff", "sta_id", textBox1.Text);
            if (d.Tables[0].Rows.Count == 0 && d.Tables.Count == 1)//判断是否有数据
            {
                MessageBox.Show("该职工号不存在");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id == textBox1.Text)
            {
                SFact sFact = new SFact();
                SOperate s = sFact.Delete();
                s._Del("staff", "sta_id", textBox1.Text);
                SOperate s1 = sFact.Add();
                s1._Add("staff", textBox1.Text, textBox2.Text, textBox3.Text,
                    textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            }
            else
            {
                MessageBox.Show("会员号不可更改");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SFact sFact = new SFact();
            SOperate s = sFact.Delete();
            s._Del("staff", "sta_id", textBox1.Text);
        }
    }
}
