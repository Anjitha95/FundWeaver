﻿using System;
using System.Data;
using System.Windows.Forms;

namespace FundWeaverApp
{
    public partial class Login : Form
    {
        public String utype;
        

        public Login()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            string s = "select *from login where username='" + usrtextBox.Text + "' and password='" + passtextBox.Text + "'";
            DataTable dt = db.ret(s);
            if(dt.Rows.Count > 0)
            {
                utype = dt.Rows[0][3].ToString().Trim();
                //MessageBox.Show(utype);
                if(utype == "FM")                                // authentication according to roles
                {
                    this.Hide();
                    FHome fm = new FHome();
                    fm.Show();
                }
                else
                {
                    this.Hide();
                    BishopF bm = new BishopF();
                    bm.Show();
                }
            }
            
        }
    }
}
