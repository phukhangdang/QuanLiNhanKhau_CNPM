using QuanLiNhanKhau_CNPM.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.Services.LoginService
{
    public interface ILoginService
    {
        public Task<UserDto> LoginAsync(UserDto Dto);
    }
}
