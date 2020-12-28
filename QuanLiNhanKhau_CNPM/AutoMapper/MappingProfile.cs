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
            CreateMap<ChungMinhThu, ChungMinhThuDto>();
            CreateMap<DinhChinh, DinhChinhDto>();
            CreateMap<GiaDinh, GiaDinhDto>();
            CreateMap<HoKhau, HoKhauDto>();
            CreateMap<KhaiTu, KhaiTuDto>();
            CreateMap<NhanKhau, NhanKhauDto>();
            CreateMap<TamTru, TamTruDto>();
            CreateMap<TamVang, TamVangDto>();
            CreateMap<ThanhVienCuaHo, ThanhVienCuaHoDto>();
            CreateMap<TieuSu, TieuSuDto>();
            CreateMap<User, UserDto>();

            // Dto to Entity
            CreateMap<ChungMinhThuDto, ChungMinhThu>();
            CreateMap<DinhChinhDto, DinhChinh>();
            CreateMap<GiaDinhDto, GiaDinh>();
            CreateMap<HoKhauDto, HoKhau>();
            CreateMap<KhaiTuDto, KhaiTu>();
            CreateMap<NhanKhauDto, NhanKhau>();
            CreateMap<TamTruDto, TamTru>();
            CreateMap<TamVangDto, TamVang>();
            CreateMap<ThanhVienCuaHoDto, ThanhVienCuaHo>();
            CreateMap<TieuSuDto, TieuSu>();
            CreateMap<UserDto, User>();

        }
        
    }
}
