using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using QuanLiNhanKhau_CNPM.DAL.Repository.GenericRepository;
using QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork;
using QuanLiNhanKhau_CNPM.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.Services.TiepXucService
{
    public class TiepXucService : BaseService<TiepXuc, TiepXucDto>, ITiepXucService
    {
        public TiepXucService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        protected override IGenericRepository<TiepXuc> _reponsitory => _unitOfWork.TiepXucRepository;
    }
}
