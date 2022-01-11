using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLNH.DTO_QLNH;

namespace QLNH.DAL_QLNH
{
    class LogIn_DAL
    {
        SqlCommand cmd;
        public void GetUser(string user, string pass)
        {
            MY_DB db = new MY_DB();
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT NHAN_VIEN.MaNV, HoTen, ChucVu, NHANVIEN_CHUCVU.MaCV, Anh FROM NHANVIEN_CHUCVU, NHAN_VIEN, Chuc_Vu, LOG_IN WHERE NHANVIEN_CHUCVU.MaNV = NHAN_VIEN.MaNV AND NHANVIEN_CHUCVU.MaCV = CHUC_VU.MaCV AND NHAN_VIEN.MaNV= LOG_IN.MaNV  AND UserName = @User AND PassWord = @Pass", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.NChar).Value = user;
            cmd.Parameters.Add("@Pass", SqlDbType.NChar).Value = pass;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(tb);
            db.closeConnection();
            if (tb.Rows.Count > 0)
            {
                User.MaNV = int.Parse(tb.Rows[0][0].ToString());
                User.HoTen = tb.Rows[0][1].ToString();
                User.ChucVu = tb.Rows[0][2].ToString();
                User.MaCV = int.Parse(tb.Rows[0][3].ToString());
                User.Anh = (byte[])tb.Rows[0][4];
            }
        }
        public DataTable GetUsernameAndPass()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT * FROM LOG_IN WHERE MaNV = @MaNV", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaNV", SqlDbType.Int).Value = User.MaNV;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public bool UpdatePass(string pass)
        {
            string command = "UPDATE LOG_IN SET PassWord = @Pass WHERE MaNV = @MaNV";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = User.MaNV;
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
