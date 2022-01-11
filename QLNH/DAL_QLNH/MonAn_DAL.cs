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
    class MonAn_DAL
    {
        SqlCommand cmd;
        public DataTable GetAllMonAn()
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT * FROM MON_AN", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetMonAnByMaMonAn(int ma)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT * FROM MON_AN WHERE MaMonAn = @MaMonAn", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = ma;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetAllMonAnByPhanLoai(string pl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT * FROM MON_AN WHERE PhanLoai = @PhanLoai", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@PhanLoai", SqlDbType.NVarChar).Value = pl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public DataTable GetMonAnByPhanLoaiAndCaLam(string pl, int macl)
        {
            MY_DB con = new MY_DB();
            SqlCommand command = new SqlCommand("SELECT MON_AN.MaMonAn, TenMonAn, Gia, DESCRIPTION, Anh, ConLai FROM MON_AN, MON_CALAM WHERE MON_AN.MaMonAn = MON_CALAM.MaMonAn AND PhanLoai = @PhanLoai AND MON_CALAM.MaCL = @MaCL", con.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            command.Parameters.Add("@PhanLoai", SqlDbType.NVarChar).Value = pl;
            command.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            da.SelectCommand = command;
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.closeConnection();
            return tb;
        }
        public bool InsertMonAN(MonAn ma)
        {
            string command = "INSERT INTO MON_AN VALUES (@TenMonAn, @PhanLoai, @Gia, @Description, @Anh)";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@TenMonAn", SqlDbType.NVarChar).Value = ma.TenMonAn;
                cmd.Parameters.Add("@PhanLoai", SqlDbType.NVarChar).Value = ma.PhanLoai;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = ma.Gia;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ma.Description;
                cmd.Parameters.Add(new SqlParameter("@Anh", ma.Anh));
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateMonAn(MonAn ma)
        {
            string command = "UPDATE MON_AN SET TenMonAn = @TenMonAn, PhanLoai = @PhanLoai, Gia = @Gia, Description = @Description, Anh = @Anh WHERE MaMonAn = @MaMonAn";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = ma.MaMonAn;
                cmd.Parameters.Add("@TenMonAn", SqlDbType.NVarChar).Value = ma.TenMonAn;
                cmd.Parameters.Add("@PhanLoai", SqlDbType.NVarChar).Value = ma.PhanLoai;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = ma.Gia;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ma.Description;
                cmd.Parameters.Add(new SqlParameter("@Anh", ma.Anh));
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DeleteMonAn(int mon)
        {
            string command = "DELETE MON_AN WHERE MaMonAn = @MaMonAn ";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaMonAn", SqlDbType.Int).Value = mon;
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
