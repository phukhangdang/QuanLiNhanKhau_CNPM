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
        public IGenericRepository<NhanKhau> NhanKhauRepository { get; private set; }
        public IGenericRepository<User> UserRepository { get; private set; }
        public IGenericRepository<ToKhaiYTe> ToKhaiYTeRepository { get; private set; }
        public IGenericRepository<ThongKeYTe> ThongKeYTeRepository { get; private set; }
        public IGenericRepository<TiepXuc> TiepXucRepository { get; private set; }

        public UnitOfWork(DatabaseContext context)
        {
            this.dbContext = context;
            InitRepositories();
        }
        private void InitRepositories()
        {
            NhanKhauRepository = new GenericRepository<NhanKhau>(dbContext);
            UserRepository = new GenericRepository<User>(dbContext);
            ToKhaiYTeRepository = new GenericRepository<ToKhaiYTe>(dbContext);
            ThongKeYTeRepository = new GenericRepository<ThongKeYTe>(dbContext);
            TiepXucRepository = new GenericRepository<TiepXuc>(dbContext);
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
