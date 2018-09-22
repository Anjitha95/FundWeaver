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
    public partial class HistoryUc : UserControl
    {
        public HistoryUc()
        {
            InitializeComponent();
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
    }
}
