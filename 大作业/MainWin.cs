using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 大作业.Staff;
//using 大作业.Staff;

namespace 大作业
{
    public partial class MainWin : MetroFramework.Forms.MetroForm
    {
        Form f;
        string str;
        public static MainWin f1 = null;
        public static MainWin GetForm(Form form, string str,int flag)
        {
            if (f1 == null || f1.IsDisposed)
            {
                f1 = new MainWin(form, str,flag);
            }

            return f1;
        }
        public MainWin()
        {
            InitializeComponent();
           
        }
        public MainWin(Form f,string str,int flag)
        {
            if (flag == 1)// 管理员登录
                InitializeComponent();
            else //员工登录
                InitializeComponent1();
            this.f = f;
            this.str = str;
            label4.Text = str;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Close(object sender, FormClosingEventArgs e)
        {
            f.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form form = Login.GetForm();
            form.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = AddVip.GetForm(this, str);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = SelVip.GetForm(this, str);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = UpdVip.GetForm(this, str);
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form f3 = InpSp.GetForm(this, str);

            f3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f5 = OutSp.GetForm(this, str);
            f5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f4 = SelSp.GetForm(this, str);
            f4.Show();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Form f6 = SelSp.GetForm(this, str);
            f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = AddSta.GetForm(this, str);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = UpdSta.GetForm(this, str);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = SelSta.GetForm(this, str);
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Move_2(object sender, MouseEventArgs e)
        {
           
        }
        
        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }
    }
}
