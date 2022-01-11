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
    public partial class frm_QLBan : Form
    {
        public frm_QLBan()
        {
            InitializeComponent();
            List<string> sl = new List<string>();
            sl.Add("Chọn số ghế");
            sl.Add("4");
            sl.Add("8");
            sl.Add("12");
            cbb_SoGhe.DataSource = sl;
            List<string> kv = new List<string>();
            kv.Add("Chọn khu vực");
            kv.Add("Tầng 1");
            kv.Add("Tầng 2");
            kv.Add("Sân vườn");
            cbb_KhuVuc.DataSource = kv;
            frm_QLBan_Load();
        }

        private void frm_QLBan_Load()
        {
            Ban_DAL ban = new Ban_DAL();
            DataTable tb = new DataTable();
            tb = ban.GetAllBan();
            dgv_Ban.DataSource = tb;
            dgv_Ban.ReadOnly = true;
            tb_TongSoBan.Text = ban.GetSLBan().ToString() + " bàn";
            tb_4ChoNgoi.Text = ban.GetSLBanBySoGhe(4).ToString() + " bàn";
            tb_8ChoNgoi.Text = ban.GetSLBanBySoGhe(8).ToString() + " bàn";
            tb_12ChoNgoi.Text = ban.GetSLBanBySoGhe(12).ToString() + " bàn";
            tb_MaBan.Text = "Bàn số : " + (ban.GetMaBanMax() + 1).ToString();
            tb_MaBan.ReadOnly = true;
            btn_Update.Visible = false;
            btn_AddBan.Visible = true;
            cbb_SoGhe.Text = "Chọn số ghế";
            groupBox1.Text = "Thêm bàn";
        }

        private void frm_QLBan_Load(object sender, EventArgs e)
        {

        }
        private bool check()
        {
            if (cbb_SoGhe.Text == "Chọn số ghế")
            {
                MessageBox.Show("Chọn số lượng ghế !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_SoGhe.Focus();
                return false;
            }
            else if (cbb_KhuVuc.Text == "Chọn khu vực")
            {
                MessageBox.Show("Chọn khu vực !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_SoGhe.Focus();
                return false;
            }
            else
            {
                return true;
            }    
        }
        private void btn_AddBan_Click(object sender, EventArgs e)
        {
            Ban_DAL ban = new Ban_DAL();
            Ban b = new Ban();
            b.SoGhe = int.Parse(cbb_SoGhe.Text);
            b.KhuVuc = cbb_KhuVuc.Text;
            if(check() == true)
            {
                if (ban.InsertBan(b) == true)
                {
                    MessageBox.Show("Đã thêm bàn thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_QLBan_Load();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Ban_DAL ban = new Ban_DAL();
            Ban b = new Ban();
            b.MaBan = int.Parse(tb_MaBan.Text);
            b.SoGhe = int.Parse(cbb_SoGhe.Text);
            b.KhuVuc = cbb_KhuVuc.Text;
            if (check() == true)
            {
                if (ban.UpdateBan(b) == true)
                {
                    MessageBox.Show("Đã cập nhật thông tin bàn thành công", "Thông báo", MessageBoxButtons.OK);
                    frm_QLBan_Load();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, xin thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dgv_Ban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Text = "Cập nhật thông tin bàn";
            tb_MaBan.Text = dgv_Ban.CurrentRow.Cells[0].Value.ToString();
            cbb_SoGhe.Text = dgv_Ban.CurrentRow.Cells[1].Value.ToString();
            cbb_KhuVuc.Text = dgv_Ban.CurrentRow.Cells[2].Value.ToString();
            btn_Update.Visible = true;
            btn_AddBan.Visible = false;
        }
    }
}
