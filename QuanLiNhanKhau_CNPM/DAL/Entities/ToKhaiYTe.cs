using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Entities
{
    public class ToKhaiYTe
    {
        public int ID { get; set; }
        public int NhanKhauID { get; set; }
        public bool Sot { get; set; }
        public bool Ho { get; set; }
        public bool KhoTho { get; set; }
        public bool ViemPhoi { get; set; }
        public bool DauHong { get; set; }
        public bool MetMoi { get; set; }
        public string TrangThaiCachLy { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public bool KetQuaXetNghiem { get; set; }
        public string HinhThucTest { get; set; }
        public string TiepXuc { get; set; }
    }
}
