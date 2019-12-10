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
    public partial class AddVip : Form
    {
        string str;
        public static AddVip f = null;
        public static AddVip GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new AddVip(f1,str);
            }

            return f;
        }
        public AddVip(Form f, string str)
        {

            InitializeComponent();
            this.str = str;
            label3.Text = str;
            string chars = "0123456789";

            Random randrom = new Random((int)DateTime.Now.Ticks);

            string str1 = "";
            for (int i = 0; i < 10; i++)
            {
                str += chars[randrom.Next(chars.Length)];
            }
            textBox1.Text = str1;

        }
        public AddVip()
        {
            InitializeComponent();
            string chars = "0123456789";

            Random randrom = new Random((int)DateTime.Now.Ticks);

            string str1 = "";
            for (int i = 0; i < 10; i++)
            {
                str1 += chars[randrom.Next(chars.Length)];
            }
            textBox1.Text = str1;
        }

        private void AddVip_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SFact sFact = new SFact();
            SOperate s1 = sFact.Select();

            if (s1._Select("*", "vip", "vip_num", textBox1.Text).Tables[0].Rows.Count == 0)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox6.Text != "" &&
                textBox7.Text != "")
                {
                    SOperate s = sFact.Add();
                    s._Add("vip(vip_num,vip_name,vip_sex,vip_age,vip_money,vip_pwd,vip_phone)", "'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +
                        textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "' ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
                else
                    MessageBox.Show("存在输入信息为空。！");
            }
            else
                MessageBox.Show("该员工账号已存在！");
        }

        private void label3_Click(object sender, EventArgs e)
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
