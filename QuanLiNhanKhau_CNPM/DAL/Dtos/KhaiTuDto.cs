using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Dtos
{
    public class KhaiTuDto
    {
        public int ID { get; set; }
        public string SoGiayKhaiTu { get; set; }
        public string NguoiKhaiID { get; set; }
        public string NguoiChetID { get; set; }
        public DateTime NgayKhai { get; set; }
        public DateTime NgayChet { get; set; }
        public string LyDoChet { get; set; }
    }
}
