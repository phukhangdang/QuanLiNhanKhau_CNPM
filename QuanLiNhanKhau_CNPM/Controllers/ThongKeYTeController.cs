using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.TinhTrangCachLyService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongKeYTeController : ControllerBase
    {
        private readonly IThongKeYTeService _thongKeYTeService;
        public ThongKeYTeController(IThongKeYTeService thongKeYTeService)
        {
            _thongKeYTeService = thongKeYTeService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<ThongKeYTeDto>> Get(int pageNum, int pageSize)
        {
            return await _thongKeYTeService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ThongKeYTeDto> Get(int id)
        {
            return await _thongKeYTeService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ThongKeYTeDto> Post([FromBody] ThongKeYTeDto Dto)
        {
            return await _thongKeYTeService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<ThongKeYTeDto> Put([FromBody] ThongKeYTeDto Dto)
        {
            return await _thongKeYTeService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _thongKeYTeService.DeleteAsync(id);
        }
    }
}
