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
    public partial class frm_AddBan : Form
    {
        List<Button> bt = new List<Button>();
        int mahoadon = 0;
        public int MaHD { get { return mahoadon; } set { mahoadon = value; } }
        int macl = 0;
        public int MaCL { get { return macl; } set { macl = value; } }
        public frm_AddBan()
        {
            InitializeComponent();
            List<string> tt = new List<string>();
            tt.Add("Chọn trạng thái");
            tt.Add("Tất cả");
            tt.Add("Còn trống");
            tt.Add("Đã đặt");
            cbb_TrangThai.DataSource = tt;
            List<string> sx = new List<string>();
            sx.Add("Chọn");
            sx.Add("Số ghế");
            sx.Add("Khu vực");
            cbb_SapXep.DataSource = sx;
        }

        private void ibtn_ApDung_Click(object sender, EventArgs e)
        {
            foreach(Button button in bt)
            {
                Controls.Remove(button);
            }    
            if (check() == true)
            {
                DataTable tb = new DataTable();
                DatBan_DAL dat = new DatBan_DAL();
                if (cbb_TrangThai.Text == "Tất cả")
                {
                    tb = dat.GetAllBanByMaCL(macl);
                    load_Ban(tb);
                }
                else if (cbb_TrangThai.Text == "Còn trống")
                {
                    tb = dat.GetBanTrongByMaCL(macl);
                    load_Ban(tb);
                }
                else
                {
                    tb = dat.GetBanDangDungByMaCL(macl);
                    load_Ban(tb);
                }
            }      
        }
        private bool check()
        {
            if (cbb_TrangThai.Text == "Chọn trạng thái")
            {
                MessageBox.Show("Chọn trạng thái !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_TrangThai.Focus();
                return false;
            }
            else if (cbb_SapXep.Text == "Chọn")
            {
                MessageBox.Show("Chọn sắp xếp theo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_SapXep.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public void frm_Load()
        {
            if (macl == 0)
            {
                lb_1.Visible = false;
                lb_2.Visible = false;
                lb_3.Visible = false;
                ibtn_ApDung.Enabled = true;
            }
            else
            {
                cbb_TrangThai.Text = "Tất cả";
                cbb_SapXep.Text = "khu vực";
                DataTable tb = new DataTable();
                DatBan_DAL dat = new DatBan_DAL();
                tb = dat.GetAllBanByMaCL(macl);
                load_Ban(tb);
            }    
        }
        void load_Ban(DataTable tb)
        {
            int x1 = 40, x2 = 40, x3 = 40, y1 = 250, y2 = 400, y3 = 550;
            int c = 0;
            if (cbb_SapXep.Text == "Khu vực")
            {
                lb_1.Text = "Tầng 1";
                lb_2.Text = "Tầng 2";
                lb_3.Text = "Sân vườn";
                for (int i = 0; i < tb.Rows.Count ; i++)
                {
                    if (tb.Rows[i][1].ToString() == "Tầng 1")
                    {
                        if (string.IsNullOrEmpty(tb.Rows[i][3].ToString()) == true)
                        {
                            c = 1;
                        } 
                        else
                        {
                            c = 0;
                        }
                        cre_btn(tb.Rows[i][0].ToString(), tb.Rows[i][2].ToString(), x1, y1, c);
                        x1 = x1 + 300;
                    }
                    else if (tb.Rows[i][1].ToString() == "Tầng 2")
                    {
                        if (string.IsNullOrEmpty(tb.Rows[i][3].ToString()) == true)
                        {
                            c = 1;
                        }
                        else
                        {
                            c = 0;
                        }
                        cre_btn(tb.Rows[i][0].ToString(), tb.Rows[i][2].ToString(), x2, y2, c);
                        x2 = x2 + 300;
                    }    
                    else
                    {
                        if (string.IsNullOrEmpty(tb.Rows[i][3].ToString()) == true)
                        {
                            c = 1;
                        }
                        else
                        {
                            c = 0;
                        }
                        cre_btn(tb.Rows[i][0].ToString(), tb.Rows[i][2].ToString(), x3, y3, c);
                        x3 = x3 + 300;
                    }    
                }    
            }
            else
            {
                lb_1.Text = "4 chỗ ngồi";
                lb_2.Text = "8 chỗ ngồi";
                lb_3.Text = "12 chỗ ngồi";
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (int.Parse(tb.Rows[i][2].ToString()) == 4)
                    {
                        if (string.IsNullOrEmpty(tb.Rows[i][3].ToString()) == true)
                        {
                            c = 1;
                        }
                        else
                        {
                            c = 0;
                        }
                        cre_btn(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), x1, y1, c);
                        x1 = x1 + 300;
                    }
                    else if (int.Parse(tb.Rows[i][2].ToString()) == 8)
                    {
                        if (string.IsNullOrEmpty(tb.Rows[i][3].ToString()) == true)
                        {
                            c = 1;
                        }
                        else
                        {
                            c = 0;
                        }
                        cre_btn(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), x2, y2, c);
                        x2 = x2 + 300;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(tb.Rows[i][3].ToString()) == true)
                        {
                            c = 1;
                        }
                        else
                        {
                            c = 0;
                        }
                        cre_btn(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), x3, y3, c);
                        x3 = x3 + 300;
                    }
                }
            }
        }
        public delegate void GETAddBan(int mahd, int action);
        public GETAddBan addban;
        private void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Aqua)
            {
                if (MessageBox.Show("Chọn bàn " + btn.Text, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    HoaDon_DAL hd = new HoaDon_DAL();
                    HoaDon hoadon = new HoaDon();
                    hoadon.MaHoaDon = mahoadon;
                    hoadon.MaBan = int.Parse(btn.Name);
                    if (hd.AddBanIntoHoaDon(hoadon) == true)
                    {
                        if (MessageBox.Show("Đã chọn bàn thành công, Bạn có muốn thêm món ăn?" , "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            addban(mahoadon,1);
                            frm_Load();
                        }
                        else
                        {
                            addban(mahoadon, 2);
                            frm_Load();
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được hóa đơn, Vui lòng thử lại sau!", "Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể chọn bàn này, Vui lòng thử lại sau!", "Message", MessageBoxButtons.OK);
                }    
            }
        }
        private Button cre_btn(string name, string tt, int x, int y, int c)
        {
            Button b = new Button();
            b.Location = new Point(x, y);
            b.Name = name;
            b.Text = "Bàn số : " + name + " ( " + tt + " )" ;
            b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            b.Size = new Size(250, 50);
            b.Font = new Font("Microsoft Sans Serif", 12);
            b.Padding = new Padding(0);
            if (c == 1)
            {
                b.BackColor = Color.Aqua;
            }
            else
            {
                b.BackColor = Color.OrangeRed;
            }
            b.Click += new EventHandler(this.button_click);
            bt.Add(b);
            this.Controls.Add(b);
            return b;
        }
    }
}
