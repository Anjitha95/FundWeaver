using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace FundWeaverApp.UserControls
{

    public partial class manageruser : UserControl
    {
        DbOperations db = new DbOperations();
        public int id;
        string email;
        public manageruser()
        {
            InitializeComponent();
        }
        void displayData()
        {
           
            string a = "select LId as RegNo, username as Username, password as Password, Role as TypeofUser, email as Email, UserApprove as Status from Login";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;
        }
        private void manageruser_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[5].Value);
                
                if (isSelected == true)
                {
                   
                    string b = "update Login set UserApprove ='" + true + "' where LId = '" + id + "'";
                    db.nonreturn(b);
                    displayData();

                }
               


            }

            MessageBox.Show("User access unlocked");
            MessageBox.Show(email);
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            MailMessage msg = new MailMessage("	fundweaverappnoreply@gmail.com",email.Trim());
            msg.Subject = " Account Unlocked ";
            msg.Body = ("Your account is successfully unlocked");
            sc.Credentials = new NetworkCredential("fundweaverappnoreply", "fundweaver@275");
            sc.EnableSsl = true;
            sc.Send(msg);
            MessageBox.Show("Unlock message has been send to the mail...");
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            email = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[5].Value);
                if (isSelected == false)
                {
                   
                    string b = "update Login set UserApprove ='" + false + "' where LId = '" + id + "'";
                    
                    db.nonreturn(b);
                    displayData();
                }
            }
            MessageBox.Show("User access locked");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            email = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            string c = "delete from Login where LId = '" + id + "' ";
            db.nonreturn(c);
            MessageBox.Show("Removed User");
            displayData();
            
        }
    }
}
