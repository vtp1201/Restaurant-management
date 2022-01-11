using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNH.DAL_QLNH;
using QLNH.DTO_QLNH;


namespace QLNH.GUI_QLNH
{
    public partial class List_HoaDon : UserControl
    {
        public Form Owner { get; }
        int mahoadon = 0;
        public int MaHD { get { return mahoadon; } set { mahoadon = value; } }
        int macl = 0;
        public int MaCL { get { return macl; } set { macl = value; } }
        public List_HoaDon()
        {
            InitializeComponent();
        }
        public void frm_Load()
        {
            DataTable tb = new DataTable();
            HoaDon_DAL hoa = new HoaDon_DAL();
            tb = hoa.GetHoaDonByMaHD(mahoadon);
            if (tb.Rows.Count > 0)
            {
                lb_SoHoaDon.Text = "Hóa đơn số: " + tb.Rows[0][0].ToString();
                lb_NgayMua.Text = "Ngày bán: " + DateTime.Now.ToString("dd/MM/yyyy") + "  " + ((TimeSpan)tb.Rows[0][2]).ToString();
                if (string.IsNullOrEmpty(tb.Rows[0][1].ToString()) == true)
                {
                    lb_Ban.Text = "Status: Chưa chọn bàn";
                }
                else
                {
                    lb_Ban.Text = "Bàn số: " + tb.Rows[0][1].ToString();
                }
                if (tb.Rows[0][10].ToString() == "Hoàn tất")
                {
                    this.BackColor = Color.PaleGreen;
                    lb_Status.Text = "Status: Hoàn tất";
                    if (string.IsNullOrEmpty(tb.Rows[0][1].ToString()) == true)
                    {
                        lb_Ban.Text = "Bàn số: Mua mang đi";
                    }    
                }
                else if (tb.Rows[0][10].ToString() == "Đã thanh toán")
                {
                    this.BackColor = Color.LightSkyBlue;
                    lb_Status.Text = "Status: Đã thanh toán";
                }
                else
                {
                    this.BackColor = Color.Plum;
                    lb_Status.Text = "Status: chưa thanh toán";
                }
                int tongtien = 0;
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if(string.IsNullOrEmpty(tb.Rows[0][9].ToString()) == false)
                    {
                        tongtien = tongtien + int.Parse(tb.Rows[0][9].ToString());
                    }    
                }
                lb_Tien.Text = "Giá trị: " + tongtien.ToString("#,##0") + "VND";
            }
        }
        public delegate void GETListHoaDon(int mahd);
        public GETListHoaDon ListHoaDon;

        private void button1_Click(object sender, EventArgs e)
        {
            ListHoaDon(mahoadon);
        }
    }
}
