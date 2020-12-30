using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Entities
{
    public class GiaDinh
    {
        public int ID { get; set; }
        public int NhanKhauID { get; set; }
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string QuanHeVoiNhanKhau { get; set; }
        public string NgheNghiep { get; set; }
        public string DiaChiHienTai { get; set; }

    }
}
