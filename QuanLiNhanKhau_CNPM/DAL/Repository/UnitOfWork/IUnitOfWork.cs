using QuanLiNhanKhau_CNPM.DAL.Entities;
using QuanLiNhanKhau_CNPM.DAL.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<ChungMinhThu> ChungMinhThuRepository { get; }
        IGenericRepository<DinhChinh> DinhChinhRepository { get; }
        IGenericRepository<GiaDinh> GiaDinhRepository { get; }
        IGenericRepository<HoKhau> HoKhauRepository { get; }
        IGenericRepository<KhaiTu> KhaiTuRepository { get; }
        IGenericRepository<NhanKhau> NhanKhauRepository { get; }
        IGenericRepository<TamTru> TamTruRepository { get; }
        IGenericRepository<TamVang> TamVangRepository { get; }
        IGenericRepository<ThanhVienCuaHo> ThanhVienCuaHoRepository { get; }
        IGenericRepository<TieuSu> TieuSuRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<ToKhaiYTe> ToKhaiYTeRepository { get; }
        IGenericRepository<ThongKeYTe> ThongKeYTeRepository { get; }
        Task SaveAsync();
    }
}
