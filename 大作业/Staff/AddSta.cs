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
    public partial class AddSta : Form
    {
        string str;
        public static AddSta f = null;
        public static AddSta GetForm(Form f1,string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new AddSta(f1,str);
            }

            return f;
        }
        public AddSta(Form f, string str)
        {
            
            InitializeComponent();
            this.str = str;
            label4.Text = str;
            ShowInfo();
        }
        public AddSta()
        {
            InitializeComponent();
        }
        public void ShowInfo()
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            ds = s._Select("id,sta_name,sta_age,sta_sex,pos_name,sta_startime","staff,position where staff.pos_id= position.pos_id "); //查询全部工人信息
            ds1 = s._Select("pos_id", "position");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds1.Tables[0].Rows[i][0].ToString().Trim());
            }
            comboBox1.DisplayMember = "shang";
            comboBox1.ValueMember = "id";
        }
        private void AddSta_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SFact sFact = new SFact();
            SOperate s = sFact.Add();
            s._Add("position",textBox9.Text,textBox8.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SFact s = new SFact();
            SOperate select = s.Select();
            ds = select._Select("position");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SFact sFact = new SFact();
            SOperate s = sFact.Add();
            s._Add("staff(sta_name,sta_pwd,sta_num,sta_sex,sta_age,pos_id,sta_startime)", textBox2.Text, textBox7.Text, textBox1.Text, textBox5.Text, textBox3.Text, comboBox1.Text, textBox6.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            ds = s._Select("id,sta_num as 账号,sta_name as 姓名,sta_age as 年龄,sta_sex as  性别,pos_name as 职位,sta_startime as 入职时间", "staff,position where staff.pos_id= position.pos_id "); //查询全部工人信息

            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
