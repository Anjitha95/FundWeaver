using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FundWeaverApp.UserControls;

namespace FundWeaverApp
{
    public partial class BishopF : Form
    {
        int PanelWidth;
        bool iscollapsed;
        public BishopF(string d)
        {
            InitializeComponent();
            FirstUc bf = new FirstUc();
            AddControlsToPannel(bf);
            label3.Text = d;
            PanelWidth = Leftpanel.Width;
            iscollapsed = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollapsed)
            {
                Leftpanel.Width = Leftpanel.Width + 10;
                if (Leftpanel.Width >= PanelWidth)
                {
                    timer1.Stop();
                    iscollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                Leftpanel.Width = Leftpanel.Width - 10;
                if (Leftpanel.Width <= 71)
                {
                    timer1.Stop();
                    iscollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MoveSidePanel(Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;

        }
        private void AddControlsToPannel(Control c)              // To add UC Function
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        
        private void homebtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(homebtn);
            FirstUc bf = new FirstUc();
            AddControlsToPannel(bf);
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(newbtn);
            BCview bc = new BCview();
            AddControlsToPannel(bc);
        }

        private void fundbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(fundbtn);
            Bfund bfun = new Bfund();
            AddControlsToPannel(bfun);
        }

        private void yrbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(yrbtn);
            yearuc yr = new yearuc();
            AddControlsToPannel(yr);
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(changebtn);
            changeUC cp = new changeUC();
            AddControlsToPannel(cp);
        }

        private void button1_Click(object sender, EventArgs e) //logout btn
        {
            MoveSidePanel(button1);
            Login lg = new Login();
            lg.Show();
            this.Dispose();
        }

        
    }   
}
