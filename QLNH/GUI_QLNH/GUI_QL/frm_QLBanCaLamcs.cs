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
    public partial class frm_QLBanCaLamcs : Form
    {
        int macl = 0;
        public frm_QLBanCaLamcs()
        {
            InitializeComponent();
            List<string> pl = new List<string>();
            pl.Add("Theo khu vực");
            pl.Add("Theo số ghế");
            cbb_PhanLoai.DataSource = pl;
            List<string> cl = new List<string>();
            cl.Add("Sáng");
            cl.Add("Trưa");
            cl.Add("Tối");
            cbb_TenCa.DataSource = cl;
        }
        private void frm_QLBanCaLamcs_load()
        {
            DataTable tb = new DataTable();
            Ban_DAL ban = new Ban_DAL();
            macl = ban.GetMaClByNgayAndTenCa(dateTimePicker1.Value.ToString("yyyy-MM-dd"), cbb_TenCa.Text);
            
            tb = ban.GetAllBankotrongca(macl);
            lv_Ban.Clear();
            lv_Ban.View = View.Details;
            lv_Ban.Columns.Add("Tên bàn", 115);
            lv_Ban.Columns.Add("số ghế", 115);
            lv_Ban.Columns.Add("Khu Vực", 115);
            //
            if (cbb_PhanLoai.Text == "Theo số ghế")
            {
                ListViewGroup chongoi4 = new ListViewGroup("4 chỗ ngồi", HorizontalAlignment.Left);
                ListViewGroup chongoi8 = new ListViewGroup("8 chỗ ngồi", HorizontalAlignment.Left);
                ListViewGroup chongoi12 = new ListViewGroup("12 chỗ ngồi", HorizontalAlignment.Left);
                //
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (int.Parse(tb.Rows[i][1].ToString()) == 4)
                    {
                        ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), chongoi4);
                        item.SubItems.Add(tb.Rows[i][1].ToString());
                        item.SubItems.Add(tb.Rows[i][2].ToString());
                        lv_Ban.Items.Add(item);
                    }
                    else if (int.Parse(tb.Rows[i][1].ToString()) == 8)
                    {
                        ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), chongoi8);
                        item.SubItems.Add(tb.Rows[i][1].ToString());
                        item.SubItems.Add(tb.Rows[i][2].ToString());
                        lv_Ban.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), chongoi12);
                        item.SubItems.Add(tb.Rows[i][1].ToString());
                        item.SubItems.Add(tb.Rows[i][2].ToString());
                        lv_Ban.Items.Add(item);
                    }
                }

                lv_Ban.Groups.Add(chongoi4);
                lv_Ban.Groups.Add(chongoi8);
                lv_Ban.Groups.Add(chongoi12);
            } 
            else
            {
                ListViewGroup chongoi4 = new ListViewGroup("Tầng 1", HorizontalAlignment.Left);
                ListViewGroup chongoi8 = new ListViewGroup("Tầng 2", HorizontalAlignment.Left);
                ListViewGroup chongoi12 = new ListViewGroup("Sân vườn", HorizontalAlignment.Left);
                //
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (tb.Rows[i][2].ToString() == "Tầng 1")
                    {
                        ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), chongoi4);
                        item.SubItems.Add(tb.Rows[i][1].ToString());
                        item.SubItems.Add(tb.Rows[i][2].ToString());
                        lv_Ban.Items.Add(item);
                    }
                    else if (tb.Rows[i][2].ToString() == "Tầng 2")
                    {
                        ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), chongoi8);
                        item.SubItems.Add(tb.Rows[i][1].ToString());
                        item.SubItems.Add(tb.Rows[i][2].ToString());
                        lv_Ban.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), chongoi12);
                        item.SubItems.Add(tb.Rows[i][1].ToString());
                        item.SubItems.Add(tb.Rows[i][2].ToString());
                        lv_Ban.Items.Add(item);
                    }
                }

                lv_Ban.Groups.Add(chongoi4);
                lv_Ban.Groups.Add(chongoi8);
                lv_Ban.Groups.Add(chongoi12);
            }    

            lv_Ban.CheckBoxes = true;
            lv_Ban.MultiSelect = true;
            tb.Clear();
            tb = ban.GetAllBanByMaCL(macl);
            dgv_Ban.DataSource = tb;
            dgv_Ban.ReadOnly = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = lv_Ban.CheckedItems;
            Ban_CaLam_DAL ban = new Ban_CaLam_DAL();

            foreach (ListViewItem item in checkedItems)
            {
                BanCaLam bancl = new BanCaLam();
                bancl.MaCL = macl;
                bancl.MaBan = int.Parse(item.Text);
                if (ban.InsertBanCaLam(bancl) == true)
                {
                    MessageBox.Show("Đã thêm bàn " + item.Text + " vào ca làm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            frm_QLBanCaLamcs_load();
        }

        private void btn_PhanLoai_Click(object sender, EventArgs e)
        {
            frm_QLBanCaLamcs_load();
        }

        private void btn_CaLam_Click(object sender, EventArgs e)
        {
            frm_QLBanCaLamcs_load();
        }
    }
}
