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
    public partial class updatech : UserControl
    {
        int id;
        private bool buttonClick1;
        private bool buttonClick2;
        public updatech()
        {
            InitializeComponent();
        }
       private void diplayData()
        {
            DbOperations db = new DbOperations();
            string a = "select * from building";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;
        }
        private void updatech_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(nmetextBox!= null && disttextBox!= null & cnotextBox!= null)
            {
                DbOperations db = new DbOperations();
                string c = "update building set bldname = '"+nmetextBox.Text+"', District = '"+disttextBox.Text+"',contactnumbr='"+cnotextBox.Text+"' where bId = '"+id+"' ";
                db.nonreturn(c);
                diplayData();
                nmetextBox.Text = "";
                cnotextBox.Text = "";
                disttextBox.Text = "";
            }
            else
            {
                MessageBox.Show("invalid data updation");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonClick1)
            {

           
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //nametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                disttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cnotextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                nmetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            if(buttonClick2)
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

}

        private void button2_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            string c = "delete from building where bId = '" + id + "' ";
            db.nonreturn(c);
            diplayData();
            nmetextBox.Text = "";
            cnotextBox.Text = "";
            disttextBox.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonClick1 = true;
            panel2.Visible = false;
            DbOperations db = new DbOperations();
            string a = "select bId as RegNo, bldname as Buildingname, District, btype as TypeofOrganisation, contactnumbr as Phoneno,Place from building";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;
            panel1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            disttextBox.Text = "";
            cnotextBox.Text = " ";
            nmetextBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonClick2 = true;
            DbOperations db = new DbOperations();
            string a = "select beId as RegisterID, bname as BeneficiaryName, bedist as District, becontactno as PhoneNo, bplace as Place from Beneficiary ";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            string c = "update Beneficiary set bname = '" + textBox3.Text + "', bedist = '" + textBox2.Text + "',becontactno='" + textBox1.Text + "' where beId = '" + id + "' ";
            db.nonreturn(c);
            diplayData();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            string c = "delete from Beneficiary where beId = '" + id + "' ";
            db.nonreturn(c);
            diplayData();
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }
    }
}
