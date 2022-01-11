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
using QLNH.GUI_QLNH.GUI_QL;

namespace QLNH.GUI_QLNH.GUI_NV
{
    public partial class frm_NhanVien : Form
    {
        ChamCong_DAL chamcong = new ChamCong_DAL();
        NhanVien_DAL nhanvien = new NhanVien_DAL();
        public frm_NhanVien()
        {
            InitializeComponent();
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
        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            frm_BanHang ban = new frm_BanHang();
            ban.ShowDialog();
        }

        private void btn_LichLam_Click(object sender, EventArgs e)
        {
            frm_LichLamViec vc = new frm_LichLamViec();
            vc.ShowDialog();
            
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

        private void llb_EditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DoiPass dp = new frm_DoiPass();
            dp.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                lb_CheckOut.Text = "Bạn cần check out trước: " + h + " giờ " + (m + 10);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Date.Text = DateTime.Now.ToLongDateString();
            lb_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            lb_Name.Text = User.HoTen;
            MemoryStream picture = new MemoryStream(User.Anh);
            ptb_Picture.Image = Image.FromStream(picture);
            timer1.Start();
            CheckCheckIn();
            CheckCheckOut();
        }

        private void tbt_CheckIn_Click(object sender, EventArgs e)
        {
            ChamCong_DAL cc = new ChamCong_DAL();
            DataTable tb = cc.CheckGioVao();
            if (CheckCheckIn() == 1)
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
    }
}
