using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Entities
{
    public class KhaiTu
    {
        public int ID { get; set; }
        public string SoGiayKhaiTu { get; set; }
        public string IDNguoiKhai { get; set; }
        public string IDNguoiChet { get; set; }
        public DateTime NgayKhai { get; set; }
        public DateTime NgayChet { get; set; }
        public string LyDoChet { get; set; }

    }
}
