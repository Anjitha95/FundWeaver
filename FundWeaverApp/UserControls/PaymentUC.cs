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
    public partial class PaymentUC : UserControl
    {
        
        
        public PaymentUC()
        {
            InitializeComponent();
            comboBox1.Focus();
            


        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // fund name database update in combobox

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                string z = "select Ftype, count(*) as cnt from Fund group by Ftype having count(*) >= 1";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = z;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    PytypecomboBox.Items.Add(rd.GetString(rd.GetOrdinal("Ftype")));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (comboBox1.Text == "Church")
            {
                //MessageBox.Show(comboBox1.Text);
                pymtnamecomboBox1.Focus();
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                    string a = "select * from building where btype='" + comboBox1.Text+"' ";

                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = a;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        pymtnamecomboBox1.Items.Add(rd.GetString(rd.GetOrdinal("bldname")));
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (comboBox1.Text == "Convent")
            {
                pymtnamecomboBox1.Focus();
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                    string a = "select bldname from building where btype='" + comboBox1.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = a;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        pymtnamecomboBox1.Items.Add(rd.GetString(rd.GetOrdinal("bldname")));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                pymtnamecomboBox1.Focus();
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                    string a = "select bname from Beneficiary";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = a;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        pymtnamecomboBox1.Items.Add(rd.GetString(rd.GetOrdinal("bname")));
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e) //clear button
        {
            dateTimePicker1.Text = "";
            comboBox1.Text = " ";
            pymtnamecomboBox1.Items.Clear();
            pymtnamecomboBox1.Text = " ";
            ContextBox.Text = " ";
            plctextBox.Text = " ";
            distextBox.Text = " ";
            amttxt.Text = " ";
            

        }

        private void pymtnamecomboBox1_SelectedIndexChanged(object sender, EventArgs e) // automatic display of details in textbox
        {
            if (comboBox1.Text == "Church" || comboBox1.Text == "Convent")
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                    string a = "select * from building where bldname='" + pymtnamecomboBox1.Text + "' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = a;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        String cno = rd["contactnumbr"].ToString();
                        String plc = rd.GetString(rd.GetOrdinal("Place"));
                        String dst = rd.GetString(rd.GetOrdinal("District"));
                        ContextBox.Text = cno;
                        plctextBox.Text = plc;
                        distextBox.Text = dst;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                    string a = "select * from Beneficiary where bname='" + pymtnamecomboBox1.Text + "' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = a;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        String cno = rd["becontactno"].ToString();
                        String plc = rd.GetString(rd.GetOrdinal("bplace"));
                        String dst = rd.GetString(rd.GetOrdinal("bedist"));
                        ContextBox.Text = cno;
                        plctextBox.Text = plc;
                        distextBox.Text = dst;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)  //generation code
        {
            
            DbOperations db = new DbOperations();
            string a = "select max(Id) from Fund";
            string b = db.maxid(a).ToString();
            string s = "insert into Fund values('" + b + "','" + pymtnamecomboBox1.Text + "','" + amttxt.Text + "','" + dateTimePicker1.Text + "','" + PytypecomboBox.Text + "','"+distextBox.Text+"')";
            db.nonreturn(s);
            MessageBox.Show("Insertion Successfull...");
            pymtnamecomboBox1.Items.Clear();
            pymtnamecomboBox1.Text = "";
            amttxt.Text = " ";
            comboBox1.Text = "--select--";
            dateTimePicker1.Text="";
            PytypecomboBox.Items.Clear();
            PytypecomboBox.Text = "";
            ContextBox.Text = "";
            plctextBox.Text = "";
            distextBox.Text = "";
        }
    }
}
