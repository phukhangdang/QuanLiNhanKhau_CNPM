using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Entities
{
    public class ThanhVienCuaHo
    {
        public int ID { get; set; }
        public int NhanKhauID { get; set; }
        public int HoKhauID { get; set; }
        public string QuanHeVoiChuHo { get; set; }

    }
}
