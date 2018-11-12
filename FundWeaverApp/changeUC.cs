using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FundWeaverApp
{
    public partial class changeUC : UserControl
    {
        public changeUC()
        {
            InitializeComponent();
            changelabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = usrtextBox.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
            string sqlquery = "SELECT password FROM Login where Username='" + usrtextBox.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.Parameters.AddWithValue("@username", usrtextBox.Text);
            cmd.Connection = con;
            con.Open();
            string currentPassword = (string)cmd.ExecuteScalar();

            if (currentPassword == textBox1.Text)
            {
                if (newtextBox.Text == contextBox.Text)
                {

                    DbOperations db = new DbOperations();
                    string c = "update Login set password ='" + newtextBox.Text + "'  where username='" + b + "' ";
                    db.nonreturn(c);
                    MessageBox.Show("Successfull.....");
                    changelabel.Visible = false;
                    usrtextBox.Text = "";
                    textBox1.Text = "";
                    newtextBox.Text = "";
                }
                else
                {
                    changelabel.Visible = true;
                }
            }
            else
            {
                changelabel.Visible = true;
                usrtextBox.Text = "";
                textBox1.Text = "";
                newtextBox.Text = "";
            }
            con.Close();
        }
    }
}
