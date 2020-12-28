using Microsoft.EntityFrameworkCore;
using QuanLiNhanKhau_CNPM.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DatabaseContext dbContext;
        internal DbSet<TEntity> dbSet;
        public GenericRepository(DatabaseContext context)
        {
            dbContext = context;
            dbSet = context.Set<TEntity>();
        }
        public virtual void Create(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void DeleteByID(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
        }

        public virtual async Task<IEnumerable<TEntity>> Get(int pageNum, int pageSize)
        {
            if (pageNum == -1)
            {
                return dbSet.ToList();
            }
            else
            {
                var entity = from e in dbSet.Skip(pageNum * pageSize).Take(pageSize)
                             select e;
                return entity;
            }
        }

        public virtual async Task<TEntity> GetByID(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            dbContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
