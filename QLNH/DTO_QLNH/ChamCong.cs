using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DTO_QLNH
{
    class ChamCong
    {
        public int MaNV { get; set; }
        public int MaCL { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string Note { get; set; }
    }
}
