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
    public partial class BCview : UserControl
    {
        public BCview()
        {
            InitializeComponent();
        }

        private void BCview_Load(object sender, EventArgs e)
        {
           
            DbOperations db = new DbOperations();
            string a = "select * from building";
            DataTable dt = db.ret(a);
            dataGridView1.DataSource = dt;
        }
    }
}
