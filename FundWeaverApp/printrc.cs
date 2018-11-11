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
    public partial class printrc : Form
    {
        public printrc()
        {
            InitializeComponent();
        }

        private void printrc_Load(object sender, EventArgs e)
        {

            label2.Text = PaymentUC.SetValueForText1;
            label10.Text = PaymentUC.SetValueForText2;
            label11.Text = PaymentUC.SetValueForText3;
            label12.Text = PaymentUC.SetValueForText4;
            label13.Text = PaymentUC.SetValueForText5;
            label14.Text = PaymentUC.SetValueForText6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button7.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            button7.Visible = true;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
