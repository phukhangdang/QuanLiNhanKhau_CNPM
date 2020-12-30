using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Dtos
{
    public class TiepXucDto
    {
        public int ID { get; set; }
        public int NhanKhauID { get; set; }
        public IEnumerable<NhanKhauDto> NguoiDaTiepXuc { get; set; }
    }
}
