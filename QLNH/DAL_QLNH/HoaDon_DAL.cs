using QLNH.DTO_QLNH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAL_QLNH
{
    class HoaDon_DAL
    {
        SqlCommand cmd;
        public DataTable GetHoaDonByMaHD(int mahd)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("Select HOA_DON.MaHoaDon, MaBan, GioVao, GioRa, MaNV, MON_AN.MaMonAn, TenMonAn, SoLuong, Gia, ThanhTien, Status from (HOA_DON LEFT JOIN DON_MUA ON HOA_DON.MaHoaDon = DON_MUA.MaHoaDon) LEFT JOIN MON_AN ON DON_MUA.MaMonAn = MON_AN.MaMonAN  WHERE HOA_DON.MaHoaDon = @MaHoaDon", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = mahd;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetHoaDonByMaCL(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaHoaDon, MaCL, Status FROM HOA_DON WHERE MaCL = @MaHoaDon", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable ThongKeHoaDonByThang()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT month(Ngay), SUM(TONGTIEN) FROM HOA_DON, CA_LAM WHERE  HOA_DON.MaCL = CA_LAM.MaCL GROUP BY month(Ngay) ORDER BY month(Ngay)", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable ThongKeHoaDonByNgay()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT Ngay, SUM(TONGTIEN)Status FROM HOA_DON, CA_LAM WHERE  HOA_DON.MaCL = CA_LAM.MaCL GROUP BY Ngay ORDER BY Ngay", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable ThongKeMonAn()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT TenMonAn, SUM(SoLuong) AS SLMon, SUM(THANHTien) AS 'tongtien' FROM MON_AN, DON_MUA WHERE MON_AN.MaMonAn = DON_Mua.MaMonAN GROUP BY TenMonAn", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetALLHoaDonByMaCL(string macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaHoaDon, TenCa, TongTien, HOA_DON.GioVao, HOA_DON.GioRa, Status FROM HOA_DON, CA_LAM WHERE Ngay = @Ngay AND HOA_DON.MaCL = CA_LAM.MaCL", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetHoaDonByMaCLAndHoantat(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaHoaDon, MaCL, Status FROM HOA_DON WHERE MaCL = @MaHoaDon AND STATUS = N'Hoàn tất' ", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetHoaDonByMaCLAndThanhToan(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaHoaDon, MaCL, Status FROM HOA_DON WHERE MaCL = @MaHoaDon AND NOT EXISTS (SELECT MaHoaDon WHERE STATUS = N'Đã thanh toán' OR STATUS = N'Hoàn tất')", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetHoaDonByMaCLAndChuaThanhToan(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaHoaDon, MaCL, Status FROM HOA_DON WHERE MaCL = @MaHoaDon AND STATUS = N'Đã thanh toán'", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public bool CreateHoaDon(HoaDon hd)
        {
            string command = "INSERT INTO HOA_DON (MaCL, GioVao, MaNV, Status) VALUES (@MaCl, @GioVao, @MaNV, N'Đang ăn')";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaCl", SqlDbType.Int).Value = hd.MaCL;
                cmd.Parameters.Add("@GioVao", SqlDbType.Time).Value = ((DateTime)hd.GioVao).ToString("HH:mm");
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = hd.MaNV;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public int SelectMaHoaDon()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('HOA_DON')", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return int.Parse(tb.Rows[0][0].ToString());
        }
        public bool AddBanIntoHoaDon(HoaDon hd)
        {
            string command = "UPDATE HOA_DON SET MaBan = @MaBan WHERE MaHoaDon = @MaHoaDon";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = hd.MaHoaDon;
                cmd.Parameters.Add("@MaBan", SqlDbType.Int).Value = hd.MaBan;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool ThanhToanHoaDon(HoaDon hd)
        {
            string command = "UPDATE HOA_DON SET Status = @Status, TongTien = @TongTien WHERE MaHoaDon = @MaHoaDon";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = hd.MaHoaDon;
                cmd.Parameters.Add("@TongTien", SqlDbType.Int).Value = hd.TongTien;
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = hd.Status;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool KetThucHoaDon(HoaDon hd)
        {
            string command = "UPDATE HOA_DON SET TongTien = @TongTien, Status = @Status, GioRa = @GioRa WHERE MaHoaDon = @MaHoaDon";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = hd.MaHoaDon;
                cmd.Parameters.Add("@TongTien", SqlDbType.Int).Value = hd.TongTien;
                cmd.Parameters.Add("@GioRa", SqlDbType.Time).Value = ((DateTime)hd.GioRa).ToString("HH:mm");
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = hd.Status;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteBanCaLam(BanCaLam ban)
        {
            string command = "DELETE BAN_CALAM WHERE MaCL = @MaCl AND MaBan = @MaBan ";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaCl", SqlDbType.Int).Value = ban.MaCL;
                cmd.Parameters.Add("@MaBan", SqlDbType.NVarChar).Value = ban.MaBan;
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
