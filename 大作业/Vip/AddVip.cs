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

        }
        public AddVip()
        {
            InitializeComponent();
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
            SOperate s = sFact.Add();
            s._Add("vip",textBox1.Text, textBox2.Text, textBox3.Text,
                textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
