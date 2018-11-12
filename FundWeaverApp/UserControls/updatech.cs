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
            DbOperations db = new DbOperations();
            string a = "select * from building";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;


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
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //nametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            disttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cnotextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            nmetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
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
    }
}
