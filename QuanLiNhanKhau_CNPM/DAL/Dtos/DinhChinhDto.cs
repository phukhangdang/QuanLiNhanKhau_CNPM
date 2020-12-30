using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Dtos
{
    public class DinhChinhDto
    {
        public int ID { get; set; }
        public int HoKhauID { get; set; }
        public string ThayDoiTu { get; set; }
        public string ThayDoiThanh { get; set; }
        public DateTime NgayThayDoi { get; set; }
        public int NguoiThayDoi { get; set; }
    }
}
