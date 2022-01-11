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

namespace QLNH.GUI_QLNH
{
    public partial class List_Mon : UserControl
    {
        int mahoadon = 0;
        int gia = 0;
        public int MaHD { get { return mahoadon; } set { mahoadon = value; } }
        int mamonan = 0;
        int conlai = 0;
        public int MaMonAn { get { return mamonan; } set { mamonan = value; } }
        int macl = 0;
        public int MaCL { get { return macl; } set { macl = value; } }
        public List_Mon()
        {
            InitializeComponent();
        }
        public delegate void GETDATA(int mahd);
        public GETDATA data;
        public void frm_Load()
        {
            DataTable tb = new DataTable();
            DatMon_DAL mon = new DatMon_DAL();
            tb = mon.GetMonByMaClAndMaMonAn(macl, mamonan);
            if (tb.Rows.Count > 0)
            {
                lb_TenMon.Text = tb.Rows[0][0].ToString();
                lb_Gia.Text = int.Parse(tb.Rows[0][1].ToString()).ToString("#,##0")+" VND";
                gia = int.Parse(tb.Rows[0][1].ToString());
                rtb_MoTa.Text = "Mô tả : " + tb.Rows[0][2].ToString();
                byte[] pic = (byte[])tb.Rows[0][3];
                MemoryStream picture = new MemoryStream(pic);
                ptb_Picture.Image = Image.FromStream(picture);
                conlai = int.Parse(tb.Rows[0][4].ToString());
                if (int.Parse(tb.Rows[0][4].ToString()) <= 10)
                {
                    lb_ConLai.Text = "Còn lại: " + tb.Rows[0][4].ToString() + " phần";
                }
                else
                {
                    lb_ConLai.Visible = false;
                }
                rtb_MoTa.ReadOnly = true;
                tb_SoLuong.Text = 0.ToString();
            }    
        }

        private void ibtn_Cong_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(tb_SoLuong.Text, out i))
            {
                i = i + 1;
                tb_SoLuong.Text = i.ToString();
            }
            else
            {
                MessageBox.Show("Phải nhập số nguyên vào số lượng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_SoLuong.Text = i.ToString();
            }    
        }

        private void ibtn_Tru_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(tb_SoLuong.Text, out i))
            {
                if (i == 0)
                {
                    tb_SoLuong.Text = i.ToString();
                }
                else
                {
                    i = i + 1;
                    tb_SoLuong.Text = i.ToString();
                }    
            }
            else
            {
                MessageBox.Show("Phải nhập số nguyên vào số lượng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_SoLuong.Text = i.ToString();
            }
        }

        private void ibtn_Add_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(tb_SoLuong.Text, out i))
            {
                if (i == 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0", "Không đặt được", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (i <= conlai)
                    {
                        DatMon_DAL dat = new DatMon_DAL();
                        DatMon mon = new DatMon();
                        mon.MaHoaDon = mahoadon;
                        mon.MaMonAn = mamonan;
                        mon.SoLuong = int.Parse(tb_SoLuong.Text);
                        mon.ThanhTien = mon.SoLuong * gia;
                        if (dat.InsertDonMua(mon, macl) == true)
                        {
                            data(mahoadon);
                            frm_Load();
                        }    
                        else
                        {
                            MessageBox.Show("Đặt món không thành công. Vui lòng thử lại sau!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Món này chỉ còn lại " + conlai + " phần", "Không đặt được", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
            }
            else
            {
                MessageBox.Show("Phải nhập số nguyên vào số lượng", "Không đặt được", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_SoLuong.Text = i.ToString();
            }
        }
    }
}
