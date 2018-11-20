using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundWeaverApp
{
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
            rolecomboBox.Text = "--select--";
            passcontrollabel.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserReg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsrtextBox.Text== "" || PasstextBox.Text=="" || conptextBox.Text == "" ||rolecomboBox.Text== ""  || emailtextBox.Text == "")
            {
                MessageBox.Show("Compulsory Fields...");
            }
            else if (PasstextBox.Text == conptextBox.Text)
            {
                DbOperations db = new DbOperations();
                string a = "select max(LId) from Login";
                string b = db.maxid(a).ToString();
                string s = "insert into Login values('" + b + "','" + UsrtextBox.Text + "','" + PasstextBox.Text + "','" + rolecomboBox.Text + "','" + emailtextBox.Text + "','"+false+"')";
                db.nonreturn(s);
                MessageBox.Show("Registration was successfull.Message will be sent to your email when the account gets activated.");
                this.Dispose();
            }
            else
            {
                passcontrollabel.Visible = true;
                PasstextBox.Text = "";
                conptextBox.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsrtextBox.Text = "";
            PasstextBox.Text = "";
            conptextBox.Text = "";
            rolecomboBox.Text = "--select--";
            emailtextBox.Text = "";
            passcontrollabel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
