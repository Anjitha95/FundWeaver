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
    public partial class HistoryUc : UserControl
    {
        private readonly object MultiView1;

        public HistoryUc()
        {
            InitializeComponent();
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
                    comboBox2.Items.Add(rd.GetString(rd.GetOrdinal("Ftype")));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            //try            name of all
            //{
            //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
            //    string a = "select bldname from building UNION select bname from Beneficiary";
            //    string a = "select * from building, Beneficiary ";
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = a;
            //    SqlDataReader rd = cmd.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        comboBox3.Items.Add(rd.GetString(rd.GetOrdinal("bldname")));
            //        comboBox3.Items.Add(rd.GetString(rd.GetOrdinal("bname")));
            //    }
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void HistoryUc_Load(object sender, EventArgs e)
        {
            bottompanel.Visible = false;
            tabpanel.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bottompanel.Visible == true)
                bottompanel.Visible = false;
            else
                bottompanel.Visible = true;
            if (tabpanel.Visible == true)
                tabpanel.Visible = false;
            else
                tabpanel.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox3.Text == "Church")
            {
                //MessageBox.Show(comboBox1.Text);
                comboBox5.Focus();
                comboBox5.Items.Clear();
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                    string a = "select * from building where btype='" + comboBox3.Text + "' ";

                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = a;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        comboBox5.Items.Add(rd.GetString(rd.GetOrdinal("bldname")));
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (comboBox3.Text == "Convent")
            {
                comboBox5.Focus();
                comboBox5.Items.Clear();
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                    string a = "select bldname from building where btype='" + comboBox3.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = a;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        comboBox5.Items.Add(rd.GetString(rd.GetOrdinal("bldname")));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                comboBox5.Focus();
                comboBox5.Items.Clear();
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
                        comboBox5.Items.Add(rd.GetString(rd.GetOrdinal("bname")));
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void grid()
        {
            DbOperations db = new DbOperations();
            string a = "select * from article";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
