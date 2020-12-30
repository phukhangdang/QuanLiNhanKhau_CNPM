using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Entities
{
    public class TamVang
    {
        public int ID { get; set; }
        public int NhanKhauID { get; set; }
        public string MaGiayTamVang { get; set; }
        public int NoiTamTru { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string LyDo { get; set; }
    }
}
