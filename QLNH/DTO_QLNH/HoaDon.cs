using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DTO_QLNH
{
    class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaCL { get; set; }
        public int MaBan { get; set; }
        public int MaNV { get; set; }
        public int TongTien { get; set; }
        public DateTime? GioVao { get; set; }
        public DateTime? GioRa { get; set; }
        public string Status { get; set; }
    }
}
