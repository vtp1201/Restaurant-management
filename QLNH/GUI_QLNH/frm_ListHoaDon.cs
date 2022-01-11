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

namespace QLNH.GUI_QLNH
{
    public partial class frm_ListHoaDon : Form
    {
        int macl = 0;
        public int MaCL { get { return macl; } set { macl = value; } }
        public frm_ListHoaDon()
        {
            InitializeComponent();
        }
        public void frm_Load()
        {
            if (macl == 0)
            {
                MessageBox.Show("Không nằm trong thời gian ca làm việc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDon_DAL hd = new HoaDon_DAL();
                DataTable tb = new DataTable();
                tb = hd.GetHoaDonByMaCL(macl);
                LoadListHoaDon(tb);
            }
        }
        public delegate void GETFullListHoaDon(int mahd);
        public GETFullListHoaDon FullListHoaDon;
        public void GetList_HoaDon(int value)
        {
            FullListHoaDon(value);
        }
        private void LoadListHoaDon(DataTable tb)
        {
            flp_ListMonAn.Controls.Clear();
            List_HoaDon[] list = new List_HoaDon[tb.Rows.Count];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new List_HoaDon();
                list[i].MaCL = macl;
                list[i].MaHD = int.Parse(tb.Rows[i][0].ToString());
                list[i].frm_Load();
                list[i].ListHoaDon = new List_HoaDon.GETListHoaDon(GetList_HoaDon);
                if (flp_ListMonAn.Controls.Count < 0)
                {
                    flp_ListMonAn.Controls.Clear();
                }
                else
                {
                    flp_ListMonAn.Controls.Add(list[i]);
                }
            }
        }
        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            if (macl == 0)
            {
                MessageBox.Show("Không nằm trong thời gian ca làm việc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDon_DAL hd = new HoaDon_DAL();
                DataTable tb = new DataTable();
                tb = hd.GetHoaDonByMaCLAndHoantat(macl);
                LoadListHoaDon(tb);
            }
        }

        private void btn_TatCa_Click(object sender, EventArgs e)
        {
            frm_Load();
        }

        private void btn_DaThanhToan_Click(object sender, EventArgs e)
        {
            if (macl == 0)
            {
                MessageBox.Show("Không nằm trong thời gian ca làm việc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDon_DAL hd = new HoaDon_DAL();
                DataTable tb = new DataTable();
                tb = hd.GetHoaDonByMaCLAndChuaThanhToan(macl);
                LoadListHoaDon(tb);
            }
            
        }
        private void btn_ChuaThanhToan_Click(object sender, EventArgs e)
        {
            if (macl == 0)
            {
                MessageBox.Show("Không nằm trong thời gian ca làm việc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDon_DAL hd = new HoaDon_DAL();
                DataTable tb = new DataTable();
                tb = hd.GetHoaDonByMaCLAndThanhToan(macl);
                LoadListHoaDon(tb);
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (macl == 0 || cbb_Ban.Text == "Bàn đang có người")
            {
                MessageBox.Show("Không thểm tìm được", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDon_DAL hd = new HoaDon_DAL();
                DataTable tb = new DataTable();
                tb = hd.GetHoaDonByMaCLAndChuaThanhToan(macl);
                LoadListHoaDon(tb);
            }
        }
    }
}
