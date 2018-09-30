namespace FundWeaverApp.UserControls
{
    partial class RegisterUc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cnttxt = new System.Windows.Forms.TextBox();
            this.dsttxt = new System.Windows.Forms.TextBox();
            this.plcetxt = new System.Windows.Forms.TextBox();
            this.blnametxt = new System.Windows.Forms.TextBox();
            this.numbrtxt = new System.Windows.Forms.Label();
            this.distxt = new System.Windows.Forms.Label();
            this.plctxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cnttxt);
            this.panel1.Controls.Add(this.dsttxt);
            this.panel1.Controls.Add(this.plcetxt);
            this.panel1.Controls.Add(this.blnametxt);
            this.panel1.Controls.Add(this.numbrtxt);
            this.panel1.Controls.Add(this.distxt);
            this.panel1.Controls.Add(this.plctxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(41, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 534);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(386, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(230, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Church",
            "Convent"});
            this.comboBox1.Location = new System.Drawing.Point(431, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 27);
            this.comboBox1.TabIndex = 17;
            // 
            // cnttxt
            // 
            this.cnttxt.Location = new System.Drawing.Point(431, 340);
            this.cnttxt.Name = "cnttxt";
            this.cnttxt.Size = new System.Drawing.Size(226, 27);
            this.cnttxt.TabIndex = 16;
            // 
            // dsttxt
            // 
            this.dsttxt.Location = new System.Drawing.Point(431, 291);
            this.dsttxt.Name = "dsttxt";
            this.dsttxt.Size = new System.Drawing.Size(226, 27);
            this.dsttxt.TabIndex = 15;
            this.dsttxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // plcetxt
            // 
            this.plcetxt.Location = new System.Drawing.Point(431, 242);
            this.plcetxt.Name = "plcetxt";
            this.plcetxt.Size = new System.Drawing.Size(226, 27);
            this.plcetxt.TabIndex = 14;
            // 
            // blnametxt
            // 
            this.blnametxt.Location = new System.Drawing.Point(431, 187);
            this.blnametxt.Name = "blnametxt";
            this.blnametxt.Size = new System.Drawing.Size(226, 27);
            this.blnametxt.TabIndex = 13;
            // 
            // numbrtxt
            // 
            this.numbrtxt.AutoSize = true;
            this.numbrtxt.Location = new System.Drawing.Point(91, 343);
            this.numbrtxt.Name = "numbrtxt";
            this.numbrtxt.Size = new System.Drawing.Size(96, 19);
            this.numbrtxt.TabIndex = 10;
            this.numbrtxt.Text = "Contact No";
            // 
            // distxt
            // 
            this.distxt.AutoSize = true;
            this.distxt.Location = new System.Drawing.Point(91, 291);
            this.distxt.Name = "distxt";
            this.distxt.Size = new System.Drawing.Size(57, 19);
            this.distxt.TabIndex = 9;
            this.distxt.Text = "District";
            // 
            // plctxt
            // 
            this.plctxt.AutoSize = true;
            this.plctxt.Location = new System.Drawing.Point(91, 245);
            this.plctxt.Name = "plctxt";
            this.plctxt.Size = new System.Drawing.Size(53, 19);
            this.plctxt.TabIndex = 8;
            this.plctxt.Text = "Place";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Church/Convent Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 523);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(753, 11);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumBlue;
            this.panel4.Location = new System.Drawing.Point(753, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 524);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 524);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 10);
            this.panel2.TabIndex = 0;
            // 
            // RegisterUc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "RegisterUc";
            this.Size = new System.Drawing.Size(876, 597);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dsttxt;
        private System.Windows.Forms.TextBox plcetxt;
        private System.Windows.Forms.TextBox blnametxt;
        private System.Windows.Forms.Label numbrtxt;
        private System.Windows.Forms.Label distxt;
        private System.Windows.Forms.Label plctxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox cnttxt;
    }
}
