using FundWeaverApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundWeaverApp
{
    public partial class adminForm : Form
    {
        public adminForm(string d)
        {
            InitializeComponent();
            FirstUc bf = new FirstUc();
            AddControlsToPannel(bf);
            label3.Text = d;
        }
       private void AddControlsToPannel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(c);
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            changeUC cp = new changeUC();
            AddControlsToPannel(cp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Dispose();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
           manageruser mu = new manageruser();
            AddControlsToPannel(mu);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
