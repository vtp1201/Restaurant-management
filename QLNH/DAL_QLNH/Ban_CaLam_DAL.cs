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
    class Ban_CaLam_DAL
    {
        SqlCommand cmd;
        public bool InsertBanCaLam(BanCaLam ban)
        {
            string command = "INSERT INTO BAN_CALAM VALUES (@MaCl, @MaBan)";
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
