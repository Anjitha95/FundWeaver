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
    public partial class reportgenUc : UserControl
    {
        public reportgenUc()
        {
            InitializeComponent();
            comboBox1.Text = "--select--";
            for (int i = 1970; i <= 3000; i++)
            {
                comboBox1.Items.Add(i.ToString());


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            string a = "select Id as Recieptnumber, Fname as Name, famount as Amount, Fdate as PaymentDate,Ftype as FundType, District   from Fund where year(Fdate) = '"+comboBox1.Text+"' ";
            DataTable dt = db.ret(a);
            dt.TableName = "Fund";
            dataGridView1.DataSource = dt;
                     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            comboBox1.Text = "--select--";
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            DbOperations db = new DbOperations();
            string a = "select Id as Recieptnumber, Fname as Name, famount as Amount, Fdate as PaymentDate,Ftype as FundType, District from Fund where year(Fdate) = '" + comboBox1.Text + "' ";
            DataTable dt = db.ret(a);
            dt.TableName = "Fund";
            dataGridView1.DataSource = dt;

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "yearendreport";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
    
}
