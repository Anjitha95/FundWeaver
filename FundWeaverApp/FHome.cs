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
    public partial class FHome : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public FHome()
        {
            InitializeComponent();
            FirstUc fc = new FirstUc();
            AddControlsToPannel(fc);   // Starting UC
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)   // working of menu bar
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;   
                if(panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if(panelLeft.Width <= 71)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)      //closes Application
        {
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)  // Minimization
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MoveSidePanel(Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;

        }

        private void FHome_Load(object sender, EventArgs e)
        {

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
            FirstUc fc = new FirstUc();
            AddControlsToPannel(fc);
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(newbtn);
            RegisterUc ru = new RegisterUc();
            AddControlsToPannel(ru);
        }

        private void genbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(genbtn);
            PaymentUC pu = new PaymentUC();
            AddControlsToPannel(pu);
        }

        private void fundbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(fundbtn);
        }

        private void yrbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(yrbtn);
        }

        private void convertbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(convertbtn);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            timeLab.Text = dt.ToString("HH:MM:ss");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /* private void FHome_MouseMove(object sender, MouseEventArgs e) // for enabling movement of form
         {
             if (e.Button == MouseButtons.Left)
             {
                 this.Left += e.X - lastPoint.X;
                 this.Top += e.Y - lastPoint.Y;
             }
         }
         Point lastPoint;

         private void FHome_MouseDown(object sender, MouseEventArgs e)
         {
             lastPoint = new Point(e.X, e.Y);
         }*/
    }
}
