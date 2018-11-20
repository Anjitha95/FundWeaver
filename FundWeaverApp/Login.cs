using System;
using System.Data;
using System.Windows.Forms;

namespace FundWeaverApp
{
    public partial class Login : Form
    {
        public String utype;
        public bool approve;

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
            string d = usrtextBox.Text;
            string s = "select *from login where username='" + d + "' and password='" + passtextBox.Text + "'";
            DataTable dt = db.ret(s);
            if (dt.Rows.Count > 0)
            {
                utype = dt.Rows[0][3].ToString().Trim();
                approve = (bool)dt.Rows[0][5];
                //MessageBox.Show(utype);
                if (approve == true)
                {


                    if (utype == "FM")                                // authentication according to roles
                    {
                        this.Hide();
                        FHome fm = new FHome(d);
                        fm.Show();
                    }
                    else if (utype == "Bishop")
                    {
                        this.Hide();
                        BishopF bm = new BishopF(d);
                        bm.Show();
                    }
                    else
                    {
                        this.Hide();
                        adminForm af = new adminForm(d);
                        af.Show();
                    }

                }
                else
                {
                    MessageBox.Show("User Account is not activated");
                    usrtextBox.Text = "";
                    passtextBox.Text = "";
                   
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!!");
                usrtextBox.Text = "";
                passtextBox.Text = "";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserReg ur = new UserReg();
            ur.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpass fp = new forgotpass();
            fp.Show();
        }
    }
}
