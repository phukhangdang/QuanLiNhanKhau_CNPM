using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Entities
{
    public class TiepXuc
    {
        public int ID { get; set; }
        public int NhanKhauID { get; set; }
        public IEnumerable<NhanKhau> NguoiDaTiepXuc { get; set; }
    }
}
