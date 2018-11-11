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
         bool dateChanged1 = false;
         bool dateChanged2 = false;
        public HistoryUc()
        {
            InitializeComponent();
            comboBox1.Text = "--select--";
            namecomboBox.Text = "--select--";
            orgcomboBox.Text = "--select--";
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

      //  private void orgcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DbOperations db = new DbOperations();
            string a = "select * from Fund where Ftype = '" + comboBox1.Text + "'";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;
        }
        
        
            
        
        private void button2_Click(object sender, EventArgs e)
        {
            /*if(orgcomboBox.SelectedItem != null && namecomboBox.SelectedItem == null && districttextBox.Text == null)
            {
                if (orgcomboBox.Text == "Church")
                {


                    DbOperations db = new DbOperations();
                    string a = "select a.*  from Fund as a inner join building as b on a.Fname = b.bldname where b.btype ='" + orgcomboBox.Text + "'";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;

                }
                else if (orgcomboBox.Text == "Convent")
                {


                    DbOperations db = new DbOperations();
                    string a = "select a.* from Fund as a inner join building as b on a.Fname = b.bldname where b.btype ='" + orgcomboBox.Text + "' ";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    DbOperations db = new DbOperations();
                    string a = "select a.* from Fund as a inner join Beneficiary as b on a.Fname = b.bname where a.District= '" + districttextBox.Text + "' ";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;
                }
            }*/
            if (orgcomboBox.SelectedItem== null && districttextBox.Text != null )   // only district search
            {
                //MessageBox.Show("inside the look u wanted"); testing whether it enters if statement or not
                DbOperations db = new DbOperations();
                string a = " select * from Fund where District= '"+districttextBox.Text+"'";
                DataTable dt = db.ret(a);
                dataGridView1.DataSource = dt;
            }
            if (orgcomboBox.SelectedItem != null && districttextBox.Text != null)   // district and orgbox search
            {
                if (orgcomboBox.Text == "Church")
                {


                    DbOperations db = new DbOperations();
                    string a = "select a.*  from Fund as a inner join building as b on a.Fname = b.bldname where a.District = '" + districttextBox.Text + "' and b.btype ='" + orgcomboBox.Text + "'";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;

                }
                else if (orgcomboBox.Text == "Convent")
                {


                    DbOperations db = new DbOperations();
                    string a = "select a.* from Fund as a inner join building as b on a.Fname = b.bldname where a.District = '" + districttextBox.Text + "' and b.btype ='" + orgcomboBox.Text + "' ";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    DbOperations db = new DbOperations();
                    string a = "select a.* from Fund as a inner join Beneficiary as b on a.Fname = b.bname where a.District= '" + districttextBox.Text + "' ";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;
                }
            }
            if ( orgcomboBox.SelectedItem != null && namecomboBox.SelectedItem!= null )      //  name and org only
            {
                if (orgcomboBox.Text == "Church")
                {
                    //MessageBox.Show("inside");

                    DbOperations db = new DbOperations();
                    string a = "select a.*  from Fund as a inner join building as b on a.Fname = b.bldname where  b.btype ='" + orgcomboBox.Text + "' and b.bldname = '"+namecomboBox.Text+"'";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;

                }
                else if (orgcomboBox.Text == "Convent")
                {


                    DbOperations db = new DbOperations();
                    string a = "select a.*  from Fund as a inner join building as b on a.Fname = b.bldname where  b.btype ='" + orgcomboBox.Text + "'and b.bldname= '"+namecomboBox.Text+"' ";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    DbOperations db = new DbOperations();
                    string a = "select a.*  from Fund as a inner join Beneficiary as b on a.Fname = b.bname where a.Fname= '"+namecomboBox.Text+"' ";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;
                }
            }
            if (dateChanged1 && dateChanged2)
                {
                    //MessageBox.Show("inside date");
                    DbOperations db = new DbOperations();
                    string a = "select * from Fund where Fdate between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'";
                    DataTable dt = db.ret(a);
                    dataGridView1.DataSource = dt;
                }    
           
        }

    private void orgcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
    {

        if (orgcomboBox.Text == "Church")
        {
            //MessageBox.Show(comboBox1.Text);
            
            namecomboBox.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                string a = "select * from building where btype='" + orgcomboBox.Text + "' ";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = a;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    namecomboBox.Items.Add(rd.GetString(rd.GetOrdinal("bldname")));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        else if (orgcomboBox.Text == "Convent")
        {
            
            namecomboBox.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
                string a = "select bldname from building where btype='" + orgcomboBox.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = a;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    namecomboBox.Items.Add(rd.GetString(rd.GetOrdinal("bldname")));
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
            
            namecomboBox.Items.Clear();
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
                    namecomboBox.Items.Add(rd.GetString(rd.GetOrdinal("bname")));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "--select--";
            namecomboBox.Text = "--select--";
            orgcomboBox.Text = "--select--";
            namecomboBox.Items.Clear();
            orgcomboBox.SelectedItem = null;
            districttextBox.Text = "";
            dateChanged1 = false;
            dateChanged2 = false;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateChanged1 = true;
    }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateChanged2 = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            comboBox1.Text = " ";
        }
    }
}
