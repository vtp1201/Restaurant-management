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
    class DatBan_DAL
    {
        public DataTable GetAllBanByMaCL(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT BAN.MaBan, KhuVuc, SoGhe, MaHoaDon FROM (SELECT BAN.MaBan, SoGhe, KhuVuc FROM BAN, BAN_CALAM WHERE BAN.MaBan = BAN_CALAM.MaBan AND MaCL = @MaCL) AS BAN LEFT JOIN (SELECT  MaBan, MaHoaDon FROM HOA_DON WHERE MaCL = @MaCL AND Status = N'Đang ăn' OR Status = N'Đã thanh toán') AS HD ON BAN.MaBan = HD.MaBan", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetBanTrongByMaCL(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT BAN.MaBan, KhuVuc, SoGhe, MaHoaDon FROM(SELECT BAN.MaBan, SoGhe, KhuVuc FROM BAN, BAN_CALAM WHERE BAN.MaBan = BAN_CALAM.MaBan AND MaCL = @MaCL) AS BAN LEFT JOIN(SELECT  MaBan, MaHoaDon FROM HOA_DON WHERE MaCL = @MaCL AND Status = N'Đang ăn' OR Status = N'Đã thanh toán') AS HD ON BAN.MaBan = HD.MaBan WHERE MaHoaDon Is null", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetBanDangDungByMaCL(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT BAN.MaBan, KhuVuc, SoGhe, MaHoaDon FROM(SELECT BAN.MaBan, SoGhe, KhuVuc FROM BAN, BAN_CALAM WHERE BAN.MaBan = BAN_CALAM.MaBan AND MaCL = @MaCL) AS BAN LEFT JOIN(SELECT  MaBan, MaHoaDon FROM HOA_DON WHERE MaCL = @MaCL AND Status = N'Đang ăn' OR Status = N'Đã thanh toán') AS HD ON BAN.MaBan = HD.MaBan WHERE MaHoaDon Is not null", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
    }
}
