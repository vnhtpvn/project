namespace ApplicationBusShowv1._1
{
    partial class H6BusApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H6BusApp));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerRunText = new System.Windows.Forms.Timer(this.components);
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblStickS = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStickN = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.btnBackN = new System.Windows.Forms.Button();
            this.btnGoN = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.dataLoad = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTuyen = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblShowT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTGo = new System.Windows.Forms.Button();
            this.btnBackT = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btExpand = new System.Windows.Forms.Button();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblStation2 = new System.Windows.Forms.Label();
            this.lblStation1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGo = new System.Windows.Forms.Label();
            this.pnInfo.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoad)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerRunText
            // 
            this.timerRunText.Tick += new System.EventHandler(this.timerRunText_Tick);
            // 
            // pnInfo
            // 
            this.pnInfo.BackgroundImage = global::ApplicationBusShowv1._1.Properties.Resources.PART_B1;
            this.pnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnInfo.Controls.Add(this.lblOwner);
            this.pnInfo.Controls.Add(this.lblKM);
            this.pnInfo.Controls.Add(this.lblStickS);
            this.pnInfo.Controls.Add(this.lblTime);
            this.pnInfo.Controls.Add(this.lblStickN);
            this.pnInfo.Controls.Add(this.lblType);
            this.pnInfo.Controls.Add(this.lblGoBack);
            this.pnInfo.Controls.Add(this.btnBackN);
            this.pnInfo.Controls.Add(this.btnGoN);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInfo.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnInfo.Location = new System.Drawing.Point(0, 199);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(1000, 301);
            this.pnInfo.TabIndex = 1;
            // 
            // lblOwner
            // 
            this.lblOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblOwner.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.Silver;
            this.lblOwner.Location = new System.Drawing.Point(408, 135);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(211, 34);
            this.lblOwner.TabIndex = 28;
            this.lblOwner.Text = "SAIGONBUS";
            // 
            // lblKM
            // 
            this.lblKM.BackColor = System.Drawing.Color.Transparent;
            this.lblKM.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.ForeColor = System.Drawing.Color.White;
            this.lblKM.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblKM.Location = new System.Drawing.Point(45, 58);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(148, 60);
            this.lblKM.TabIndex = 22;
            this.lblKM.Text = "99,99";
            // 
            // lblStickS
            // 
            this.lblStickS.BackColor = System.Drawing.Color.Transparent;
            this.lblStickS.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStickS.ForeColor = System.Drawing.Color.White;
            this.lblStickS.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblStickS.Location = new System.Drawing.Point(827, 57);
            this.lblStickS.Name = "lblStickS";
            this.lblStickS.Size = new System.Drawing.Size(117, 60);
            this.lblStickS.TabIndex = 21;
            this.lblStickS.Text = "2000";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTime.Location = new System.Drawing.Point(253, 58);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(95, 60);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "99";
            // 
            // lblStickN
            // 
            this.lblStickN.BackColor = System.Drawing.Color.Transparent;
            this.lblStickN.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStickN.ForeColor = System.Drawing.Color.White;
            this.lblStickN.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblStickN.Location = new System.Drawing.Point(634, 58);
            this.lblStickN.Name = "lblStickN";
            this.lblStickN.Size = new System.Drawing.Size(151, 60);
            this.lblStickN.TabIndex = 19;
            this.lblStickN.Text = "5000";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblType.Location = new System.Drawing.Point(400, 58);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(193, 60);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "TỰ ĐỘNG";
            // 
            // lblGoBack
            // 
            this.lblGoBack.BackColor = System.Drawing.Color.Transparent;
            this.lblGoBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoBack.ForeColor = System.Drawing.Color.White;
            this.lblGoBack.Location = new System.Drawing.Point(322, 211);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(601, 70);
            this.lblGoBack.TabIndex = 17;
            this.lblGoBack.Text = "LKJHGFDFGDG DFGDFG DF GDFG DF GDFG DF GDF GD FGSDF GDFG DFG DFGD FDFGDFGDFG DDF D" +
    "F GDFGDFG DFGDFGDFG DFGDFG DGD D  GDFG ";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackN
            // 
            this.btnBackN.BackColor = System.Drawing.Color.Black;
            this.btnBackN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackN.ForeColor = System.Drawing.Color.Gold;
            this.btnBackN.Location = new System.Drawing.Point(170, 245);
            this.btnBackN.Name = "btnBackN";
            this.btnBackN.Size = new System.Drawing.Size(123, 34);
            this.btnBackN.TabIndex = 17;
            this.btnBackN.Text = "LƯỢT VỀ";
            this.btnBackN.UseVisualStyleBackColor = false;
            this.btnBackN.Click += new System.EventHandler(this.btnBackN_Click);
            // 
            // btnGoN
            // 
            this.btnGoN.BackColor = System.Drawing.Color.Black;
            this.btnGoN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoN.ForeColor = System.Drawing.Color.Gold;
            this.btnGoN.Location = new System.Drawing.Point(57, 245);
            this.btnGoN.Name = "btnGoN";
            this.btnGoN.Size = new System.Drawing.Size(116, 34);
            this.btnGoN.TabIndex = 17;
            this.btnGoN.Text = "LƯỢT ĐI";
            this.btnGoN.UseVisualStyleBackColor = false;
            this.btnGoN.Click += new System.EventHandler(this.btnGoN_Click);
            // 
            // pnTop
            // 
            this.pnTop.BackgroundImage = global::ApplicationBusShowv1._1.Properties.Resources.PART_A1;
            this.pnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTop.Controls.Add(this.dataLoad);
            this.pnTop.Controls.Add(this.btnSearch);
            this.pnTop.Controls.Add(this.panel4);
            this.pnTop.Controls.Add(this.panel3);
            this.pnTop.Controls.Add(this.lblShowT);
            this.pnTop.Controls.Add(this.panel2);
            this.pnTop.Controls.Add(this.btnTGo);
            this.pnTop.Controls.Add(this.btnBackT);
            this.pnTop.Controls.Add(this.btnAbout);
            this.pnTop.Controls.Add(this.btnClose);
            this.pnTop.Controls.Add(this.btExpand);
            this.pnTop.Controls.Add(this.lblTime2);
            this.pnTop.Controls.Add(this.lblTime1);
            this.pnTop.Controls.Add(this.lblStation2);
            this.pnTop.Controls.Add(this.lblStation1);
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1000, 500);
            this.pnTop.TabIndex = 0;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseMove);
            this.pnTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseUp);
            // 
            // dataLoad
            // 
            this.dataLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoad.Location = new System.Drawing.Point(591, 45);
            this.dataLoad.Name = "dataLoad";
            this.dataLoad.RowTemplate.Height = 24;
            this.dataLoad.Size = new System.Drawing.Size(77, 56);
            this.dataLoad.TabIndex = 17;
            this.dataLoad.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLoad_RowEnter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.Location = new System.Drawing.Point(39, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 43);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "TÌM";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblTuyen);
            this.panel4.Location = new System.Drawing.Point(248, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(827, 92);
            this.panel4.TabIndex = 19;
            // 
            // lblTuyen
            // 
            this.lblTuyen.BackColor = System.Drawing.Color.Transparent;
            this.lblTuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTuyen.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuyen.ForeColor = System.Drawing.Color.Green;
            this.lblTuyen.Location = new System.Drawing.Point(3, 13);
            this.lblTuyen.Name = "lblTuyen";
            this.lblTuyen.Size = new System.Drawing.Size(1713, 46);
            this.lblTuyen.TabIndex = 0;
            this.lblTuyen.Text = "SSSSSSSSS";
            this.lblTuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblNumber);
            this.panel3.Location = new System.Drawing.Point(37, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 106);
            this.panel3.TabIndex = 14;
            // 
            // lblNumber
            // 
            this.lblNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumber.Font = new System.Drawing.Font("Tahoma", 43F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Red;
            this.lblNumber.Location = new System.Drawing.Point(0, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(221, 106);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "999";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowT
            // 
            this.lblShowT.BackColor = System.Drawing.Color.Transparent;
            this.lblShowT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowT.ForeColor = System.Drawing.Color.White;
            this.lblShowT.Location = new System.Drawing.Point(53, 367);
            this.lblShowT.Name = "lblShowT";
            this.lblShowT.Size = new System.Drawing.Size(855, 108);
            this.lblShowT.TabIndex = 13;
            this.lblShowT.Text = "LKJHGFDFGDG DFGDFG DF GDFG DF GDFG DF GDF GD FGSDF GDFG DFG DFGD FDFGDFGDFG DDF D" +
    "F GDFGDFG DFGDFGDFG DFGDFG DGD D  GDFG ";
            this.lblShowT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(135, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 44);
            this.panel2.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(123, 44);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTGo
            // 
            this.btnTGo.BackColor = System.Drawing.Color.Black;
            this.btnTGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTGo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTGo.ForeColor = System.Drawing.Color.Gold;
            this.btnTGo.Location = new System.Drawing.Point(37, 324);
            this.btnTGo.Name = "btnTGo";
            this.btnTGo.Size = new System.Drawing.Size(116, 34);
            this.btnTGo.TabIndex = 10;
            this.btnTGo.Text = "LƯỢT ĐI";
            this.btnTGo.UseVisualStyleBackColor = false;
            this.btnTGo.Click += new System.EventHandler(this.btnTGo_Click);
            // 
            // btnBackT
            // 
            this.btnBackT.BackColor = System.Drawing.Color.Black;
            this.btnBackT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackT.ForeColor = System.Drawing.Color.Gold;
            this.btnBackT.Location = new System.Drawing.Point(159, 324);
            this.btnBackT.Name = "btnBackT";
            this.btnBackT.Size = new System.Drawing.Size(107, 34);
            this.btnBackT.TabIndex = 10;
            this.btnBackT.Text = "LƯỢT VỀ";
            this.btnBackT.UseVisualStyleBackColor = false;
            this.btnBackT.Click += new System.EventHandler(this.btnBackT_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.OldLace;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Location = new System.Drawing.Point(731, 43);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(147, 45);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClose.Location = new System.Drawing.Point(949, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btExpand
            // 
            this.btExpand.BackgroundImage = global::ApplicationBusShowv1._1.Properties.Resources.Open;
            this.btExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExpand.ForeColor = System.Drawing.Color.Black;
            this.btExpand.Location = new System.Drawing.Point(916, 424);
            this.btExpand.Name = "btExpand";
            this.btExpand.Size = new System.Drawing.Size(55, 52);
            this.btExpand.TabIndex = 6;
            this.btExpand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExpand.UseVisualStyleBackColor = true;
            this.btExpand.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTime2
            // 
            this.lblTime2.BackColor = System.Drawing.Color.Transparent;
            this.lblTime2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(802, 261);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(169, 28);
            this.lblTime2.TabIndex = 3;
            this.lblTime2.Text = "99:99-99:99";
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime1
            // 
            this.lblTime1.BackColor = System.Drawing.Color.Transparent;
            this.lblTime1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(322, 260);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(169, 28);
            this.lblTime1.TabIndex = 2;
            this.lblTime1.Text = "99:99-99:99";
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStation2
            // 
            this.lblStation2.BackColor = System.Drawing.Color.Transparent;
            this.lblStation2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation2.Location = new System.Drawing.Point(462, 261);
            this.lblStation2.Name = "lblStation2";
            this.lblStation2.Size = new System.Drawing.Size(400, 28);
            this.lblStation2.TabIndex = 1;
            this.lblStation2.Text = "KDC TRUNG SƠN";
            this.lblStation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStation1
            // 
            this.lblStation1.BackColor = System.Drawing.Color.Transparent;
            this.lblStation1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation1.Location = new System.Drawing.Point(0, 261);
            this.lblStation1.Name = "lblStation1";
            this.lblStation1.Size = new System.Drawing.Size(345, 28);
            this.lblStation1.TabIndex = 0;
            this.lblStation1.Text = "KDC TRUNG SƠN";
            this.lblStation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblGo);
            this.panel1.Location = new System.Drawing.Point(288, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 34);
            this.panel1.TabIndex = 20;
            // 
            // lblGo
            // 
            this.lblGo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGo.ForeColor = System.Drawing.Color.Yellow;
            this.lblGo.Location = new System.Drawing.Point(3, 2);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(5138, 28);
            this.lblGo.TabIndex = 1;
            this.lblGo.Text = resources.GetString("lblGo.Text");
            this.lblGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // H6BusApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "H6BusApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H6 Bus HCM 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.pnInfo.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLoad)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStation1;
        private System.Windows.Forms.Button btExpand;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblStation2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblShowT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTGo;
        private System.Windows.Forms.Button btnBackT;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblStickS;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStickN;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Button btnBackN;
        private System.Windows.Forms.Button btnGoN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataLoad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTuyen;
        private System.Windows.Forms.Timer timerRunText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnTop;

    }
}

