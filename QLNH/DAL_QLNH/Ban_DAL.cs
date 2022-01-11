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
    class Ban_DAL
    {
        SqlCommand cmd;
        public int GetMaClByNgayAndTenCa(string ngay, string tenca)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaCL FROM CA_LAM WHERE Ngay = @Ngay AND TenCA = @TenCa ", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
            command.Parameters.Add("@TenCa", SqlDbType.NVarChar).Value = tenca;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return int.Parse(tb.Rows[0][0].ToString());
        }
        public DataTable GetAllBanBySoGheAndMaCL(int macl, int ghe)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaCL, BAN.MaBan, SoGhe, KhuVuc FROM BAN, BAN_CALAM WHERE BAN.MaBan = BAN_CALAM.MaBan AND MaCL = @MaCL AND SoGhe = @SoGhe", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            command.Parameters.Add("@SoGhe", SqlDbType.Int).Value = ghe;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetAllBanByMaCL(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaCl, BAN.MaBan, SoGhe, KhuVuc FROM BAN, BAN_CALAM WHERE BAN.MaBan = BAN_CALAM.MaBan AND MaCL = @MaCL", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetAllBan()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaBan AS 'Tên bàn', SoGhe AS 'Số lượng ghế', KhuVuc AS 'Khu vực' FROM BAN", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetAllBankotrongca(int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MaBan, SoGhe, KhuVuc FROM BAN WHERE NOT EXISTS (SELECT  MaBan FROM BAN_CALAM WHERE BAN.MaBan = BAN_CALAM.MaBan AND MaCL = @MaCl )", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaCl", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public int GetSLBan()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM BAN", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return int.Parse(tb.Rows[0][0].ToString());
        }
        public int GetSLBanBySoGhe(int ghe)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM BAN WHERE SoGhe = @SoGhe", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@SoGhe", SqlDbType.Int).Value = ghe;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return int.Parse(tb.Rows[0][0].ToString());
        }
        public int GetMaBanMax()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('BAN')", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return int.Parse(tb.Rows[0][0].ToString());
        }
        public bool InsertBan(Ban ban)
        {
            string command = "INSERT INTO BAN VALUES (@SoGhe, @KhuVuc)";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@SoGhe", SqlDbType.Int).Value = ban.SoGhe;
                cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar).Value = ban.KhuVuc;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateBan(Ban ban)
        {
            string command = "UPDATE BAN SET SoGhe = @SoGhe, KhuVuc = @KhuVuc WHERE MaBan = @MaBan";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaBan", SqlDbType.Int).Value = ban.MaBan;
                cmd.Parameters.Add("@SoGhe", SqlDbType.Int).Value = ban.SoGhe;
                cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar).Value = ban.KhuVuc;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DeleteBan(Ban ban)
        {
            string command = "DELETE BAN WHERE MaBan = @MaBan ";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaBan", SqlDbType.Int).Value = ban.MaBan;
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
