namespace ApplicationBusShowv1._1
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnAbout = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblH6 = new System.Windows.Forms.Label();
            this.lblHTP = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.pnAbout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnAbout
            // 
            this.pnAbout.BackgroundImage = global::ApplicationBusShowv1._1.Properties.Resources.PART_C__2_;
            this.pnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnAbout.Controls.Add(this.panel2);
            this.pnAbout.Controls.Add(this.label10);
            this.pnAbout.Controls.Add(this.label9);
            this.pnAbout.Controls.Add(this.label8);
            this.pnAbout.Controls.Add(this.lblH6);
            this.pnAbout.Controls.Add(this.lblHTP);
            this.pnAbout.Controls.Add(this.linkLabel1);
            this.pnAbout.Controls.Add(this.btnClose2);
            this.pnAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAbout.Location = new System.Drawing.Point(0, 0);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(999, 300);
            this.pnAbout.TabIndex = 0;
            this.pnAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnAbout_MouseDown);
            this.pnAbout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnAbout_MouseMove);
            this.pnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnAbout_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(372, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 57);
            this.panel2.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(-913, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(5624, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = resources.GetString("lblName.Text");
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(78, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "- Đổi nút close";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(76, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "- Thêm lộ trình theo địa danh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(77, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "- Đổi giao diện";
            // 
            // lblH6
            // 
            this.lblH6.BackColor = System.Drawing.Color.Transparent;
            this.lblH6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH6.ForeColor = System.Drawing.Color.Yellow;
            this.lblH6.Location = new System.Drawing.Point(654, 78);
            this.lblH6.Name = "lblH6";
            this.lblH6.Size = new System.Drawing.Size(305, 61);
            this.lblH6.TabIndex = 16;
            this.lblH6.Text = "NGUYỄN HOÀNG TUẤN";
            this.lblH6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH6.Click += new System.EventHandler(this.lblH6_Click);
            this.lblH6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblH6_MouseDoubleClick);
            // 
            // lblHTP
            // 
            this.lblHTP.BackColor = System.Drawing.Color.Transparent;
            this.lblHTP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTP.ForeColor = System.Drawing.Color.Yellow;
            this.lblHTP.Location = new System.Drawing.Point(343, 78);
            this.lblHTP.Name = "lblHTP";
            this.lblHTP.Size = new System.Drawing.Size(286, 61);
            this.lblHTP.TabIndex = 15;
            this.lblHTP.Text = "HUỲNH TẤN PHÚC";
            this.lblHTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHTP.Click += new System.EventHandler(this.lblHTP_Click);
            this.lblHTP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblHTP_MouseDoubleClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Purple;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(77, 94);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(211, 35);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "fb.com/H6.INFO";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnClose2
            // 
            this.btnClose2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose2.BackColor = System.Drawing.Color.Transparent;
            this.btnClose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.ForeColor = System.Drawing.Color.Green;
            this.btnClose2.Location = new System.Drawing.Point(951, 5);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(45, 31);
            this.btnClose2.TabIndex = 8;
            this.btnClose2.Text = "X";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 300);
            this.Controls.Add(this.pnAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnAbout.ResumeLayout(false);
            this.pnAbout.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblH6;
        private System.Windows.Forms.Label lblHTP;
        private System.Windows.Forms.Timer timer1;
    }
}