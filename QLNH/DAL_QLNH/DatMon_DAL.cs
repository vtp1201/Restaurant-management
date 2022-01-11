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
    class DatMon_DAL
    {
        SqlCommand cmd;
        public DataTable GetMonByMaClAndMaMonAn(int macl, int mamonan)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT TenMonAn, Gia, Description, Anh, ConLai FROM MON_AN, MON_CALAM WHERE MON_AN.MaMonAN = MON_CALAM.MaMonAn AND MaCL = @MaCL AND MON_AN.MaMonAn = @MaMonAn", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            command.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = mamonan;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public bool UpdateDonMua(DatMon hd, int macl)
        {
            string command = "UPDATE DON_MUA SET SoLuong = @SoLuong, ThanhTien = @ThanhTien WHERE MaHoaDon = @MaHoaDon AND MaMonAn = @MaMonAn";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = hd.MaHoaDon;
                cmd.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = hd.MaMonAn;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hd.SoLuong;
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = hd.ThanhTien;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            UpdateConLai(hd, macl);
            return true;
        }
        public bool InsertDonMua(DatMon hd, int macl)
        {
            string command = "INSERT INTO DON_MUA VALUES (@MaHoaDon, @MaMonAn , @SoLuong, @ThanhTien)";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = hd.MaHoaDon;
                cmd.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = hd.MaMonAn;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hd.SoLuong;
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = hd.ThanhTien;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            UpdateConLai(hd,macl);
            return true;
        }
        public bool UpdateConLai(DatMon hd, int macl)
        {
            string command = "UPDATE MON_CALAM SET ConLai = @ConLai WHERE MaCL = @MaCl AND MaMonAn = @MaMonAn";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaCl", SqlDbType.Int).Value = macl;
                cmd.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = hd.MaMonAn;
                cmd.Parameters.Add("@ConLai", SqlDbType.Int).Value = GetConLaiByMaClAndMaMon(macl,hd.MaMonAn) - hd.SoLuong;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public int GetConLaiByMaClAndMaMon(int macl, int mamonan)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT ConLai FROM MON_AN, MON_CALAM WHERE MON_AN.MaMonAN = MON_CALAM.MaMonAn AND MaCL = @MaCL AND MON_AN.MaMonAn = @MaMonAn", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            command.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = mamonan;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return int.Parse(tb.Rows[0][0].ToString());
        }
    }
}
