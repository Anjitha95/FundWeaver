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
    public partial class Printhist : Form
    {
        public Printhist()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button7.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            button7.Visible = true;
        }

        private void Printhist_Load(object sender, EventArgs e)
        {
            label2.Text = geneoldrecp.SetValueForText1;
            label10.Text = geneoldrecp.SetValueForText2;
            label11.Text = geneoldrecp.SetValueForText3;
            label12.Text = geneoldrecp.SetValueForText4;
            label13.Text = geneoldrecp.SetValueForText5;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
