using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.HoKhauService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoKhauController : ControllerBase
    {
        private readonly IHoKhauService _hoKhauService;
        public HoKhauController(IHoKhauService hoKhauService)
        {
            _hoKhauService = hoKhauService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<HoKhauDto>> Get(int pageNum, int pageSize)
        {
            return await _hoKhauService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<HoKhauDto> Get(int id)
        {
            return await _hoKhauService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<HoKhauDto> Post([FromBody] HoKhauDto Dto)
        {
            return await _hoKhauService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<HoKhauDto> Put([FromBody] HoKhauDto Dto)
        {
            return await _hoKhauService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _hoKhauService.DeleteAsync(id);
        }
    }
}
