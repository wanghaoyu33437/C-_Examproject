﻿using System;
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
    public partial class SelVip : MetroFramework.Forms.MetroForm
    {
        string str;
        public static SelVip f = null;
        public static SelVip GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new SelVip(f1,str);
            }

            return f;
        }
        public SelVip(Form f, string str)
        {

            InitializeComponent();
            this.str = str;
            label4.Text = str;
            ShowInfo();
        }
        public SelVip()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void SelVip_Load(object sender, EventArgs e)
        {

        }
        public void ShowInfo()
        {
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("会员号");
            comboBox1.Items.Add("姓名");
            comboBox1.Items.Add("年龄");
            comboBox1.Items.Add("性别");
            comboBox1.Items.Add("手机号");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            DataSet ds1 = new DataSet();
            if (comboBox1.Text.Equals("All"))
            {
                ds = s._Select(" id as ID,vip_num as '会员号',vip_name as '会员名',vip_sex as '性别', vip_age as '年龄',vip_money as '余额',vip_phone as '联系方式',vip_pwd as '密码'", "vip");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("会员号"))
            {
                ds = s._Select("*", "vip", "vip_num", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("姓名"))
            {
                ds = s._Select("*", "vip", "vip_name", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("年龄"))
            {
                ds = s._Select("*", "vip", "vip_age", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("性别"))
            {
                ds = s._Select("*", "vip", "vip_sex", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (comboBox1.Text.Equals("手机号"))
            {
                ds = s._Select("*", "vip", "vip_phone", textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
