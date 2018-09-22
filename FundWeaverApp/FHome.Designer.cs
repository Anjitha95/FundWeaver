namespace FundWeaverApp
{
    partial class FHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHome));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panelside = new System.Windows.Forms.Panel();
            this.yrbtn = new System.Windows.Forms.Button();
            this.fundbtn = new System.Windows.Forms.Button();
            this.genbtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLab = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelAbove = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.dragContol1 = new FundWeaverApp.DragContol();
            this.dragContol2 = new FundWeaverApp.DragContol();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAbove.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.MediumBlue;
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.panelside);
            this.panelLeft.Controls.Add(this.yrbtn);
            this.panelLeft.Controls.Add(this.fundbtn);
            this.panelLeft.Controls.Add(this.genbtn);
            this.panelLeft.Controls.Add(this.newbtn);
            this.panelLeft.Controls.Add(this.homebtn);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(233, 731);
            this.panelLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 134);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(69, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "FundWeaver";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(194, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 39);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelside.Location = new System.Drawing.Point(0, 173);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(10, 62);
            this.panelside.TabIndex = 3;
            this.panelside.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // yrbtn
            // 
            this.yrbtn.FlatAppearance.BorderSize = 0;
            this.yrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yrbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yrbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yrbtn.Image = ((System.Drawing.Image)(resources.GetObject("yrbtn.Image")));
            this.yrbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yrbtn.Location = new System.Drawing.Point(22, 546);
            this.yrbtn.Name = "yrbtn";
            this.yrbtn.Size = new System.Drawing.Size(202, 62);
            this.yrbtn.TabIndex = 8;
            this.yrbtn.Text = "  Year End Report Generation";
            this.yrbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yrbtn.UseVisualStyleBackColor = true;
            this.yrbtn.Click += new System.EventHandler(this.yrbtn_Click);
            // 
            // fundbtn
            // 
            this.fundbtn.FlatAppearance.BorderSize = 0;
            this.fundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fundbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fundbtn.Image = ((System.Drawing.Image)(resources.GetObject("fundbtn.Image")));
            this.fundbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fundbtn.Location = new System.Drawing.Point(22, 445);
            this.fundbtn.Name = "fundbtn";
            this.fundbtn.Size = new System.Drawing.Size(202, 62);
            this.fundbtn.TabIndex = 7;
            this.fundbtn.Text = "   Fund History";
            this.fundbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fundbtn.UseVisualStyleBackColor = true;
            this.fundbtn.Click += new System.EventHandler(this.fundbtn_Click);
            // 
            // genbtn
            // 
            this.genbtn.FlatAppearance.BorderSize = 0;
            this.genbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.genbtn.Image = global::FundWeaverApp.Properties.Resources.icons8_Receipt_32px;
            this.genbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genbtn.Location = new System.Drawing.Point(22, 348);
            this.genbtn.Name = "genbtn";
            this.genbtn.Size = new System.Drawing.Size(211, 62);
            this.genbtn.TabIndex = 6;
            this.genbtn.Text = "  Receipt Generation";
            this.genbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genbtn.UseVisualStyleBackColor = true;
            this.genbtn.Click += new System.EventHandler(this.genbtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.FlatAppearance.BorderSize = 0;
            this.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.newbtn.Image = ((System.Drawing.Image)(resources.GetObject("newbtn.Image")));
            this.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newbtn.Location = new System.Drawing.Point(22, 253);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(202, 62);
            this.newbtn.TabIndex = 5;
            this.newbtn.Text = "   New Registration";
            this.newbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.homebtn.Image = ((System.Drawing.Image)(resources.GetObject("homebtn.Image")));
            this.homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtn.Location = new System.Drawing.Point(22, 173);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(205, 62);
            this.homebtn.TabIndex = 4;
            this.homebtn.Text = "   Home";
            this.homebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roman Catholic Diocese Of Calicut";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(744, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 45);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(788, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 43);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FundWeaverApp.Properties.Resources.iconlogo;
            this.pictureBox1.Location = new System.Drawing.Point(22, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // timeLab
            // 
            this.timeLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLab.AutoSize = true;
            this.timeLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLab.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.timeLab.Location = new System.Drawing.Point(740, 30);
            this.timeLab.Name = "timeLab";
            this.timeLab.Size = new System.Drawing.Size(83, 19);
            this.timeLab.TabIndex = 1;
            this.timeLab.Text = "HH:MM:SS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelAbove
            // 
            this.panelAbove.Controls.Add(this.label1);
            this.panelAbove.Controls.Add(this.button7);
            this.panelAbove.Controls.Add(this.pictureBox1);
            this.panelAbove.Controls.Add(this.button8);
            this.panelAbove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAbove.Location = new System.Drawing.Point(233, 0);
            this.panelAbove.Name = "panelAbove";
            this.panelAbove.Size = new System.Drawing.Size(876, 51);
            this.panelAbove.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Controls.Add(this.timeLab);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(233, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 83);
            this.panel3.TabIndex = 13;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelControls);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(233, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(876, 597);
            this.panel4.TabIndex = 14;
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(876, 597);
            this.panelControls.TabIndex = 0;
            // 
            // dragContol1
            // 
            this.dragContol1.SelectControl = this.panelAbove;
            // 
            // dragContol2
            // 
            this.dragContol2.SelectControl = this.panel1;
            // 
            // FHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1109, 731);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelAbove);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHome";
            this.Load += new System.EventHandler(this.FHome_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAbove.ResumeLayout(false);
            this.panelAbove.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button yrbtn;
        private System.Windows.Forms.Button fundbtn;
        private System.Windows.Forms.Button genbtn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLab;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAbove;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DragContol dragContol1;
        private DragContol dragContol2;
    }
}