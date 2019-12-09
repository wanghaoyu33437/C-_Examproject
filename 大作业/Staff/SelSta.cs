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
    public partial class SelSta : Form
    {
        string str;
        public static SelSta f = null;
        public static SelSta GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new SelSta(f1,str);
            }

            return f;
        }
        public SelSta(Form f, string str)
        {
            InitializeComponent();
            this.str = str;
            label4.Text = str;
            ShowInfo();
        }
        public SelSta()
        {
            InitializeComponent();
        }
        public void ShowInfo()
        {
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("员工号");
            comboBox1.Items.Add("职位");
            comboBox1.Items.Add("姓名");
            comboBox1.Items.Add("年龄");
            comboBox1.Items.Add("性别");
            comboBox1.Items.Add("入职时间");
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            DataSet ds = new DataSet();
            if (comboBox1.Text.Equals("All"))
            {
                ds=s._Select("*", "staff");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("员工号"))
            {
                ds=s._Select("*","staff","sta_id",textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("职位"))
            {
                ds = s._Select("*", "staff", "pos_id", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("姓名"))
            {
                ds = s._Select("*", "staff", "sta_name", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("年龄"))
            {
                ds = s._Select("*", "staff", "sta_age", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("性别"))
            {
                ds = s._Select("*", "staff", "sta_sex", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("入职时间"))
            {
                ds = s._Select("*", "staff", "sta_data", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SelSta_Load(object sender, EventArgs e)
        {

        }
    }
}
