using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Dtos
{
    public class NhanKhauDto
    {
        public int ID { get; set; }
        public string MaNhanKhau { get; set; }
        public string HoTen { get; set; }
        public string BietDanh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public string NguyenQuan { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string QuocTich { get; set; }
        public string SoHoChieu { get; set; }
        public string NoiThuongTru { get; set; }
        public string DiaChiHienNay { get; set; }
        public string TrinhDoHocVan { get; set; }
        public string TrinhDoChuyenMon { get; set; }
        public string BietTiengDanToc { get; set; }
        public string TrinhDoNgoaiNgu { get; set; }
        public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        public string TienAn { get; set; }
        public DateTime NgayChuyenDen { get; set; }
        public string LiDoChuyenDen { get; set; }
        public DateTime NgayChuyenDI { get; set; }
        public string LiDoChuyenDi { get; set; }
        public string DiaChiMoi { get; set; }
        public DateTime NgayTao { get; set; }
        public int IDNguoiTao { get; set; }
        public DateTime NgayXoa { get; set; }
        public int IDNguoiXoa { get; set; }
        public string LyDoXoa { get; set; }
        public string GhiChu { get; set; }
        public IEnumerable<ChungMinhThuDto> ChungMinhThus { get; set; }
        public IEnumerable<GiaDinhDto> GiaDinhs { get; set; }
        public IEnumerable<TamTruDto> TamTrus { get; set; }
        public IEnumerable<TamVangDto> TamVangs { get; set; }
        public IEnumerable<KhaiTuDto> KhaiTus { get; set; }
        public IEnumerable<ThanhVienCuaHoDto> ThanhVienCuaHos { get; set; }
        public IEnumerable<TieuSuDto> TieuSus { get; set; }
        public IEnumerable<ToKhaiYTeDto> ToKhaiYTes { get; set; }
        public IEnumerable<TinhTrangCachLyDto> TinhTrangCachLys { get; set; }

    }
}
