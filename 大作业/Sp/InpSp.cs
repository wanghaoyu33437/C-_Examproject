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
    public partial class InpSp : MetroFramework.Forms.MetroForm
    {
        string str;
        public static InpSp f = null;
        public static InpSp GetForm(Form f1,string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new InpSp(f1,str);
            }
            
            return f;
        }
        public InpSp()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            ds = s._Select("goodType_name", "goodtype");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
            }
            comboBox1.DisplayMember = "shang";
            comboBox1.ValueMember = "id";

        }
        public InpSp(Form f, string str)
        {
            InitializeComponent();
            this.str = str;
            label14.Text = str;
            DataSet ds = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            ds=s._Select("goodType_name","goodtype");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
            }
            comboBox1.DisplayMember = "shang";
            comboBox1.ValueMember = "id";

        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f = SelSp.GetForm(this,str);
            this.Hide();
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpDao s = new SpDao();
            //MessageBox.Show((comboBox1.SelectedIndex + 1).ToString());
            s.insert((comboBox1.SelectedIndex+1).ToString(), textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,
                textBox7.Text,textBox8.Text,textBox9.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
