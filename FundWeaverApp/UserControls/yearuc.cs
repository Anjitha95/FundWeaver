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
    public partial class yearuc : UserControl
    {
        public yearuc()
        {
            InitializeComponent();
            comboBox1.Text = "--select--";
            for (int i = 1970; i <= 3000; i++)
            {
                comboBox1.Items.Add(i.ToString());


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            comboBox1.Text = "--select--";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            string a = "select * from Fund where year(Fdate) = '" + comboBox1.Text + "' ";
            DataTable dt = db.ret(a);
            dt.TableName = "Fund";
            dataGridView1.DataSource = dt;
        }
    }
}
