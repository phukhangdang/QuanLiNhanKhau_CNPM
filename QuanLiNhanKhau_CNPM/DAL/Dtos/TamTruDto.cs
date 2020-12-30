using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Dtos
{
    public class TamTruDto
    {
        public int ID { get; set; }
        public int NhanKhauID { get; set; }
        public string MaGiayTamTru { get; set; }
        public string SoDienThoaiNguoiDangKy { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string LyDo { get; set; }
    }
}
