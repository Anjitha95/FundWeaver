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

namespace FundWeaverApp.UserControls
{
    public partial class Bfund : UserControl
    {
        public Bfund()
        {
            InitializeComponent();
            comboBox1.Text = "--fund--";
            comboBox2.Text = "--organisation--";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                string z = "select Ftype, count(*) as cnt from Fund group by Ftype having count(*) >= 1 ";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = z;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    comboBox1.Items.Add(rd.GetString(rd.GetOrdinal("Ftype")));

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DbOperations db = new DbOperations();
            string a = "select Id as Recieptnumber, Fname as Name, famount as Amount, Fdate as PaymentDate,Ftype as FundType, District from Fund where Ftype = '" + comboBox1.Text + "'";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem != null )
           {
               if (comboBox2.Text == "Church")
               {


                   DbOperations db = new DbOperations();
                   string a = "select a.Id as Recieptnumber, a.Fname as Name, a.famount as Amount, a.Fdate as PaymentDate,a.Ftype as FundType, a.District from Fund as a inner join building as b on a.Fname = b.bldname where b.btype ='" + comboBox2.Text + "'";
                   DataTable dt = db.ret(a);
                   dataGridView1.DataSource = dt;

               }
               else if (comboBox2.Text == "Convent")
               {


                   DbOperations db = new DbOperations();
                   string a = "select a.Id as Recieptnumber, a.Fname as Name, a.famount as Amount, a.Fdate as PaymentDate,a.Ftype as FundType, a.District from Fund as a inner join building as b on a.Fname = b.bldname where b.btype ='" + comboBox2.Text + "' ";
                   DataTable dt = db.ret(a);
                   dataGridView1.DataSource = dt;

               }
               else
               {
                   DbOperations db = new DbOperations();
                   string a = "select a.Id as Recieptnumber, a.Fname as Name, a.famount as Amount, a.Fdate as PaymentDate,a.Ftype as FundType, a.District from Fund as a inner join Beneficiary as b on a.Fname = b.bname ";
                   DataTable dt = db.ret(a);
                   dataGridView1.DataSource = dt;
               }
           }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            comboBox1.Text = "--fund--";
            comboBox2.Text = "--organisation--";
        }
    }
}
