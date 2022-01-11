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

namespace QLNH.GUI_QLNH.GUI_NV
{
    public partial class frm_LichLamViec : Form
    {
        public frm_LichLamViec()
        {
            InitializeComponent();
            frm_Load();
        }
        private void frm_Load()
        {
            ChamCong_DAL cham = new ChamCong_DAL();
            DataTable tb = new DataTable();
            tb = cham.GetLichLamViec();
            dataGridView1.DataSource = tb;
            dataGridView1.ReadOnly = true;
        }
    }
}
