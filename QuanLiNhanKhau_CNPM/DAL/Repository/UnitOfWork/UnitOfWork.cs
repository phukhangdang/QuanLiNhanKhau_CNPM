using QuanLiNhanKhau_CNPM.DAL.Database;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using QuanLiNhanKhau_CNPM.DAL.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        internal DatabaseContext dbContext;
        public IGenericRepository<ChungMinhThu> ChungMinhThuRepository { get; private set; }
        public IGenericRepository<DinhChinh> DinhChinhRepository { get; private set; }
        public IGenericRepository<GiaDinh> GiaDinhRepository { get; private set; }
        public IGenericRepository<HoKhau> HoKhauRepository { get; private set; }
        public IGenericRepository<KhaiTu> KhaiTuRepository { get; private set; }
        public IGenericRepository<NhanKhau> NhanKhauRepository { get; private set; }
        public IGenericRepository<TamTru> TamTruRepository { get; private set; }
        public IGenericRepository<TamVang> TamVangRepository { get; private set; }
        public IGenericRepository<ThanhVienCuaHo> ThanhVienCuaHoRepository { get; private set; }
        public IGenericRepository<TieuSu> TieuSuRepository { get; private set; }
        public IGenericRepository<User> UserRepository { get; private set; }
        public IGenericRepository<ToKhaiYTe> ToKhaiYTeRepository { get; private set; }
        public IGenericRepository<ThongKeYTe> ThongKeYTeRepository { get; private set; }

        public UnitOfWork(DatabaseContext context)
        {
            this.dbContext = context;
            InitRepositories();
        }
        private void InitRepositories()
        {
            ChungMinhThuRepository = new GenericRepository<ChungMinhThu>(dbContext);
            DinhChinhRepository = new GenericRepository<DinhChinh>(dbContext);
            GiaDinhRepository = new GenericRepository<GiaDinh>(dbContext);
            HoKhauRepository = new GenericRepository<HoKhau>(dbContext);
            KhaiTuRepository = new GenericRepository<KhaiTu>(dbContext);
            NhanKhauRepository = new GenericRepository<NhanKhau>(dbContext);
            TamTruRepository = new GenericRepository<TamTru>(dbContext);
            TamVangRepository = new GenericRepository<TamVang>(dbContext);
            ThanhVienCuaHoRepository = new GenericRepository<ThanhVienCuaHo>(dbContext);
            TieuSuRepository = new GenericRepository<TieuSu>(dbContext);
            UserRepository = new GenericRepository<User>(dbContext);
            ToKhaiYTeRepository = new GenericRepository<ToKhaiYTe>(dbContext);
            ThongKeYTeRepository = new GenericRepository<ThongKeYTe>(dbContext);
        }

        public async Task SaveAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
