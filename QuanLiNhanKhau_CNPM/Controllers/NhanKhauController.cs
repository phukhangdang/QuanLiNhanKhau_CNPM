using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.NhanKhauService;
using QuanLiNhanKhau_CNPM.Services.ThongKeService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanKhauController : ControllerBase
    {
        private readonly INhanKhauService _nhanKhauService;
        private readonly IThongKeService _thongKeService;
        public NhanKhauController(INhanKhauService nhanKhauService, IThongKeService thongKeService)
        {
            _nhanKhauService = nhanKhauService;
            _thongKeService = thongKeService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<NhanKhauDto>> Get(int pageNum, int pageSize)
        {
            return await _nhanKhauService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<NhanKhauDto> Get(int id)
        {
            return await _nhanKhauService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<NhanKhauDto> Post([FromBody] NhanKhauDto Dto)
        {
            return await _nhanKhauService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<NhanKhauDto> Put([FromBody] NhanKhauDto Dto)
        {
            return await _nhanKhauService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _nhanKhauService.DeleteAsync(id);
        }
        [Route("thongke/dakhaibao"), HttpGet]
        public async Task<IEnumerable<NhanKhauDto>> GetDaKhaiBao()
        {
            return await _thongKeService.GetDaKhaiBao();
        }
        [Route("thongke/chuakhaibao"), HttpGet]
        public async Task<IEnumerable<NhanKhauDto>> GetChuaKhaiBao()
        {
            return await _thongKeService.GetChuaKhaiBao();
        }
    }
}
