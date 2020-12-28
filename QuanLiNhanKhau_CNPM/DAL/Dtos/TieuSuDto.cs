using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Dtos
{
    public class TieuSuDto
    {
        public int ID { get; set; }
        public int IDNhanKhau { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string DiaChi { get; set; }
        public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
    }
}
