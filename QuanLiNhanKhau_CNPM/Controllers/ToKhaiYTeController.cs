using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.ToKhaiYTeService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToKhaiYTeController : ControllerBase
    {
        private readonly IToKhaiYTeService _toKhaiYTeService;
        public ToKhaiYTeController(IToKhaiYTeService toKhaiYTeService)
        {
            _toKhaiYTeService = toKhaiYTeService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<ToKhaiYTeDto>> Get(int pageNum, int pageSize)
        {
            return await _toKhaiYTeService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ToKhaiYTeDto> Get(int id)
        {
            return await _toKhaiYTeService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ToKhaiYTeDto> Post([FromBody] ToKhaiYTeDto Dto)
        {
            return await _toKhaiYTeService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<ToKhaiYTeDto> Put([FromBody] ToKhaiYTeDto Dto)
        {
            return await _toKhaiYTeService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _toKhaiYTeService.DeleteAsync(id);
        }
    }
}
