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
    public partial class frm_ThongKe : Form
    {
        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void btn_AddMonAn_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            HoaDon_DAL hoa = new HoaDon_DAL();
            tb = hoa.ThongKeHoaDonByThang();
            load_doanhthu(tb);
        }
        private void load_doanhthu(DataTable tb)
        {
            for(int i =0; i < tb.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(tb.Rows[i][2].ToString()) == false)
                {
                    chart1.Series["Doanh thu"].Points.AddXY(tb.Rows[i][0].ToString(), int.Parse(tb.Rows[i][2].ToString()));
                    chart1.Series["SL hóa đơn"].Points.AddXY(tb.Rows[i][0].ToString(), int.Parse(tb.Rows[i][1].ToString()));
                }    
                
            }
        }
        private void load_monan(DataTable tb)
        {
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                chart1.Series["Doanh thu"].Points.AddXY(tb.Rows[i][0].ToString(), int.Parse(tb.Rows[i][2].ToString()));
                chart1.Series["SL hóa đơn"].Points.AddXY(tb.Rows[i][0].ToString(), int.Parse(tb.Rows[i][1].ToString()));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            HoaDon_DAL hoa = new HoaDon_DAL();
            tb = hoa.ThongKeMonAn();
            chart2.DataSource = tb;
            chart2.Series["TenMonAn"].XValueMember = "TenMonAn";
            chart2.Series["tongtien"].YValueMembers = "tongtien";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
