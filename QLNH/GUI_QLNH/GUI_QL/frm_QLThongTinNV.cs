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

namespace QLNH.GUI_QLNH.GUI_QL
{
    public partial class frm_QLThongTinNV : Form
    {
        public frm_QLThongTinNV()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_ThongTinNV qlnv = new frm_ThongTinNV();
            qlnv.lb_MaNV.Visible = false;
            qlnv.cbb_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            qlnv.tb_HoTen.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
            if (dgv_NhanVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                qlnv.rbt_Male.Checked = true;
            }
            else
            {
                qlnv.rbt_Female.Checked = true;
            }
            qlnv.tb_SDT.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
            qlnv.dtp_NgaySinh.Value = (DateTime)dgv_NhanVien.CurrentRow.Cells[5].Value;
            qlnv.rtb_Diachi.Text = dgv_NhanVien.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dgv_NhanVien.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            qlnv.ptb_Picture.Image = Image.FromStream(picture);
            qlnv.Show();
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            frm_AddNhanVien add = new frm_AddNhanVien();
            add.rbt_Male.Checked = false;
            add.rbt_Female.Checked = false;
            add.Show();
        }

        private void btn_UpdateNV_Click(object sender, EventArgs e)
        {
            NhanVien_DAL nv = new NhanVien_DAL();
            DataTable tb = new DataTable();
            tb = nv.GetAllNhanVien();
            dgv_NhanVien.DataSource = tb;
            dgv_NhanVien.ReadOnly = true;
        }
    }
}
