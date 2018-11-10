using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundWeaverApp.UserControls
{
    public partial class RegisterUc : UserControl
    {
        public String btype;
        public RegisterUc()
        {
            InitializeComponent();
            comboBox1.Text = "--select--";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Church" || comboBox1.Text == "Convent")
            {
                DbOperations db = new DbOperations();
                String a = "select max(BId) from Building";
                String b = db.maxid(a).ToString();
                btype = comboBox1.Text.ToString();
                string s = "insert into Building values('" + b + "','" + blnametxt.Text + "','" + dsttxt.Text + "','" + btype + "','" + cnttxt.Text + "','" + plcetxt.Text + "')";
                db.nonreturn(s);
                MessageBox.Show("Insertion Successfull...");
                blnametxt.Text = " ";
                dsttxt.Text = " ";
                comboBox1.Text = "--select--";
                cnttxt.Text = " ";
                plcetxt.Text = " ";
            }
            else
            {
                DbOperations db = new DbOperations();
                String a = "select max(beId) from Beneficiary";
                String b = db.maxid(a).ToString();
                btype = comboBox1.Text.ToString();
                string s = "insert into Beneficiary values('" + b + "','" + blnametxt.Text + "','" + dsttxt.Text + "','" + cnttxt.Text + "','" + plcetxt.Text + "')";
                db.nonreturn(s);
                MessageBox.Show("Insertion Successfull...");
                blnametxt.Text = " ";
                dsttxt.Text = " ";
                comboBox1.Text = "--select--";
                cnttxt.Text = " ";
                plcetxt.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blnametxt.Text = " ";
            dsttxt.Text = " ";
            comboBox1.Text = "--select--";
            cnttxt.Text = " ";
            plcetxt.Text = " ";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
