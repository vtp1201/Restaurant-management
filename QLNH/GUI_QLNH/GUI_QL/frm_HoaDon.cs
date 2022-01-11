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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
            frm_load();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            frm_load();
        }
        private void frm_load()
        {
            DataTable tb = new DataTable();
            HoaDon_DAL hoadon = new HoaDon_DAL();
            tb = hoadon.GetALLHoaDonByMaCL(DTP_Ngay.Value.ToString("yyyy-MM-dd"));
            dgv_CaLam.DataSource = tb;
            dgv_CaLam.ReadOnly = true;
            int SL = 0;
            int Dt = 0;
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                SL = SL + 1;
                if (string.IsNullOrEmpty(tb.Rows[i][2].ToString()) == false)
                {
                    Dt = Dt + int.Parse(tb.Rows[i][2].ToString());
                }
            }
            tb_SoLuong.Text = SL.ToString() + " hóa đơn";
            tb_.Text = Dt.ToString("#,##0") + " VND";
            tb_SoLuong.ReadOnly = true;
            tb_.ReadOnly = true;
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
