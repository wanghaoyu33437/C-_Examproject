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
    
    public partial class OutSp : MetroFramework.Forms.MetroForm
    {
        
        public static OutSp f = null;
        public static OutSp GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new OutSp(f1,str);
            }

            return f;
        }
        public OutSp(Form f, string str)
        {
            InitializeComponent();
            label2.Text = str;
            showInfo();
        }
        public OutSp()
        {
            InitializeComponent();
        }
        public void showInfo()
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            ds = s._Select("good");
            ds1 = s._Select("good_id","good");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
            }
            comboBox1.DisplayMember = "shang";
            comboBox1.ValueMember = "id";
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            SOperate s1 = sFact.Update();
            SOperate s2 = sFact.Delete();
            int num = int.Parse(s._Select("good_sum", "good", "good_id", comboBox1.Text).Tables[0].Rows[0][0].ToString().Trim());
            if (num < int.Parse(textBox1.Text))
            {
                MessageBox.Show("数量不足！");
            }
            else if (num == int.Parse(textBox1.Text))
            {
                num = num - int.Parse(textBox1.Text);
                s2._Del("good", "good_id",comboBox1.Text);
            }
            else
            {
                num = num - int.Parse(textBox1.Text);
                s1._Update("good","good_sum", num.ToString(), "good_id",comboBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
