﻿using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.LoginService;
using QuanLiNhanKhau_CNPM.Services.ThongKeService;
using QuanLiNhanKhau_CNPM.Services.UserService;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILoginService _loginService;
        private readonly IThongKeService _thongKeService;
        public UserController(IUserService userService, ILoginService loginService, IThongKeService thongKeService)
        {
            _userService = userService;
            _loginService = loginService;
            _thongKeService = thongKeService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get(int pageNum, int pageSize)
        {
            return await _userService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> Get(int id)
        {
            return await _userService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserDto> Post([FromBody] UserDto Dto)
        {
            return await _userService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<UserDto> Put([FromBody] UserDto Dto)
        {
            return await _userService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
        [Route("login"), HttpPut]
        public async Task<UserDto> Login([FromBody] UserDto Dto)
        {
            return await _loginService.LoginAsync(Dto);
        }
    }
}
