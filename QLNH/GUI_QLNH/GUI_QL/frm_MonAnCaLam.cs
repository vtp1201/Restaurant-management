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
using QLNH.DTO_QLNH;

namespace QLNH.GUI_QLNH.GUI_QL
{
    public partial class frm_MonAnCaLam : Form
    {
        int macl = 0;
        public frm_MonAnCaLam()
        {
            InitializeComponent();
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
            MonAnCaLam_DAL m = new MonAnCaLam_DAL();
            macl = ban.GetMaClByNgayAndTenCa(dateTimePicker1.Value.ToString("yyyy-MM-dd"), cbb_TenCa.Text);

            tb = m.GetAllMonAnkocotrongCl(macl);
            lv_MonAn.Clear();
            lv_MonAn.View = View.Details;
            lv_MonAn.Columns.Add("Mã món", 80);
            lv_MonAn.Columns.Add("Tên món", 170);
            lv_MonAn.Columns.Add("Giá", 140);
            //
            ListViewGroup KhaiVi = new ListViewGroup("Khai vị", HorizontalAlignment.Left);
            ListViewGroup Chinh = new ListViewGroup("Món chính", HorizontalAlignment.Left);
            ListViewGroup TrangMieng = new ListViewGroup("Tráng miệng", HorizontalAlignment.Left);
            ListViewGroup DoUong = new ListViewGroup("Đồ uống", HorizontalAlignment.Left);
            //
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                //ImageList img = new ImageList();
                //img.ImageSize = new Size(30, 30);
                //img.Images.Add
                if (tb.Rows[i][2].ToString() == "Khai vị")
                {
                    ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), KhaiVi);
                    item.SubItems.Add(tb.Rows[i][1].ToString());
                    item.SubItems.Add((int.Parse(tb.Rows[i][3].ToString())).ToString("#,##0") +"VND"); 
                    //byte[] pic;
                    //pic = (byte[])tb.Rows[i][5];
                    //MemoryStream picture = new MemoryStream(pic);
                    //ImageList img = new ImageList();
                    //img.ImageSize = new Size(30, 30);
                    //img.Images.Add(Image.FromStream(picture));
                    lv_MonAn.Items.Add(item);
                    //lv_MonAn.SmallImageList = img;
                }
                else if (tb.Rows[i][2].ToString() == "Chính")
                {
                    ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), Chinh);
                    item.SubItems.Add(tb.Rows[i][1].ToString());
                    item.SubItems.Add((int.Parse(tb.Rows[i][3].ToString())).ToString("#,##0") + "VND");
                    lv_MonAn.Items.Add(item);
                }
                else if (tb.Rows[i][2].ToString() == "Tráng miệng")
                {
                    ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), TrangMieng);
                    item.SubItems.Add(tb.Rows[i][1].ToString());
                    item.SubItems.Add((int.Parse(tb.Rows[i][3].ToString())).ToString("#,##0") + "VND");
                    lv_MonAn.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString(), DoUong);
                    item.SubItems.Add(tb.Rows[i][1].ToString());
                    item.SubItems.Add((int.Parse(tb.Rows[i][3].ToString())).ToString("#,##0") + "VND");
                    lv_MonAn.Items.Add(item);
                }
            }

            lv_MonAn.Groups.Add(KhaiVi);
            lv_MonAn.Groups.Add(Chinh);
            lv_MonAn.Groups.Add(TrangMieng);
            lv_MonAn.Groups.Add(DoUong);
            
            lv_MonAn.CheckBoxes = true;
            lv_MonAn.MultiSelect = true;
            tb.Clear();
            tb = m.GetAllMonAnByCaLam(macl);
            dgv_MonAnCaLam.DataSource = tb;
            dgv_MonAnCaLam.ReadOnly = true;
        }

        private void btn_CaLam_Click(object sender, EventArgs e)
        {
            frm_QLBanCaLamcs_load();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            ListView.CheckedListViewItemCollection checkedItems = lv_MonAn.CheckedItems;
            Ban_CaLam_DAL ban = new Ban_CaLam_DAL();

            foreach (ListViewItem item in checkedItems)
            {
                frm_AddEditMonAn ma = new frm_AddEditMonAn();
                ma.tb_MaCl.Text = macl.ToString();
                ma.tb_MaMonAn.Text = item.Text;
                ma.tb_TenMonAn.Text = item.SubItems[1].Text;
                ma.dtp_Ngay.Value = dateTimePicker1.Value;
                ma.cbb_TenCa.Text = cbb_TenCa.Text;
                ma.tb_ConLai.Visible = false;
                ma.lb_ConLai.Visible = false;
                ma.ShowDialog();
            }
            frm_QLBanCaLamcs_load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
