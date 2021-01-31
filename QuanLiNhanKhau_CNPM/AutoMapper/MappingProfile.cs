using AutoMapper;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Entity to Dto
            CreateMap<NhanKhau, NhanKhauDto>();
            CreateMap<User, UserDto>();
            CreateMap<ToKhaiYTe, ToKhaiYTeDto>();
            CreateMap<ThongKeYTe, ThongKeYTeDto>();
            CreateMap<TiepXuc, TiepXucDto>();

            // Dto to Entity
            CreateMap<NhanKhauDto, NhanKhau>();
            CreateMap<UserDto, User>();
            CreateMap<ToKhaiYTeDto, ToKhaiYTe>();
            CreateMap<ThongKeYTeDto, ThongKeYTe>();
            CreateMap<TiepXucDto, TiepXuc>();

        }
        
    }
}
