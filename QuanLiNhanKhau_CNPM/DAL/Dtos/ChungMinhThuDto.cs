using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Dtos
{
    public class ChungMinhThuDto
    {
        public int ID { get; set; }
        public int NhanKhauID { get; set; }
        public string SoCMT { get; set; }
        public DateTime NgayCap { get; set; }
        public string NoiCap { get; set; }
    }
}
