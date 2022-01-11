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
    public partial class frm_ShowHoaDon : Form
    {
        int tongtien = 0;
        int mahoadon = 0;
        public int MaHD { get { return mahoadon; } set { mahoadon = value; } }
        int macl = 0;
        public int MaCL { get { return macl; } set { macl = value; } }
        public frm_ShowHoaDon()
        {
            InitializeComponent();
        }
        public void frm_Load()
        {
            btn_HoanTat.Text = "Hoàn tất";
            btn_ThanhToan.Text = "Thanh toán";
            DataTable tb = new DataTable();
            HoaDon_DAL hd = new HoaDon_DAL();
            tb = hd.GetHoaDonByMaHD(mahoadon);
            if (tb.Rows.Count > 0)
            { 
                lb_NgayBan.Text = "Ngày bán: "+ DateTime.Now.ToString("dd/MM/yyyy") + "  " + ((TimeSpan)tb.Rows[0][2]).ToString();
                
                lb_TenNV.Text = "NV: " + User.HoTen + " (" + User.MaNV + ")";
                if(tb.Rows[0][10].ToString() == "Hoàn tất")
                {
                    btn_ThanhToan.Visible = false;
                    btn_HoanTat.Visible = false;
                }    
                else if (tb.Rows[0][10].ToString() == "Đã thanh toán")
                {
                    btn_ThanhToan.Visible = false;
                }
                lv_DonMua.Clear();
                lv_DonMua.View = View.Details;
                lv_DonMua.Columns.Add("Tên món", 130);
                lv_DonMua.Columns.Add("Đơn giá", 100);
                lv_DonMua.Columns.Add("SL", 60);
                lv_DonMua.Columns.Add("T.Tiền", 110);
                tongtien = 0;
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(tb.Rows[i][6].ToString()) == false)
                    {
                        ListViewItem item = new ListViewItem(tb.Rows[i][6].ToString());
                        item.SubItems.Add((int.Parse(tb.Rows[i][8].ToString())).ToString("#,##0") + "VND");
                        item.SubItems.Add(tb.Rows[i][7].ToString());
                        item.SubItems.Add((int.Parse(tb.Rows[i][9].ToString())).ToString("#,##0") + "VND");
                        item.SubItems.Add(tb.Rows[i][5].ToString());
                        tongtien = tongtien + int.Parse(tb.Rows[i][9].ToString());
                        lv_DonMua.Items.Add(item);
                    }    
                }
                if (string.IsNullOrEmpty(tb.Rows[0][1].ToString()) == false)
                {
                    lb_TenBan.Text = "Bàn số: " + tb.Rows[0][1].ToString();
                }
                else if (string.IsNullOrEmpty(tb.Rows[0][1].ToString()) == true && tongtien == 0)
                {
                    lb_TenBan.Text = "Bàn số: Chưa xác định";
                }    
                else
                {
                    lb_TenBan.Text = "Bàn số: " + "Mua mang về";
                    btn_HoanTat.Text = "Thanh toán";
                    btn_ThanhToan.Visible = false;
                }
                ListViewItem it= new ListViewItem();
                it.SubItems.Add("Tổng tiền: ");
                it.SubItems.Add("");
                it.SubItems.Add(tongtien.ToString("#,##0") + "VND");
                lv_DonMua.Items.Add(it);
                gb_ThanhToan.Visible = false;
            }    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            HoaDon_DAL hd = new HoaDon_DAL();
            HoaDon hoa = new HoaDon();
            hoa.MaHoaDon = mahoadon;
            hoa.Status = "Đã thanh toán";
            hoa.TongTien = tongtien;
            if (hd.ThanhToanHoaDon(hoa) == true)
            {
                MessageBox.Show("Đã thanh toán thành công! ", "Message", MessageBoxButtons.OK);
                frm_Load();
            }  
            else
            {
                MessageBox.Show("Đã xảy ra lỗi! ", "Message", MessageBoxButtons.OK);
            }    
        }
        public delegate void GETShowhd(int mahd);
        public GETShowhd showhd;
        private void button5_Click(object sender, EventArgs e)
        {
            mahoadon = 0;
            showhd(mahoadon);
            this.Close();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            HoaDon_DAL hd = new HoaDon_DAL();
            tb = hd.GetHoaDonByMaHD(mahoadon);
            HoaDon hoa = new HoaDon();
            hoa.MaHoaDon = mahoadon;
            hoa.Status = "Hoàn tất";
            hoa.TongTien = tongtien;
            if (tb.Rows[0][10].ToString() == "Đã thanh toán")
            {
                if (hd.KetThucHoaDon(hoa) == true)
                {
                    MessageBox.Show("Đã kết thúc bàn thành công! ", "Message", MessageBoxButtons.OK);
                    frm_Load();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi! ", "Message", MessageBoxButtons.OK);
                }
            }    
            else
            {
                if (hd.KetThucHoaDon(hoa) == true)
                {
                    MessageBox.Show("Đã thanh toán thành công! ", "Message", MessageBoxButtons.OK);
                    frm_Load();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi! ", "Message", MessageBoxButtons.OK);
                }
            }    
        }
    }
}
