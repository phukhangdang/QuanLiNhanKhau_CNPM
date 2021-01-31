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
        IGenericRepository<NhanKhau> NhanKhauRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<ToKhaiYTe> ToKhaiYTeRepository { get; }
        IGenericRepository<ThongKeYTe> ThongKeYTeRepository { get; }
        IGenericRepository<TiepXuc> TiepXucRepository { get; }
        Task SaveAsync();
    }
}
