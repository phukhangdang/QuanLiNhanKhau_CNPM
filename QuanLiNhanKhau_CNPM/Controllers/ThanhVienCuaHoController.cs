using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.ThanhVienCuaHoService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThanhVienCuaHoController : ControllerBase
    {
        private readonly IThanhVienCuaHoService _thanhVienCuaHoService;
        public ThanhVienCuaHoController(IThanhVienCuaHoService thanhVienCuaHoService)
        {
            _thanhVienCuaHoService = thanhVienCuaHoService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<ThanhVienCuaHoDto>> Get(int pageNum, int pageSize)
        {
            return await _thanhVienCuaHoService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ThanhVienCuaHoDto> Get(int id)
        {
            return await _thanhVienCuaHoService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ThanhVienCuaHoDto> Post([FromBody] ThanhVienCuaHoDto Dto)
        {
            return await _thanhVienCuaHoService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<ThanhVienCuaHoDto> Put([FromBody] ThanhVienCuaHoDto Dto)
        {
            return await _thanhVienCuaHoService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _thanhVienCuaHoService.DeleteAsync(id);
        }
    }
}
