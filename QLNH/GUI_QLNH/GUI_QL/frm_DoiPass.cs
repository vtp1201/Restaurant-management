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

namespace QLNH.GUI_QLNH.GUI_QL
{
    public partial class frm_DoiPass : Form
    {
        public frm_DoiPass()
        {
            InitializeComponent();
            InitializeMyControl();
        }
        private void InitializeMyControl()
        {
            // Set to no text.
            tb_MatKhau.Text = "";
            // The password character is an asterisk.
            tb_MatKhau.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            tb_MatKhau.MaxLength = 14;
            tb_MKMoi.Text = "";
            tb_NhapLai.Text = "";
            tb_MKMoi.PasswordChar = '*';
            tb_NhapLai.PasswordChar = '*';
        }

        private void ibtn_DoiPass_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            LogIn_DAL li = new LogIn_DAL();
            tb = li.GetUsernameAndPass();
            if (Check() == true)
            {
                if (tb_MatKhau.Text == tb.Rows[0][2].ToString())
                {
                    if (tb_MKMoi.Text == tb_NhapLai.Text)
                    {
                        if (li.UpdatePass(tb_MKMoi.Text) == true)
                        {
                            MessageBox.Show("Đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại mật khẩu mới không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }         
        }

        private void frm_DoiPass_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            LogIn_DAL li = new LogIn_DAL();
            tb = li.GetUsernameAndPass();
            tb_TenDangNhap.Text = tb.Rows[0][1].ToString();
            tb_TenDangNhap.ReadOnly = true;
        }
        public bool Check()
        {
            if (string.IsNullOrEmpty(tb_MatKhau.Text))
            {
                MessageBox.Show("Nhập mật khẩu hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MatKhau.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tb_MKMoi.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MKMoi.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tb_NhapLai.Text))
            {
                MessageBox.Show("Chưa nhập lại mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_NhapLai.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
