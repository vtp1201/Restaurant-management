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
    class NhanVien_DAL
    {
        SqlCommand cmd;
        
        public DataTable GetAllNhanVien()
        {
            MY_DB db = new MY_DB();
            string command = "SELECT NHAN_VIEN.MaNV, ChucVu, HoTen, GioiTinh, SDT, NgaySinh, DiaChi, Anh FROM NHAN_VIEN, NHANVIEN_CHUCVU, CHUC_VU WHERE NHAN_VIEN.MaNV = NHANVIEN_CHUCVU.MaNV AND NHANVIEN_CHUCVU.MaCV = CHUC_VU.MaCV AND NHANVIEN_CHUCVU.MaCV = 2";
            SqlDataAdapter da = new SqlDataAdapter(command, db.getConnection);
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public DataTable GetAllMaNV()
        {
            MY_DB db = new MY_DB();
            string command = "SELECT NHAN_VIEN.MaNV FROM NHAN_VIEN, NHANVIEN_CHUCVU, CHUC_VU WHERE NHAN_VIEN.MaNV = NHANVIEN_CHUCVU.MaNV AND NHANVIEN_CHUCVU.MaCV = CHUC_VU.MaCV AND NHANVIEN_CHUCVU.MaCV = 2";
            SqlDataAdapter da = new SqlDataAdapter(command, db.getConnection);
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public DataTable GetNhanVien(int id)
        {
            MY_DB db = new MY_DB();
            string command = "SELECT NHAN_VIEN.MaNV, ChucVu, HoTen, GioiTinh, SDT, NgaySinh, DiaChi, Anh FROM NHAN_VIEN, NHANVIEN_CHUCVU, CHUC_VU WHERE NHAN_VIEN.MaNV = NHANVIEN_CHUCVU.MaNV AND NHANVIEN_CHUCVU.MaCV = CHUC_VU.MaCV AND NHANVIEN_CHUCVU.MaNV = " + id;
            SqlDataAdapter da = new SqlDataAdapter(command, db.getConnection);
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public bool InsertNhanVien(NhanVien nv)
        {
            string command = "INSERT INTO NHAN_VIEN VALUES ( @HoTen, @NgaySinh, @SDT, @GioiTinh, @DiaChi, @Anh)";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.SDT;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add(new SqlParameter("@Anh", nv.Anh));
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            command = "SELECT MAX(MaNV) FROM NHAN_VIEN";
            SqlDataAdapter da = new SqlDataAdapter(command, db.getConnection);
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            int id = int.Parse(tb.Rows[0][0].ToString());

            command = "INSERT INTO NHANVIEN_CHUCVU (MaNV, MaCV) VALUES (@MaNV,2)";
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            command = "INSERT INTO LOG_IN VALUES (@MaNV, @User, @Pass)";
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = nv.UserName;
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = nv.PassWord;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateNhanVien(NhanVien nv)
        {
            string command = "UPDATE NHAN_VIEN SET HoTen = @HoTen, NgaySinh = @NgaySinh, SDT = @SDT , GioiTinh = @GioiTinh, DiaChi = @DiaChi, Anh = @Anh WHERE MaNV = @MaNV";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNV;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh.Value.ToString("yyyy-MM-dd"); ;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.SDT;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add(new SqlParameter("@Anh", nv.Anh));
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DeleteNhanVien(int manv)
        {
            string command = "DELETE NHAN_VIEN WHERE MaNV = @MaNV";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = manv;
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
