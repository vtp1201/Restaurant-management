using QLNH.DAL_QLNH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNH.DTO_QLNH;

namespace QLNH.GUI_QLNH
{
    public partial class frm_BanHang : Form
    {
        string ngay = string.Empty;
        string tenca = string.Empty;
        int mahoadon = 0;
        public int MaHD { get { return mahoadon; } set { mahoadon = value; } }
        int macl = 0;
        public frm_BanHang()
        {
            InitializeComponent();
            frm_BanHang_Load();
        }
        private void frm_BanHang_Load()
        {
            timer1.Start();
            ngay = DateTime.Now.ToString("yyyy-MM-dd");
            string ca = DateTime.Now.ToString("yyyy-MM-dd");
            TimeSpan time = TimeSpan.Parse(DateTime.Now.ToString("HH:mm"));
            if (time > TimeSpan.Parse("6:50") && time < TimeSpan.Parse("11:00"))
            {
                tenca = "Sáng";
            }
            else if (time > TimeSpan.Parse("11:00") && time < TimeSpan.Parse("14:10"))
            {
                tenca = "Trưa";
            }
            else if (time > TimeSpan.Parse("15:50") && time < TimeSpan.Parse("22:20"))
            {
                tenca = "Tối";
            }
            if(string.IsNullOrEmpty(tenca) == true)
            {

            }
            else
            {
                DataTable tb = new DataTable();
                DatBan_DAL dat = new DatBan_DAL();
                Ban_DAL ban = new Ban_DAL();
                macl = ban.GetMaClByNgayAndTenCa(ngay, tenca);
            }
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {

        }
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_childform.Controls.Add(childForm);
            panel_childform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public Form active_Form = null;
        public void openForm_HD(Form childForm)
        {
            if (active_Form != null) active_Form.Close();
            active_Form = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pl_HoaDon.Controls.Add(childForm);
            pl_HoaDon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void GetShowhd(int value)
        {
            mahoadon = value;
            frm_BanHang_Load();
            panel_childform.Controls.Clear();
        }
        private void ibt_NhaHang_Click(object sender, EventArgs e)
        {
            HoaDon_DAL hd = new HoaDon_DAL();
            HoaDon hoadon = new HoaDon();
            hoadon.GioVao = DateTime.Now;
            hoadon.MaCL = macl;
            hoadon.MaNV = User.MaNV;
            if (hd.CreateHoaDon(hoadon) == true)
            {
                mahoadon = hd.SelectMaHoaDon();
                frm_AddBan add = new frm_AddBan();
                add.MaCL = macl;
                add.MaHD = mahoadon;
                add.frm_Load();
                add.addban = new frm_AddBan.GETAddBan(GetfrmAddBan);
                openChildForm(add);
                frm_ShowHoaDon show = new frm_ShowHoaDon();
                show.MaHD = mahoadon;
                show.MaCL = macl;
                show.frm_Load();
                show.showhd = new frm_ShowHoaDon.GETShowhd(GetShowhd);
                openForm_HD(show);
            }
            else
            {
                MessageBox.Show("Không nằm trong thời gian bán hàng, Vui lòng thử lại sau!", "Message", MessageBoxButtons.OK);
            }
        }
        public void GetfrmAddBan(int value, int action)
        {
            if (action == 1)
            {
                mahoadon = value;
                frm_ShowHoaDon show = new frm_ShowHoaDon();
                show.MaHD = mahoadon;
                show.MaCL = macl;
                show.frm_Load();
                show.showhd = new frm_ShowHoaDon.GETShowhd(GetShowhd);
                openForm_HD(show);
                frm_AddMonAn add = new frm_AddMonAn();
                add.MaCL = macl;
                add.MaHD = mahoadon;
                add.frm_Load();
                add.addmonan = new frm_AddMonAn.GETAddMonAn(GetfrmAddMonAn);
                openChildForm(add);
            } 
            else
            {
                mahoadon = value;
                frm_ShowHoaDon show = new frm_ShowHoaDon();
                show.MaHD = mahoadon;
                show.MaCL = macl;
                show.frm_Load();
                show.showhd = new frm_ShowHoaDon.GETShowhd(GetShowhd);
                openForm_HD(show);
            }  
        }
        public void GetfrmAddMonAn(int value)
        {
            mahoadon = value;
            frm_ShowHoaDon show = new frm_ShowHoaDon();
            show.MaHD = mahoadon;
            show.MaCL = macl;
            show.frm_Load();
            show.showhd = new frm_ShowHoaDon.GETShowhd(GetShowhd);
            openForm_HD(show);
        }
        public void Getfrm_ListHoaDon(int value)
        {
            mahoadon = value;
            frm_ShowHoaDon show = new frm_ShowHoaDon();
            show.MaHD = mahoadon;
            show.MaCL = macl;
            show.frm_Load();
            openForm_HD(show);
        }
        private void ibt_ChonMon_Click(object sender, EventArgs e)
        {
            frm_AddMonAn add = new frm_AddMonAn();
            add.MaCL = macl;
            add.MaHD = mahoadon;
            add.frm_Load();
            add.addmonan = new frm_AddMonAn.GETAddMonAn(GetfrmAddMonAn);
            openChildForm(add);
        }

        private void ibt_ChonBan_Click(object sender, EventArgs e)
        {
            if (mahoadon == 0 && macl != 0)
            {
                if (MessageBox.Show("Thêm mới hóa đơn", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    HoaDon_DAL hd = new HoaDon_DAL();
                    HoaDon hoadon = new HoaDon();
                    hoadon.GioVao = DateTime.Now;
                    hoadon.MaCL = macl;
                    hoadon.MaNV = User.MaNV;
                    if ( hd.CreateHoaDon(hoadon)== true)
                    {
                        mahoadon = hd.SelectMaHoaDon();
                        frm_AddBan add = new frm_AddBan();
                        add.MaCL = macl;
                        add.MaHD = mahoadon;
                        add.frm_Load();
                        add.addban = new frm_AddBan.GETAddBan(GetfrmAddBan);
                        openChildForm(add);
                    }
                    else
                    {
                        MessageBox.Show("Không nằm trong thời gian bán hàng, Vui lòng thử lại sau!", "Message", MessageBoxButtons.OK);
                    }
                }
            } 
            else
            {
                frm_AddBan add = new frm_AddBan();
                add.MaCL = macl;
                add.MaHD = mahoadon;
                add.frm_Load();
                add.addban = new frm_AddBan.GETAddBan(GetfrmAddBan);
                openChildForm(add);
            }    
        }

        private void ibt_HoaDon_Click(object sender, EventArgs e)
        {
            frm_ListHoaDon hoaDon = new frm_ListHoaDon();
            hoaDon.MaCL = macl;
            hoaDon.frm_Load();
            hoaDon.FullListHoaDon = new frm_ListHoaDon.GETFullListHoaDon(Getfrm_ListHoaDon);
            openChildForm(hoaDon);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Date.Text = DateTime.Now.ToLongDateString();
            lb_Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
