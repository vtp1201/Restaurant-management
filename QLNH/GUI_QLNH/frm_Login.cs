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
using QLNH.GUI_QLNH.GUI_QL;
using QLNH.GUI_QLNH.GUI_NV;

namespace QLNH.GUI_QLNH
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            InitializeMyControl();

        }
        private void InitializeMyControl()
        {
            // Set to no text.
            tb_Password.Text = "";
            // The password character is an asterisk.
            tb_Password.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            tb_Password.MaxLength = 14;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LogIn_DAL login = new LogIn_DAL();
            login.GetUser(tb_Username.Text, tb_Password.Text);
            
            if (User.MaCV == 1)
            {
                frm_QuanLy ql = new frm_QuanLy();
                Visible = false;
                ql.Show();
            }
            else if (User.MaCV == 2)
            {
                frm_NhanVien nv = new frm_NhanVien();
                Visible = false;
                nv.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
