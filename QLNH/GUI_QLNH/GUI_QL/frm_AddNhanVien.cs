using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Timers;
using QLNH.DAL_QLNH;
using QLNH.DTO_QLNH;

namespace QLNH.GUI_QLNH.GUI_QL
{
    public partial class frm_AddNhanVien : Form
    {
        NhanVien_DAL nhanvien = new NhanVien_DAL();
        string imgloc = "";
        string gender = string.Empty;
        PictureBox pic = new PictureBox();
        public frm_AddNhanVien()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG File (*.jpg)|*.jpg|GIFFiles (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Student picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb_Picture.Image = Image.FromFile(dlg.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbt_Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbt_Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
        public bool Check()
        {
            if (string.IsNullOrEmpty(tb_HoTen.Text))
            {
                MessageBox.Show("Nhập họ tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_HoTen.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(ptb_Picture.Image.ToString()))
            {
                MessageBox.Show("Hãy chọn ảnh cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ptb_Picture.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(dtp_NgaySinh.Value.ToString()))
            {
                MessageBox.Show("Chọn ngày sinh cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_NgaySinh.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(rtb_Diachi.Text))
            {
                MessageBox.Show("Nhập địa chỉ của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtb_Diachi.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tb_SDT.Text))
            {
                MessageBox.Show("Nhập số điện thoại nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SDT.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tb_UserName.Text))
            {
                MessageBox.Show("Nhập tên đăng nhập nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SDT.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tb_Pass.Text))
            {
                MessageBox.Show("Nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SDT.Focus();
                return false;
            }
            else if (tb_Pass.Text != tb_RePass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trung khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SDT.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                MemoryStream img = new MemoryStream();
                ptb_Picture.Image.Save(img, System.Drawing.Imaging.ImageFormat.Jpeg);
                NhanVien nv = new NhanVien();
                nv.HoTen = tb_HoTen.Text;
                if (gender == "Male")
                {
                    nv.GioiTinh = "Nam";
                }
                else
                {
                    nv.GioiTinh = "Nữ";
                }
                nv.SDT = tb_SDT.Text;
                nv.DiaChi = rtb_Diachi.Text;
                nv.NgaySinh = (DateTime)dtp_NgaySinh.Value;
                nv.Anh = img.ToArray();
                nv.UserName = tb_UserName.Text;
                nv.PassWord = tb_Pass.Text;
                if (nhanvien.InsertNhanVien(nv) == true)
                {
                    MessageBox.Show("Đã thêm thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }    
        }
    }
}
