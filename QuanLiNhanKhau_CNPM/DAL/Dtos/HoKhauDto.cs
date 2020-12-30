using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Dtos
{
    public class HoKhauDto
    {
        public int ID { get; set; }
        public string MaHoKhau { get; set; }
        public int ChuHoID { get; set; }
        public string MaKhuVuc { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayChuyenDi { get; set; }
        public string LyDoChuyen { get; set; }
        public int NguoiThucHien { get; set; }
        public IEnumerable<ThanhVienCuaHoDto> ThanhVienCuaHos { get; set; }
        public IEnumerable<DinhChinhDto> DinhChinhs { get; set; }
    }
}
