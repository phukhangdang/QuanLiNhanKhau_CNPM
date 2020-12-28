using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Entities
{
    public class HoKhau
    {
        public int ID { get; set; }
        public string MaHoKhau { get; set; }
        public int IDChuHo { get; set; }
        public string MaKhuVuc { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayChuyenDi { get; set; }
        public string LyDoChuyen { get; set; }
        public int NguoiThucHien { get; set; }
        public IEnumerable<ThanhVienCuaHo> ThanhVienCuaHos { get; set; }
        public IEnumerable<DinhChinh> DinhChinhs { get; set; }

    }
}
