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
    public partial class frm_CaLam : Form
    {
        int macl = 0;
        ChamCong_DAL chamcong = new ChamCong_DAL();
        string ca_lam = "Sáng";
        public frm_CaLam()
        {
            List<string> ca = new List<string>();
            InitializeComponent();
            ca.Add("Chọn Ca");
            ca.Add("Sáng");
            ca.Add("Trưa");
            ca.Add("Tối");
            cbb_CaLam.DataSource = ca;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbb_CaLam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cl = sender as ComboBox;
            if (cl.SelectedItem != null)
            {
                ca_lam = cl.SelectedItem.ToString();
            }    
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string ngay = DTP_Ngay.Value.ToString("yyyy-MM-dd");
            if (ca_lam.Equals("Chọn Ca"))
            {
                MessageBox.Show("Chọn ca làm !", "Thông báo", MessageBoxButtons.OK);
            }  
            else
            {
                DataTable tb = new DataTable();
                Ban_DAL ban = new Ban_DAL();
                macl = ban.GetMaClByNgayAndTenCa(DTP_Ngay.Value.ToString("yyyy-MM-dd"), ca_lam);
                frm_LoadListView();
            }    
        }
        public void frm_LoadListView()
        {
            DataTable tb = new DataTable();
            tb = chamcong.GetAllNVKoLamMaCL(macl);
            lv_Ban.Clear();
            lv_Ban.View = View.Details;
            lv_Ban.Columns.Add("Mã nhân viên", 115);
            lv_Ban.Columns.Add("Tên NV", 115);
            lv_Ban.Columns.Add("Chức vu", 115);
            //
            ListViewGroup chongoi4 = new ListViewGroup("Quản lý", HorizontalAlignment.Left);
            ListViewGroup chongoi8 = new ListViewGroup("Nhân Viên", HorizontalAlignment.Left);
            //
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i][2].ToString() == "Quản lý")
                {
                    ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), chongoi4);
                    item.SubItems.Add(tb.Rows[i][1].ToString());
                    item.SubItems.Add(tb.Rows[i][2].ToString());
                    lv_Ban.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), chongoi8);
                    item.SubItems.Add(tb.Rows[i][1].ToString());
                    item.SubItems.Add(tb.Rows[i][2].ToString());
                    lv_Ban.Items.Add(item);
                }
            }
            lv_Ban.Groups.Add(chongoi4);
            lv_Ban.Groups.Add(chongoi8);
            lv_Ban.CheckBoxes = true;
            lv_Ban.MultiSelect = true;
            tb.Clear();
            tb = chamcong.GetCVByDayAndCL(DTP_Ngay.Value.ToString("yyyy-MM-dd"), ca_lam);
            dgv_CaLam.DataSource = tb;
            dgv_CaLam.ReadOnly = true;
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = lv_Ban.CheckedItems;

            foreach (ListViewItem item in checkedItems)
            {
                ChamCong bancl = new ChamCong();
                bancl.MaCL = macl;
                bancl.MaNV = int.Parse(item.Text);
                if (bancl.MaNV == chamcong.Getidquanly(macl) || chamcong.Getidquanly(macl) == 0)
                {
                    MessageBox.Show("Không thể có 2 Quản lý 1 ca ero: " + item.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }   
                else
                {
                    if (chamcong.InsertCV(bancl) == true)
                    {
                        MessageBox.Show("Đã thêm nhân viên " + item.Text + " vào ca làm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }    
                
            }
            frm_LoadListView();
        }

        private void dgv_CaLam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_TTCaLamViec clv = new frm_TTCaLamViec();
            clv.cbb_MaCaLam.Visible = false;
            clv.cbb_MaNV.Visible = false;
            clv.cbb_TenCa.Visible = false;
            clv.btn_Them.Visible = false;
            clv.dtp_Ngay.Enabled = false;
            clv.tb_HoTen.ReadOnly = true;
            clv.dtp_Ngay.Value = (DateTime)dgv_CaLam.CurrentRow.Cells[0].Value;
            clv.tb_HoTen.Text = dgv_CaLam.CurrentRow.Cells[4].Value.ToString();
            clv.lb_TenCa.Text = dgv_CaLam.CurrentRow.Cells[1].Value.ToString();
            clv.lb_MaCL.Text = dgv_CaLam.CurrentRow.Cells[2].Value.ToString();
            clv.lb_MaNV.Text = dgv_CaLam.CurrentRow.Cells[3].Value.ToString();
            clv.tb_CheckIn.Text = dgv_CaLam.CurrentRow.Cells[6].Value.ToString();
            clv.tb_CheckOut.Text = dgv_CaLam.CurrentRow.Cells[7].Value.ToString();
            clv.tb_Note.Text = dgv_CaLam.CurrentRow.Cells[8].Value.ToString();
            clv.ShowDialog();
        }
    }
}
