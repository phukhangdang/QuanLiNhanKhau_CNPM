using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.ChungMinhThuService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChungMinhThuController : ControllerBase
    {
        private readonly IChungMinhThuService _chungMinhThuService;
        public ChungMinhThuController(IChungMinhThuService chungMinhThuService)
        {
            _chungMinhThuService = chungMinhThuService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<ChungMinhThuDto>> Get(int pageNum, int pageSize)
        {
            return await _chungMinhThuService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ChungMinhThuDto> Get(int id)
        {
            return await _chungMinhThuService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ChungMinhThuDto> Post([FromBody] ChungMinhThuDto Dto)
        {
            return await _chungMinhThuService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<ChungMinhThuDto> Put([FromBody] ChungMinhThuDto Dto)
        {
            return await _chungMinhThuService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _chungMinhThuService.DeleteAsync(id);
        }
    }
}
