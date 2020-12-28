using AutoMapper;
using QuanLiNhanKhau_CNPM.DAL.Repository.GenericRepository;
using QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.Services.BaseService
{
    public abstract class BaseService<TEntity, TDto> : IBaseService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected abstract IGenericRepository<TEntity> _reponsitory { get; }

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public virtual async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = DtoToEntity(dto);
            _reponsitory.Create(entity);
            await _unitOfWork.SaveAsync();
            return EntityToDto(entity);
        }

        public virtual async Task<TDto> UpdateAsync(TDto dto)
        {
            var entity = DtoToEntity(dto);
            _reponsitory.Update(entity);
            await _unitOfWork.SaveAsync();
            return EntityToDto(entity);
        }

        public virtual async Task DeleteAsync(object id)
        {
            var entity = await _reponsitory.GetByID(id);
            if (entity == null) throw new Exception("Not found entity object with id: " + id);
            _reponsitory.DeleteByID(entity);
            await _unitOfWork.SaveAsync();
        }

        public virtual async Task<TDto> FindByIdAsync(object id)
        {
            return EntityToDto(await _reponsitory.GetByID(id));

        }

        public virtual async Task<IEnumerable<TDto>> FindAsync(int pageNum, int pageSize)
        {
            return EntityToDto(await _reponsitory.Get(pageNum, pageSize));
        }
        protected TDto EntityToDto(TEntity entity)
        {
            return Mapper.Map<TDto>(entity);
        }

        protected TEntity DtoToEntity(TDto dto)
        {
            return Mapper.Map<TEntity>(dto);
        }

        protected TEntity DtoToEntity(TDto dto, TEntity entity)
        {
            return Mapper.Map(dto, entity);
        }

        protected IEnumerable<TDto> EntityToDto(IEnumerable<TEntity> entities)
        {
            return Mapper.Map<IEnumerable<TDto>>(entities);
        }

        protected IEnumerable<TEntity> DtoToEntity(IEnumerable<TDto> dto)
        {
            return Mapper.Map<IEnumerable<TEntity>>(dto);
        }
    }
}
