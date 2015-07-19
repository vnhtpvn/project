using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationBusShowv1._1
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //=================================================== link fb==============================================================
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/H6.INFO");

        }
        //===================================================== UI simple===========================================================
        private void lblHTP_Click(object sender, EventArgs e)
        {
            lblHTP.Font = new Font("Arial", 10);
            lblHTP.Text = "05.05.1994 | 0932.101625 05.htp.05@gmail.com ";
        }

        private void lblH6_Click(object sender, EventArgs e)
        {
            lblH6.Font = new Font("Arial", 10);
            lblH6.Text = "15.05.1994 | 0937.983072 tuannh27@gmail.com";
        }

        private void lblHTP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblHTP.Font = new Font("Arial", 14);
            lblHTP.Text = "HUỲNH TẤN PHÚC";
        }

        private void lblH6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblH6.Font = new Font("Arial", 14);
            lblH6.Text = "NGUYỄN HOÀNG TUẤN";
        }

        // ==============================================move UI============================================
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void pnAbout_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            this.Cursor = Cursors.Arrow;
        }

        private void pnAbout_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnAbout_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            this.Cursor = Cursors.SizeAll;
        }

        //=========================================== run text ============================================================
        int xT = 40, yT = 8, dric = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text = "TRẦN PHÚC ANH - LÊ HỮU ĐỨC - CAO THỊ GIANG - ĐẶNG THỊ HƯƠNG LAN - NGUYỄN ĐỨC MẠNH - NGUYỄN VĂN THẾ MỸ - NGÔ QUANG HẢI NGUYỆN - MAI THỊ KIM OANH - LÊ NAM PHƯƠNG - HUỲNH THỊ BÍCH PHƯỢNG - MAI THẾ QUÂN - LÊ HÙNG SƠN - LÊ DUY PHÁT TÀI - NGUYỄN THỊ THỦY TUYÊN - NGUYỄN THỊ MINH TRANG - NGUYỄN ĐÌNH TÙNG - NÔNG NGỌC VINH";
            lblName.Location = new Point(xT, yT);
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dric == 0) xT--;
            else if (dric == 1) yT++;
            else if (dric == 2) xT++;

            // tọa độ lblTuyen  từ lúc bắt đầu cho đến khi kết thúc


            lblName.Location = new Point(xT, yT);
            if (xT == 40 && yT == 25) dric = 0;
            else if (xT == -917 && yT == 25) xT = 40;



        }

        private void pnAbout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
