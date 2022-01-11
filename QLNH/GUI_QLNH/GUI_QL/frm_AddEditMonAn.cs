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

namespace QLNH.GUI_QLNH.GUI_QL
{
    public partial class frm_AddEditMonAn : Form
    {
        public frm_AddEditMonAn()
        {
            InitializeComponent();
            cbb_TenCa.Enabled = true;
            dtp_Ngay.Enabled = true;
            tb_MaCl.ReadOnly = true;
            tb_MaMonAn.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_AddEditMonAn_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MonAnCaLam_DAL ma = new MonAnCaLam_DAL();
            MonAnCaLam mon = new MonAnCaLam();
            if (check() == true)
            {
                mon.MaCL = int.Parse(tb_MaCl.Text);
                mon.MaMonAn = int.Parse(tb_MaMonAn.Text);
                mon.SoLuong = int.Parse(tb_SoLuong.Text);
                if (ma.InsertMonANCaLam(mon) == true)
                {
                    MessageBox.Show("Đã thêm " + tb_TenMonAn.Text + " vào ca làm thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }    
        }
        private bool check()
        {
            if (string.IsNullOrEmpty(tb_SoLuong.Text))
            {
                MessageBox.Show("Chọn số lượng ghế !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SoLuong.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
