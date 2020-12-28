using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using QuanLiNhanKhau_CNPM.DAL.Repository.GenericRepository;
using QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork;
using QuanLiNhanKhau_CNPM.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.Services.ChungMinhThuService
{
    public class ChungMinhThuService : BaseService<ChungMinhThu, ChungMinhThuDto>, IChungMinhThuService
    {
        public ChungMinhThuService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        protected override IGenericRepository<ChungMinhThu> _reponsitory => _unitOfWork.ChungMinhThuRepository;
    }
}
