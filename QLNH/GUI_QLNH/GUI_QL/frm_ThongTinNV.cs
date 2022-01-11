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
    public partial class frm_ThongTinNV : Form
    {
        NhanVien_DAL nhanvien = new NhanVien_DAL();
        string imgloc = "";
        string gender = string.Empty;
        PictureBox pic = new PictureBox();
        public frm_ThongTinNV()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            DataTable tb = nhanvien.GetAllMaNV();
            cbb_MaNV.DataSource = tb;
            cbb_MaNV.DisplayMember = "MaNV";
            cbb_MaNV.ValueMember = "MaNV";
        }
        private void frm_ThongTinNV_Load(object sender, EventArgs e)
        {
            
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

        private void cbb_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            try
            {
                int id = int.Parse(cbb_MaNV.Text);
                DataTable tb = nhanvien.GetNhanVien((int)id);
                if (tb.Rows.Count > 0)
                {
                    tb_HoTen.Text = tb.Rows[0][2].ToString();
                    tb_SDT.Text = tb.Rows[0][4].ToString();
                    if (tb.Rows[0][3].ToString() == "Nam")
                    {
                        rbt_Male.Checked = true;
                    }
                    else
                    {
                        rbt_Female.Checked = true;
                    }
                    dtp_NgaySinh.Value = (DateTime)tb.Rows[0][5];
                    rtb_Diachi.Text = tb.Rows[0][6].ToString();
                    byte[] pic = (byte[])tb.Rows[0][7];
                    MemoryStream picture = new MemoryStream(pic);
                    ptb_Picture.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not found! ", "Find Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Quản lý thông tin");
            }
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
            else
            {
                return true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                MemoryStream img = new MemoryStream();
                ptb_Picture.Image.Save(img, System.Drawing.Imaging.ImageFormat.Jpeg);
                NhanVien nv = new NhanVien();
                nv.MaNV = int.Parse(cbb_MaNV.Text);
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
                if (nhanvien.UpdateNhanVien(nv) == true)
                {
                    MessageBox.Show("Đã sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cbb_MaNV.Text);
            if (MessageBox.Show("Xóa nhân viên", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (nhanvien.DeleteNhanVien(id) == true)
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Message", MessageBoxButtons.OK);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Không xóa được nhân viên này, Vui lòng thử lại sau!", "Message", MessageBoxButtons.OK);
                }
            }
        }
    }
}
