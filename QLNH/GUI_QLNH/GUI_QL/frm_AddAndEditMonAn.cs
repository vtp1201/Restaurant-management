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
    public partial class frm_AddAndEditMonAn : Form
    {
        string imgloc = "";
        PictureBox pic = new PictureBox();
        public frm_AddAndEditMonAn()
        {
            InitializeComponent();
            List<string> mon = new List<string>();
            mon.Add("Khai vị");
            mon.Add("Chính");
            mon.Add("Tráng miệng");
            mon.Add("Đồ uống");
            cbb_PhanLoai.DataSource = mon;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                MonAn_DAL monan = new MonAn_DAL();
                MemoryStream img = new MemoryStream();
                ptb_Picture.Image.Save(img, System.Drawing.Imaging.ImageFormat.Jpeg);
                MonAn ma = new MonAn();
                ma.MaMonAn = int.Parse(cbb_MaMonAn.Text);
                ma.TenMonAn = tb_TenMonAn.Text;
                ma.Gia = int.Parse(tb_Gia.Text);
                ma.Description = rtb_Description.Text;
                ma.Anh = img.ToArray();
                ma.PhanLoai = cbb_PhanLoai.Text;
                if (monan.UpdateMonAn(ma) == true)
                {
                    MessageBox.Show("Đã thêm thông tin món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        public bool Check()
        {
            if (string.IsNullOrEmpty(tb_TenMonAn.Text))
            {
                MessageBox.Show("Nhập tên món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_TenMonAn.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(ptb_Picture.Image.ToString()))
            {
                MessageBox.Show("Hãy chọn ảnh cho món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ptb_Picture.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tb_Gia.Text))
            {
                MessageBox.Show("Nhập giá món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Gia.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(cbb_PhanLoai.Text))
            {
                MessageBox.Show("Chọn loại món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_PhanLoai.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(rtb_Description.Text))
            {
                MessageBox.Show("Nhập mô tả món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtb_Description.Focus();
                return false;
            }
            else
            {
                return true;
            }
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                MonAn_DAL monan = new MonAn_DAL();
                MemoryStream img = new MemoryStream();
                ptb_Picture.Image.Save(img, System.Drawing.Imaging.ImageFormat.Jpeg);
                MonAn ma = new MonAn();
                ma.TenMonAn = tb_TenMonAn.Text;
                ma.Gia = int.Parse(tb_Gia.Text);
                ma.Description = rtb_Description.Text;
                ma.Anh = img.ToArray();
                ma.PhanLoai = cbb_PhanLoai.Text;
                if (monan.InsertMonAN(ma) == true)
                {
                    MessageBox.Show("Đã thêm thông tin món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MonAn_DAL monan = new MonAn_DAL();
            int id = int.Parse(cbb_MaMonAn.Text);
            if (MessageBox.Show("Xóa món ăn ?", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (monan.DeleteMonAn(id) == true)
                {
                    MessageBox.Show("Xóa món ăn thành công", "Message", MessageBoxButtons.OK);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Không xóa được món ăn này, Vui lòng thử lại sau!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void cbb_MaMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            try
            {
                MonAn_DAL monan = new MonAn_DAL();
                int id = int.Parse(cbb_MaMonAn.Text);
                DataTable tb = monan.GetMonAnByMaMonAn(id);
                if (tb.Rows.Count > 0)
                {
                    tb_TenMonAn.Text = tb.Rows[0][1].ToString();
                    cbb_PhanLoai.Text = tb.Rows[0][2].ToString();
                    tb_Gia.Text = tb.Rows[0][3].ToString() + "đ";
                    rtb_Description.Text = tb.Rows[0][4].ToString();
                    byte[] pic = (byte[])tb.Rows[0][5];
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
    }
}
