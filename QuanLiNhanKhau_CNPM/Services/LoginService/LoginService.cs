using AutoMapper;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<UserDto> LoginAsync(UserDto Dto)
        {
            IEnumerable<User> Users = await _unitOfWork.UserRepository.Get(-1, 0);
            foreach (var Entity in Users)
            {
                if (Entity.UserName == Dto.UserName && Entity.Password == Dto.Password) return EntityToDto(Entity, Dto);
            }
            return Dto;
        }
        protected User DtoToEntity(UserDto dto, User entity)
        {
            return Mapper.Map(dto, entity);
        }
        protected UserDto EntityToDto(User entity, UserDto dto)
        {
            return Mapper.Map(entity, dto);
        }
    }
}
