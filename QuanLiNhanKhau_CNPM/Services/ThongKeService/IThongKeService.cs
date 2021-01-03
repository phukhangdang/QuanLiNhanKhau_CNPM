using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.Services.ThongKeService
{
    public interface IThongKeService
    {
        public Task<IEnumerable<NhanKhauDto>> GetChuaKhaiBao();
        public Task<IEnumerable<NhanKhauDto>> GetDaKhaiBao();
    }
}
