using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundWeaverApp
{
    public partial class changeUC : UserControl
    {
        public changeUC()
        {
            InitializeComponent();
            changelabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(newtextBox.Text == confirmtextBox.Text)
            {
                string b = usrtextBox.Text;
                DbOperations db = new DbOperations();
                string c = "update Login set password ='" + newtextBox.Text + "'  where username='" + b + "'";
                db.nonreturn(c);
                MessageBox.Show("Successfull.....");
                newtextBox.Text = "";
                confirmtextBox.Text = "";
                usrtextBox.Text = "";
            }
            else
            {
                changelabel.Visible = true;
            }
            
        }
    }
}
