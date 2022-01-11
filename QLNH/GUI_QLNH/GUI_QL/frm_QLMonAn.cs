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
    public partial class frm_QLMonAn : Form
    {
        string monan = "Tất cả";
        public frm_QLMonAn()
        {
            InitializeComponent();
            List<string> mon = new List<string>();
            mon.Add("Khai vị");
            mon.Add("Chính");
            mon.Add("Tráng miệng");
            mon.Add("Đồ uống");
            mon.Add("Tất cả");
            cbb_PhanLoai.DataSource = mon;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddMonAn_Click(object sender, EventArgs e)
        {
            frm_AddAndEditMonAn ma = new frm_AddAndEditMonAn();
            ma.cbb_MaMonAn.Visible = false;
            ma.lb1.Visible = false;
            ma.cbb_PhanLoai.Text = string.Empty;
            ma.btn_Delete.Visible = false;
            ma.btn_Update.Visible = false;
            ma.ShowDialog();
        }

        private void cbb_PhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cl = sender as ComboBox;
            if (cl.SelectedItem != null)
            {
                monan = cl.SelectedItem.ToString();
            }
            DataTable tb = new DataTable();
            MonAn_DAL ma = new MonAn_DAL();
            tb = ma.GetAllMonAnByPhanLoai(monan);
            dgv_MonAn.DataSource = tb;
            dgv_MonAn.ReadOnly = true;
        }

        private void frm_QLMonAn_Load(object sender, EventArgs e)
        {
            cbb_PhanLoai.Text = "Tất cả";
            DataTable tb = new DataTable();
            MonAn_DAL ma = new MonAn_DAL();
            tb = ma.GetAllMonAn();
            dgv_MonAn.DataSource = tb;
            dgv_MonAn.ReadOnly = true;
            for (int i = 0; i < dgv_MonAn.Columns.Count; i++)
            {
                if (dgv_MonAn.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgv_MonAn.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
        }
    }
}
