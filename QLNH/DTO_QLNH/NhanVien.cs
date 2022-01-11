using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DTO_QLNH
{
    class NhanVien
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public byte[] Anh { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
