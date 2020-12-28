using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using QuanLiNhanKhau_CNPM.DAL.Repository.GenericRepository;
using QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork;
using QuanLiNhanKhau_CNPM.Services.BaseService;

namespace QuanLiNhanKhau_CNPM.Services.DinhChinhService
{
    public class DinhChinhService : BaseService<DinhChinh, DinhChinhDto>, IDinhChinhService
    {
        public DinhChinhService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        protected override IGenericRepository<DinhChinh> _reponsitory => _unitOfWork.DinhChinhRepository;
    }
}
