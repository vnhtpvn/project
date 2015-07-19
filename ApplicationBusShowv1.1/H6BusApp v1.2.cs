using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
namespace ApplicationBusShowv1._1
{
    public partial class H6BusApp : Form
    {

        public H6BusApp()
        {
            InitializeComponent();
            infoHeight = pnInfo.Height;
            if (pnInfo.Dock != DockStyle.Fill)
            {
                pnInfo.Dock = DockStyle.Fill;
            }
            dataLoad.Visible = false; // ẩn dataGridview
            
        }
        int infoHeight = 0;
        int raisingHeight = 0;
        int targetHeight = 0;
        int type = 1;
        private void button3_Click(object sender, EventArgs e)
        {
           
            raisingHeight = this.Height;
            pnInfo.BackgroundImageLayout = ImageLayout.Zoom;
            if (pnTop.Height < this.Height)
            {
                targetHeight = pnTop.Height;
                type = 2;
                timer1.Enabled = true;
            }
            else
            {

                targetHeight = pnTop.Height + infoHeight;
                type = 1;
                timer1.Enabled = true;

            }
        }
        //public static extern IntPtr GetForegroundWindow();
        int xT = 400, yT = 25, dric = 0;
        int xD = -500, yD = 6, dv = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            this.Location = new Point(
                (SystemInformation.VirtualScreen.Width - this.Width) / 2, 
                SystemInformation.VirtualScreen.Height / 10);
            
        


            ///
            lblName.Location = new Point(xT, yT);
            timerRunText.Interval = 1;
            timerRunText.Start();
            lblPlace.Location = new Point(xD, yD);


            LoadExcelContents("DATA.bat");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            this.Cursor = Cursors.SizeAll;
        }

        private void pnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            this.Cursor = Cursors.Arrow;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (type == 1)
            {

                if (raisingHeight >= targetHeight)
                {
                    setPanelHeight(type);
                    timer1.Enabled = false;
                    raisingHeight = 0;
                }
                else
                {
                    raisingHeight += 20;
                    this.Height = raisingHeight;
                }
            }
            else
            {
                if (raisingHeight <= targetHeight)
                {
                    setPanelHeight(type);
                    timer1.Enabled = false;
                    raisingHeight = 0;
                }
                else
                {
                    raisingHeight -= 20;
                    this.Height = raisingHeight;
                }

            }

        }

        void setPanelHeight(int type)
        {
            switch (type)
            {
                case 1:
                    btExpand.Text = ".";
                    break;
                case 2:
                    btExpand.Text = "..";
                    break;
                default:
                    break;
            }
            pnInfo.BackgroundImageLayout = ImageLayout.Stretch;
            this.Height = targetHeight;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            About fr2 = new About();
            fr2.ShowDialog();
        }




        String luotDi = "";
        String luotVe = "";
        String soDi = "";
        String soVe = "";
        String place1 = "";
        String place2 = "";


        //
        // Load data  Excel
        //
        public DataTable LoadExcelContents(string fileName)
        {
            try
            {
                OleDbConnection ocon = new OleDbConnection();
                ocon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + fileName);
                string query = @"SELECT * FROM [DATA$]";
                ocon.Open();
                OleDbCommand cmd = new OleDbCommand(query, ocon);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);



                // load data  in textbox
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    reader.Read();
                    lblNo.Text = reader["No"].ToString();
                    lblName.Text = reader["Name"].ToString();
                    lblKM.Text = reader["KM"].ToString();
                    lblTime.Text = reader["Time"].ToString();
                    lblType.Text = reader["Type"].ToString();
                    lblStickN.Text = reader["Price"].ToString();
                    lblStickS.Text = reader["Student"].ToString();
                    lblOwner.Text = reader["Owner"].ToString();
                    lblStation1.Text = reader["Station1"].ToString();
                    lblStation2.Text = reader["Station2"].ToString();
                    lblTime1.Text = reader["Time1"].ToString();
                    lblTime2.Text = reader["Time2"].ToString();
                    lblGoBack.Text = reader["Meet1"].ToString();
                    lblName.Text = reader["Name"].ToString();
                    lblPlace.Text = reader["Place1"].ToString();
                    place1 = reader["Place1"].ToString();
                    place2 = reader["Place2"].ToString();
                    lblStreet.Text = reader["Street1"].ToString();
                    luotDi = reader["Place1"].ToString();
                    luotVe = reader["Place2"].ToString();
                    soDi = reader["Meet1"].ToString();
                    soVe = reader["Meet2"].ToString();
                }
                DataTable dt = ds.Tables[0];
                dataLoad.DataSource = dt.DefaultView;
                ocon.Close();
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Program  can't  read file" + ex.Message, "Please Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void timerRunText_Tick(object sender, EventArgs e)
        {
            // chạy  lblTuyen
            if (dric == 0) xT--;
            else if (dric == 1) yT++;
            else if (dric == 2) xT++;
            do
            // tọa độ lblTuyen  từ lúc bắt đầu cho đến khi kết thúc
            {

                lblName.Location = new Point(xT, yT);
                if (xT == 400 && yT == 25) dric = 0;
                else if (xT == -1000 && yT == 25) xT = 400;


            } while (xT == -1000);

            // chạy  lblDiVe
            if (dv == 0) xD--;
            else if (dv == 1) yD++;
            else if (dv == 2) xD++;


            // tọa độ lblDi, lblVe từ lúc bắt đầu cho đến khi kết thúc


            lblPlace.Location = new Point(xD, yD);

            if (xD == -500 && yD == 25) dric = 0;
            else if (xD == -750 && yD == 25) xD = -500;


        }



        private void btnGoN_Click(object sender, EventArgs e)
        {
            lblGoBack.Text = soDi;
            btnBackN.ForeColor = System.Drawing.Color.Khaki;
            btnBackN.BackColor = System.Drawing.Color.Gray;
            btnGoN.ForeColor = System.Drawing.Color.Gold;
            btnGoN.BackColor = System.Drawing.Color.Black;

        }

        private void btnTGo_Click(object sender, EventArgs e)
        {
            // toa độ
            xD = -510;
            timerRunText.Interval = 1;
            timerRunText.Start();
            lblPlace.Location = new Point(xD, yD);

            lblStreet.Text = luotDi;
            lblPlace.Text = luotDi;
            btnBackT.ForeColor = System.Drawing.Color.Khaki;
            btnBackT.BackColor = System.Drawing.Color.Gray;
            btnTGo.ForeColor = System.Drawing.Color.Gold;
            btnTGo.BackColor = System.Drawing.Color.Black;


        }

        private void btnBackT_Click(object sender, EventArgs e)
        {
            //tọa độ
            xD = -510;
            timerRunText.Interval = 1;
            timerRunText.Start();
            lblPlace.Location = new Point(xD, yD);

            lblStreet.Text = luotVe;
            lblPlace.Text = luotVe;
            btnTGo.ForeColor = System.Drawing.Color.Khaki;
            btnTGo.BackColor = System.Drawing.Color.Gray;
            btnBackT.ForeColor = System.Drawing.Color.Gold;
            btnBackT.BackColor = System.Drawing.Color.Black;
        }

        private void btnBackN_Click(object sender, EventArgs e)
        {
            lblGoBack.Text = soVe;
            btnBackN.ForeColor = System.Drawing.Color.Gold;
            btnBackN.BackColor = System.Drawing.Color.Black;
            btnGoN.ForeColor = System.Drawing.Color.Khaki;
            btnGoN.BackColor = System.Drawing.Color.Gray;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataLoad.DataSource;
            bs.Filter = "[No]=" + "'" + txtSearch.Text + "'";
            dataLoad.DataSource = bs;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                xD = -500;
                timerRunText.Interval = 1;
                timerRunText.Start();
                lblPlace.Location =new Point(xD,yD);
                btnSearch.PerformClick();
                lblPlace.Text = luotDi;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private int dong;
        private int cot;
        private void dataLoad_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            cot = e.ColumnIndex;
            lblNo.Text = dataLoad["No", dong].Value.ToString();
            lblName.Text = dataLoad["Name", dong].Value.ToString();
            lblStation1.Text = dataLoad["Station1", dong].Value.ToString();
            lblStation2.Text = dataLoad["Station2", dong].Value.ToString();
            lblTime1.Text = dataLoad["Time1", dong].Value.ToString();
            lblTime2.Text = dataLoad["Time2", dong].Value.ToString();
            lblPlace.Text=dataLoad["Place1",dong].Value.ToString();
            place1 = dataLoad["Place1", dong].Value.ToString();
            place2 = dataLoad["Place2", dong].Value.ToString();
            lblStreet.Text = dataLoad["Street1", dong].Value.ToString();
            luotDi = dataLoad["Street1", dong].Value.ToString();
            luotVe = dataLoad["Street2", dong].Value.ToString();
            lblKM.Text = dataLoad["KM", dong].Value.ToString();
            lblTime.Text = dataLoad["Time", dong].Value.ToString();
            lblType.Text = dataLoad["Type", dong].Value.ToString();
            lblOwner.Text = dataLoad["Owner", dong].Value.ToString();
            lblStickN.Text = dataLoad["Price", dong].Value.ToString();
            lblStickS.Text = dataLoad["Student", dong].Value.ToString();
            lblGoBack.Text = dataLoad["Meet1", dong].Value.ToString();
            soVe = dataLoad["Meet2", dong].Value.ToString();
            soDi = dataLoad["Meet1", dong].Value.ToString();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

       
     
    }
}
