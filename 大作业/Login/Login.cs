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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public static Login f1 = null;
        public static Login GetForm()
        {
            if (f1 == null || f1.IsDisposed)
            {
                f1 = new Login();
            }

            return f1;
        }
        public Login()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                Login_stra l = new Login_stra();
               // 返回的s是该登录用户的密码
                string s = l.Login(1, textBox3.Text);
                if (textBox4.Text == s)
                {
                    DataSet ds = new DataSet();
                    SFact sFact = new SFact();
                    SOperate s1 = sFact.Select();
                    ds=s1._Select("sta_name","staff","sta_num",textBox3.Text);
                    Form f = new MainWin(this, ds.Tables[0].Rows[0][0].ToString().Trim(),0);
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("用户名不存在或密码错误...");
                }
            }
            else if (tabControl1.SelectedTab.Name == "tabPage1")//vip
            {
                Login_stra l = new Login_stra();
                string s = l.Login(0, textBox1.Text);
                if (textBox2.Text == s)
                {
                    DataSet ds = new DataSet();
                    SFact sFact = new SFact();
                    SOperate s1 = sFact.Select();
                    ds = s1._Select("sys_name", "system", "sys_num", textBox1.Text);
                    Form f = new MainWin(this, ds.Tables[0].Rows[0][0].ToString().Trim(),1);
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("用户名不存在或密码错误...");
                }
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
