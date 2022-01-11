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
    public partial class frm_AddMonAn : Form
    {
        int mahoadon = 0;
        public int MaHD { get { return mahoadon; } set { mahoadon = value; } }
        int macl = 0;
        public int MaCL { get { return macl; } set { macl = value; } }
        public frm_AddMonAn()
        {
            InitializeComponent();
        }
        public void frm_Load()
        {
            if (macl == 0)
            {

            }
            else
            {
                MonAnCaLam_DAL monan = new MonAnCaLam_DAL();
                DataTable tb = new DataTable();
                tb = monan.GetAllMonAnByCaLam(macl);
                LoadListMonAn(tb);
            }    
        }
        public delegate void GETAddMonAn(int mahd);
        public GETAddMonAn addmonan;
        public void GetList_Mon(int value)
        {
            addmonan(mahoadon);
        }
        private void LoadListMonAn(DataTable tb)
        {
            flp_ListMonAn.Controls.Clear();
            List_Mon[] list = new List_Mon[tb.Rows.Count];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new List_Mon();
                list[i].MaCL = macl;
                list[i].MaHD = mahoadon;
                list[i].MaMonAn = int.Parse(tb.Rows[i][0].ToString());
                list[i].frm_Load();
                list[i].data = new List_Mon.GETDATA(GetList_Mon);
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

        private void btn_KhaiVi_Click(object sender, EventArgs e)
        {
            if (macl == 0)
            {
                MessageBox.Show("Không nằm trong thời gian ca làm việc", "Bán hàng Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                DataTable tb = new DataTable();
                MonAnCaLam_DAL monan = new MonAnCaLam_DAL();
                tb = monan.GetAllMonBymaclAndPhanLoai(macl, "Khai vị");
                LoadListMonAn(tb);
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (macl == 0)
            {
                MessageBox.Show("Không nằm trong thời gian ca làm việc", "Bán hàng Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable tb = new DataTable();
                MonAnCaLam_DAL monan = new MonAnCaLam_DAL();
                tb = monan.GetAllMonBymaclAndPhanLoai(macl, "Chính");
                LoadListMonAn(tb);
            }
        }

        private void btn_TrangMieng_Click(object sender, EventArgs e)
        {
            if (macl == 0)
            {
                MessageBox.Show("Không nằm trong thời gian ca làm việc", "Bán hàng Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable tb = new DataTable();
                MonAnCaLam_DAL monan = new MonAnCaLam_DAL();
                tb = monan.GetAllMonBymaclAndPhanLoai(macl, "Tráng miệng");
                LoadListMonAn(tb);
            }
        }

        private void btn_DoUong_Click(object sender, EventArgs e)
        {
            if (macl == 0)
            {
                MessageBox.Show("Không nằm trong thời gian ca làm việc", "Bán hàng Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable tb = new DataTable();
                MonAnCaLam_DAL monan = new MonAnCaLam_DAL();
                tb = monan.GetAllMonBymaclAndPhanLoai(macl, "Đồ uống");
                LoadListMonAn(tb);
            }
        }

        private void btn_TatCa_Click(object sender, EventArgs e)
        {
            frm_Load();
        }
    }
}
