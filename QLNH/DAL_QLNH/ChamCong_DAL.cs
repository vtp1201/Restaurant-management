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
    class ChamCong_DAL
    {
        SqlCommand cmd;
        public DataTable GetAllCVByDay(string ngay)
        {
            //string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            MY_DB db = new MY_DB();
            string command = "SELECT Ngay, TenCa, PHAN_CONG.MaCL, PHAN_CONG.MaNV, HoTen, ChucVu, CheckIN, CheckOut, Note FROM CA_LAM, PHAN_CONG, NHAN_VIEN, NHANVIEN_CHUCVU,CHUC_VU WHERE PHAN_CONG.MaNV = NHAN_VIEN.MaNV AND PHAN_CONG.MaCL = CA_LAM.MaCL AND PHAN_CONG.MaNV = NHANVIEN_CHUCVU.MaNV AND NHANVIEN_CHUCVU.MaCV = CHUC_VU.MaCV AND Ngay = @Ngay";
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
            SqlDataAdapter da = new SqlDataAdapter(); 
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public DataTable GetTienLuong(string ngay)
        {
            //string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            MY_DB db = new MY_DB();
            string command = "SELECT NHAN_VIEN.MaNV, HoTen , Count(CA_LAM.MaCL) AS 'Số lượng ca làm', Sum(datediff(minute,CheckIn, CheckOut))/60 AS TongGio, (Sum(datediff(minute,CheckIn, CheckOut))/60 * 50000 ) AS LUONG FROM NHAN_VIEN, PHAN_CONG, CA_LAM WHERE NHAN_VIEN.MaNV = PHAN_CONG.MaNV AND PHAN_CONG.MaCL = CA_LAM.MaCL AND Ngay = @Ngay GROUP BY NHAN_VIEN.MaNV, HoTen";
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public DataTable GetAllNVKoLamMaCL(int ngay)
        {
            //string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            MY_DB db = new MY_DB();
            string command = "SELECT NHAN_VIEN.MaNV, HoTen, ChucVU FROM NHAN_VIEN, NHANVIEN_CHUCVU, CHUC_VU WHERE NHAN_VIEN.MaNV = NHANVIEN_CHUCVU.MaNV  AND NHANVIEN_CHUCVU.MaCV =  CHUC_VU.MaCV AND NOT EXISTS (SELECT NHAN_VIEN.MaNV FROM PHAN_CONG WHERE MaCL = @MaCL AND NHAN_VIEN.MaNV = PHAN_CONG.MaNV ) ";
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@MaCL", SqlDbType.Int).Value = ngay;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public DataTable GetLichLamViec()
        {
            //string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            MY_DB db = new MY_DB();
            string command = "SELECT Ngay AS 'Ngày', TenCa AS 'Tên Ca' , GioVao AS 'Gio Vào', GioRa AS 'Giờ ra' FROM PHAN_CONG, CA_LAM WHERE PHAN_CONG.MaCl = CA_LAM.MaCl AND MaNV = @MaNV AND Ngay >= @Ngay ORDER BY Ngay";
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = User.MaNV;
            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public DataTable CheckGioVao()
        {
            MY_DB db = new MY_DB();
            string command = "SELECT MaNV, CA_LAM.MaCL, CheckIn, CheckOut, GioVao, GioRa FROM PHAN_CONG, CA_LAM WHERE MaNV = @MaNV AND PHAN_CONG.MaCL = CA_LAM.MaCL AND Ngay = @Ngay AND GioRa > @GioRa AND CheckIn is NULL ORDER BY GioVao ";
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = User.MaNV;
            cmd.Parameters.Add("@GioRa", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public DataTable CheckGioRa()
        {
            MY_DB db = new MY_DB();
            string command = "SELECT MaNV, CA_LAM.MaCL, CheckIn, CheckOut, GioVao, GioRa FROM PHAN_CONG, CA_LAM WHERE MaNV = @MaNV AND PHAN_CONG.MaCL = CA_LAM.MaCL AND Ngay = @Ngay AND GioRa > @GioRa AND CheckIn IS NOT NULL AND CheckOut IS NULL ORDER BY GioVao ";
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = User.MaNV;
            cmd.Parameters.Add("@GioRa", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public DataTable GetCVByDayAndCL(string ngay, string tenca)
        {
            //string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            MY_DB db = new MY_DB();
            string command = "SELECT Ngay, TenCa, PHAN_CONG.MaCL, PHAN_CONG.MaNV, HoTen, ChucVu, CheckIN, CheckOut, Note FROM CA_LAM, PHAN_CONG, NHAN_VIEN, NHANVIEN_CHUCVU,CHUC_VU WHERE PHAN_CONG.MaNV = NHAN_VIEN.MaNV AND PHAN_CONG.MaCL = CA_LAM.MaCL AND PHAN_CONG.MaNV = NHANVIEN_CHUCVU.MaNV AND NHANVIEN_CHUCVU.MaCV = CHUC_VU.MaCV AND Ngay = @Ngay AND TenCa = @TenCa";
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
            cmd.Parameters.Add("@TenCa", SqlDbType.NVarChar).Value = tenca;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            return tb;
        }
        public int Getidquanly(int macl)
        {
            //string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            MY_DB db = new MY_DB();
            string command = "SELECT NHAN_VIEN.MaNV, HoTen, ChucVU FROM NHAN_VIEN, NHANVIEN_CHUCVU, CHUC_VU, PHAN_CONG WHERE NHAN_VIEN.MaNV = NHANVIEN_CHUCVU.MaNV  AND NHANVIEN_CHUCVU.MaCV = CHUC_VU.MaCV AND ChucVu = N'Quản lý' AND NHAN_VIEN.MaNV = PHAN_CONG.MaNV AND MaCL = @MaCL";
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@MaCL", SqlDbType.Int).Value = macl;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.closeConnection();
            if(tb.Rows.Count > 0)
            {
                return int.Parse(tb.Rows[0][0].ToString());
            }    
            else
            {
                return 0;
            }    
        }
        public bool InsertCV(ChamCong cv)
        {
            string command = "INSERT INTO PHAN_CONG ( MaNV, MaCL) VALUES (@MaNV, @MaCL)";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = cv.MaNV;
                cmd.Parameters.Add("@MaCL", SqlDbType.NVarChar).Value = cv.MaCL;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateCV(ChamCong cv)
        {
            string command = "UPDATE PHAN_CONG SET CheckIn = @CheckIn, CheckOut = @CheckOut, Note = @Note WHERE MaNV = @MaNV AND MaCL = @MaCL";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = cv.MaNV;
                cmd.Parameters.Add("@MaCL", SqlDbType.Int).Value = cv.MaCL;
                cmd.Parameters.Add("@CheckIn", SqlDbType.Time).Value = cv.CheckIn.Value.ToString("HH:mm");
                cmd.Parameters.Add("@CheckOut", SqlDbType.Time).Value = cv.CheckOut.Value.ToString("HH:mm");
                cmd.Parameters.Add("@Note", SqlDbType.NVarChar).Value = cv.Note;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DeleteCV(ChamCong cv)
        {
            string command = "DELETE PHAN_CONG WHERE MaNV = @MaNV AND MaCL = @MaCL";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = cv.MaNV;
                cmd.Parameters.Add("@MaCL", SqlDbType.Int).Value = cv.MaCL;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public bool CheckIN(ChamCong cv)
        {
            string command = "UPDATE PHAN_CONG SET CheckIn = @CheckIn WHERE MaNV = @MaNV AND MaCL = @MaCL";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = cv.MaNV;
                cmd.Parameters.Add("@MaCL", SqlDbType.Int).Value = cv.MaCL;
                cmd.Parameters.Add("@CheckIn", SqlDbType.Time).Value = cv.CheckIn.Value.ToString("HH:mm");
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public bool CheckOut(ChamCong cv)
        {
            string command = "UPDATE PHAN_CONG SET CheckOut = @CheckOut WHERE MaNV = @MaNV AND MaCL = @MaCL";
            MY_DB db = new MY_DB();
            try
            {
                cmd = new SqlCommand(command, db.getConnection);
                db.openConnection();
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = cv.MaNV;
                cmd.Parameters.Add("@MaCL", SqlDbType.Int).Value = cv.MaCL;
                cmd.Parameters.Add("@CheckOut", SqlDbType.Time).Value = cv.CheckOut.Value.ToString("HH:mm");
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
