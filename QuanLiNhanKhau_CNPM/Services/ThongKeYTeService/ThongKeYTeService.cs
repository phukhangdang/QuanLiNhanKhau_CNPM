﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using QuanLiNhanKhau_CNPM.DAL.Repository.GenericRepository;
using QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork;
using QuanLiNhanKhau_CNPM.Services.BaseService;

namespace QuanLiNhanKhau_CNPM.Services.TinhTrangCachLyService
{
    public class ThongKeYTeService : BaseService<ThongKeYTe, ThongKeYTeDto>, IThongKeYTeService
    {
        public ThongKeYTeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        protected override IGenericRepository<ThongKeYTe> _reponsitory => _unitOfWork.ThongKeYTeRepository;
    }
}
