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
    public partial class geneoldrecp : UserControl
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public geneoldrecp()
        {
            InitializeComponent();
            comboBox1.Text = "--select--";
            for (int i = 1970; i <= 3000; i++)
            {
                comboBox1.Items.Add(i.ToString());


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            string a = "select * from Fund where year(Fdate) = '" + comboBox1.Text + "' ";
            DataTable dt = db.ret(a);
            dt.TableName = "Fund";
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            comboBox1.Text = "--select--";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetValueForText1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            SetValueForText2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            SetValueForText3 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SetValueForText4 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            SetValueForText5 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Printhist pc = new Printhist();
            pc.Show();
        }
    }
}
