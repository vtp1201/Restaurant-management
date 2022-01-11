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
    public partial class frm_Luong : Form
    {
        ChamCong_DAL chamcong = new ChamCong_DAL();
        public frm_Luong()
        {
            InitializeComponent();
            DataTable tb = new DataTable();
            tb = chamcong.GetTienLuong(DTP_Ngay.Value.ToString("yyyy-MM-dd"));
            dgv_CaLam.DataSource = tb;
            dgv_CaLam.ReadOnly = true;
        }
        private void frm_load()
        {
            string ngay = DTP_Ngay.Value.ToString("yyyy-MM-dd");
            DataTable tb = new DataTable();
            tb = chamcong.GetTienLuong(DTP_Ngay.Value.ToString("yyyy-MM-dd"));
            dgv_CaLam.DataSource = tb;
            dgv_CaLam.ReadOnly = true;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string ngay = DTP_Ngay.Value.ToString("yyyy-MM-dd");
            DataTable tb = new DataTable();
            tb = chamcong.GetTienLuong(DTP_Ngay.Value.ToString("yyyy-MM-dd"));
            dgv_CaLam.DataSource = tb;
            dgv_CaLam.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            frm_load();
        }
    }
}
