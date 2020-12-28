using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.Services.BaseService
{
    public interface IBaseService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        Task<TDto> CreateAsync(TDto dto);

        Task<TDto> UpdateAsync(TDto dto);

        Task DeleteAsync(object keyValues);

        Task<TDto> FindByIdAsync(object keyValues);

        Task<IEnumerable<TDto>> FindAsync(int pageNum, int pageSize);
    }
}
