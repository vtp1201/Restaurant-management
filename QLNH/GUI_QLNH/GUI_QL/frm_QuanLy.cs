using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNH.DAL_QLNH;
using QLNH.DTO_QLNH;

namespace QLNH.GUI_QLNH.GUI_QL
{
    public partial class frm_QuanLy : Form
    {
        ChamCong_DAL chamcong = new ChamCong_DAL();
        NhanVien_DAL nhanvien = new NhanVien_DAL();
        public frm_QuanLy()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btn_QuanLyCaLam_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frm_QLThongTinNV qlnv = new frm_QLThongTinNV();
            DataTable tb = nhanvien.GetAllNhanVien();
            qlnv.dgv_NhanVien.DataSource = tb;
            qlnv.dgv_NhanVien.ReadOnly = true;
            openChildForm(qlnv);
        }

        #region MediaSubMenu
        private void btn_MonAn_CaLam_Click(object sender, EventArgs e)
        {
            frm_MonAnCaLam mon = new frm_MonAnCaLam();
            openChildForm(mon);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btn_Ban_CaLam_Click(object sender, EventArgs e)
        {
            frm_QLBanCaLamcs cl = new frm_QLBanCaLamcs();
            openChildForm(cl);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btn_NhanVien_CaLam_Click(object sender, EventArgs e)
        {
            frm_CaLam cl = new frm_CaLam();
            cl.DTP_Ngay.Value = DateTime.Now;
            string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            DataTable tb = chamcong.GetAllCVByDay(ngay);
            cl.dgv_CaLam.DataSource = tb;
            cl.dgv_CaLam.ReadOnly = true;
            openChildForm(cl);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        #endregion

        private void btn_QuanLyNhaHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void btn_MonAn_Click(object sender, EventArgs e)
        {
            frm_QLMonAn f3 = new frm_QLMonAn();
            openChildForm(f3);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btn_Ban_Click(object sender, EventArgs e)
        {
            frm_QLBan ban = new frm_QLBan();
            openChildForm(ban);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            frm_HoaDon hoa = new frm_HoaDon();
            openChildForm(hoa);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ThongKe th = new frm_ThongKe();
            openChildForm(th);
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion
        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            frm_BanHang ban = new frm_BanHang();
            ban.ShowDialog();
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            frm_Login lo = new frm_Login();
            lo.ShowDialog();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frm_QuanLy_Load(object sender, EventArgs e)
        {
            lb_Name.Text = User.HoTen;
            MemoryStream picture = new MemoryStream(User.Anh);
            ptb_Picture.Image = Image.FromStream(picture);
            timer1.Start();
            CheckCheckIn();
            CheckCheckOut();
            //ChamCong_DAL cc = new ChamCong_DAL();
            //DataTable tb = cc.CheckGioVao();
            //TimeSpan time = (TimeSpan)tb.Rows[0][5];
            //string now = DateTime.Now.ToString("HH:mm");
            //TimeSpan time2 = TimeSpan.Parse(now);
            //int i = int.Parse(time.Hours.ToString());
            //lb_CheckIn.Text = (time - time2).ToString();
            //lb_CheckOut.Text = i.ToString();
        }

        private int CheckCheckIn()
        {
            ChamCong_DAL cc = new ChamCong_DAL();
            DataTable tb = cc.CheckGioVao();
            if (tb.Rows.Count == 0)
            {
                lb_CheckIn.Text = "Hôm nay bạn không còn ca làm việc nào nữa";
                return 0;
            }
            else
            {
                TimeSpan time = (TimeSpan)tb.Rows[0][4];
                string now = DateTime.Now.AddMinutes(10).ToString("HH:mm");
                TimeSpan time2 = TimeSpan.Parse(now);
                int h = int.Parse(time.Hours.ToString());
                int m = int.Parse(time.Minutes.ToString());
                lb_CheckIn.Text = "Bạn cần check in vào sau: " + (h - 1) + " giờ " + (m + 50);
                if (time <= time2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }    
            }
        }
        private int CheckCheckOut()
        {
            ChamCong_DAL cc = new ChamCong_DAL();
            DataTable tb = cc.CheckGioRa();
            if (tb.Rows.Count == 0)
            {
                lb_CheckOut.Text = "Bạn hiện không trong ca làm việc nào";
                return 0;
            }
            else
            {
                TimeSpan time = (TimeSpan)tb.Rows[0][5];
                string now = DateTime.Now.AddMinutes(10).ToString("HH:mm");
                TimeSpan time2 = TimeSpan.Parse(now);
                int h = int.Parse(time.Hours.ToString());
                int m = int.Parse(time.Minutes.ToString());
                lb_CheckOut.Text = "Bạn cần check out trước: " + h  + " giờ " + (m + 10);
                if (time >= time2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        private void llb_EditTT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ThongTinNV tt = new frm_ThongTinNV();
            tt.cbb_MaNV.Text = User.MaNV.ToString();
            tt.cbb_MaNV.Visible = false;
            tt.lb_MaNV.Text = User.MaNV.ToString();
            tt.lb_TieuDe.Text = "Chỉnh sửa thông tin cá nhân";
            NhanVien_DAL nv = new NhanVien_DAL();
            DataTable tb = nv.GetNhanVien(User.MaNV);
            tt.tb_HoTen.Text = tb.Rows[0][2].ToString();
            tt.tb_SDT.Text = tb.Rows[0][4].ToString();
            if (tb.Rows[0][3].ToString() == "Nam")
            {
                tt.rbt_Male.Checked = true;
            }
            else
            {
                tt.rbt_Female.Checked = true;
            }
            tt.dtp_NgaySinh.Value = (DateTime)tb.Rows[0][5];
            tt.rtb_Diachi.Text = tb.Rows[0][6].ToString();
            byte[] pic = (byte[])tb.Rows[0][7];
            MemoryStream picture = new MemoryStream(pic);
            tt.ptb_Picture.Image = Image.FromStream(picture);
            tt.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Date.Text = DateTime.Now.ToLongDateString();
            lb_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void tbt_CheckIn_Click(object sender, EventArgs e)
        {
            ChamCong_DAL cc = new ChamCong_DAL();
            DataTable tb = cc.CheckGioVao();
            if(CheckCheckIn() == 1)
            {
                string now = DateTime.Now.ToString("HH:mm");
                TimeSpan time = TimeSpan.Parse(now);
                ChamCong chamcong = new ChamCong();
                chamcong.MaNV = int.Parse(tb.Rows[0][0].ToString());
                chamcong.MaCL = int.Parse(tb.Rows[0][1].ToString());
                chamcong.CheckIn = DateTime.Now;
                if (cc.CheckIN(chamcong) == true)
                {
                    MessageBox.Show("Đã check in thành công vào lúc: " + DateTime.Now.ToLongTimeString(), "Thông báo", MessageBoxButtons.OK);
                    CheckCheckIn();
                    CheckCheckOut();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Không nằm trong thời gian CheckIn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }    
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ChamCong_DAL cc = new ChamCong_DAL();
            DataTable tb = cc.CheckGioRa();
            if (CheckCheckOut() == 1)
            {
                string now = DateTime.Now.ToString("HH:mm");
                TimeSpan time = TimeSpan.Parse(now);
                ChamCong chamcong = new ChamCong();
                chamcong.MaNV = int.Parse(tb.Rows[0][0].ToString());
                chamcong.MaCL = int.Parse(tb.Rows[0][1].ToString());
                chamcong.CheckOut = DateTime.Now;
                if (cc.CheckOut(chamcong) == true)
                {
                    MessageBox.Show("Đã check out thành công vào lúc: " + DateTime.Now.ToLongTimeString(), "Thông báo", MessageBoxButtons.OK);
                    CheckCheckIn();
                    CheckCheckOut();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Không nằm trong thời gian CheckOut", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_TienLuong_CaLam_Click(object sender, EventArgs e)
        {
            frm_Luong luo = new frm_Luong();
            openChildForm(luo);
        }

        private void llb_EditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DoiPass dp = new frm_DoiPass();
            dp.ShowDialog();
        }
    }
}
