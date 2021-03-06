﻿using AutoMapper;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.Services.ThongKeService
{
    public class ThongKeService : IThongKeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ThongKeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<NhanKhauDto>> GetDaKhaiBao()
        {
            List<NhanKhau> Temp = new List<NhanKhau>();
            IEnumerable<NhanKhau> NhanKhaus = await _unitOfWork.NhanKhauRepository.Get(-1, 0);
            IEnumerable<ToKhaiYTe> ToKhaiYTes = await _unitOfWork.ToKhaiYTeRepository.Get(-1, 0);
            foreach (var toKhai in ToKhaiYTes)
            {
                foreach (var nhanKhau in NhanKhaus)
                {
                    if (toKhai.NhanKhauID == nhanKhau.ID) Temp.Add(nhanKhau);
                }
            }
            IEnumerable<NhanKhau> except = NhanKhaus.Except<NhanKhau>(Temp);
            return EntityToDto(NhanKhaus.Except<NhanKhau>(except));
        }

        public async Task<IEnumerable<NhanKhauDto>> GetChuaKhaiBao()
        {
            List<NhanKhau> Temp = new List<NhanKhau>();
            IEnumerable<NhanKhau> NhanKhaus = await _unitOfWork.NhanKhauRepository.Get(-1, 0);
            IEnumerable<ToKhaiYTe> ToKhaiYTes = await _unitOfWork.ToKhaiYTeRepository.Get(-1, 0);
            foreach (var toKhai in ToKhaiYTes)
            {
                foreach (var nhanKhau in NhanKhaus)
                {
                    if (toKhai.NhanKhauID == nhanKhau.ID) Temp.Add(nhanKhau);
                }
            }
            return EntityToDto(NhanKhaus.Except<NhanKhau>(Temp));

        }
        protected List<NhanKhauDto> EntityToDto(List<NhanKhau> entities)
        {
            return Mapper.Map<List<NhanKhauDto>>(entities);
        }
        protected IEnumerable<NhanKhauDto> EntityToDto(IEnumerable<NhanKhau> entities)
        {
            return Mapper.Map<IEnumerable<NhanKhauDto>>(entities);
        }
    }
}
