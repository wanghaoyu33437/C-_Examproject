using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业 
{
    public partial class SelSp : MetroFramework.Forms.MetroForm
    {
        string str;
        public static SelSp f = null;
        public static SelSp GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new SelSp(f1,str);
            }

            return f;
        }
        public SelSp()
        {
            InitializeComponent();
            
            ShowInfo();
        }
        public SelSp(Form f, string str)
        {
            
            InitializeComponent();
            this.str = str;
            label4.Text = str;
            ShowInfo();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = InpSp.GetForm(this,str);
            f3.Show();
        }
        public void ShowInfo()
        {
            DataSet ds = new DataSet();
           
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            ds = s._Select("good");
            
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("商品号");
            comboBox1.Items.Add("商品类别");
            comboBox1.Items.Add("商品名");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SelSp_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            DataSet ds = new DataSet();
            if (comboBox1.Text.Equals("All"))
            {
                ds = s._Select("*", "good");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("商品号"))
            {
                ds = s._Select("*", "good", "good_num", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("商品类别"))
            {
                ds = s._Select("*", "good", "good_typeid", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("商品名"))
            {
                ds = s._Select("*", "good", "good_name", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
