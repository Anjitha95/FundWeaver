using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundWeaverApp
{
    public partial class forgotpass : Form
    {
        public forgotpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            try
            {
                Regex rEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (!rEMail.IsMatch(mailtextBox.Text))
                {
                    MessageBox.Show("Enter valid email");

                    mailtextBox.Text = "";
                }
                else {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                    string z = "select username,password from Login where email = '" + mailtextBox.Text.Trim() + "' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = z;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        username = rd["username"].ToString();
                        password = rd["password"].ToString();

                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (!string.IsNullOrEmpty(password))   // sending email to user for password retrival
            {
                MessageBox.Show("Password successfully send to mail...");
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                MailMessage msg = new MailMessage("	fundweaverappnoreply@gmail.com", mailtextBox.Text.Trim());
                msg.Subject = " Password Recovery ";
                msg.Body = (" Your username is " + username + " Your password is " + password);
                sc.Credentials = new NetworkCredential("fundweaverappnoreply", "fundweaver@275");
                sc.EnableSsl = true;
                sc.Send(msg);
               
                this.Dispose();
            }
            else
            {
                MessageBox.Show("user doesnot exist");
                mailtextBox.Text = "";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void forgotpass_Load(object sender, EventArgs e)
        {

        }
    }
}
