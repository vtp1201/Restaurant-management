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
    class MonAnCaLam_DAL
    {
        SqlCommand cmd;
        public DataTable GetAllMonAnkocotrongCl(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaMonAn, TenMonAn, PhanLoai, Gia FROM MON_AN WHERE NOT EXISTS (SELECT  MaMonAN FROM MON_CALAM WHERE MON_AN.MaMonAn = MON_CALAM.MaMonAN AND MaCL = @MaCL )", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetAllMonAnByCaLam(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MON_AN.MaMonAn AS 'Mã Món Ăn', TenMonAn AS 'Tên món', Gia As 'Giá thành', SoLuong AS 'Số phần', ConLai AS 'Còn lại', Anh AS 'Ảnh' FROM MON_AN, MON_CALAM WHERE MON_AN.MaMonAn = MON_CALAM.MaMonAN AND MaCl = @MaCL", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetAllMonBymaclAndPhanLoai(int macl, string pl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MON_AN.MaMonAn , TenMonAn FROM MON_AN, MON_CALAM WHERE MON_AN.MaMonAn = MON_CALAM.MaMonAN AND MaCl = @MaCL AND PhanLoai = @PhanLoai", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            command.Parameters.Add("@PhanLoai", SqlDbType.NVarChar).Value = pl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public bool InsertMonANCaLam(MonAnCaLam ma)
        {
            string command = "INSERT INTO MON_CALAM VALUES (@MaCl, @MaMonAn, @SoLuong, @ConLai)";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaCl", SqlDbType.Int).Value = ma.MaCL;
                cmd.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = ma.MaMonAn;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ma.SoLuong;
                cmd.Parameters.Add("@ConLai", SqlDbType.Int).Value = ma.SoLuong;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateMonAnCaLam(MonAnCaLam ma)
        {
            string command = "UPDATE MON_CALAM SET SoLuong = @SoLuong, ConLai = @ConLai WHERE MaCl = @MaCl AND MaMonAn = @MaMonAn";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaCl", SqlDbType.Int).Value = ma.MaCL;
                cmd.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = ma.MaMonAn;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ma.SoLuong;
                cmd.Parameters.Add("@ConLai", SqlDbType.Int).Value = ma.ConLai;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DeleteMonAnCaLam(MonAnCaLam mon)
        {
            string command = "DELETE MON_CALAM WHERE MaCl = @MaCl AND MaMonAn = @MaMonAn ";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaCl", SqlDbType.Int).Value = mon.MaCL;
                cmd.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = mon.MaMonAn;
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
