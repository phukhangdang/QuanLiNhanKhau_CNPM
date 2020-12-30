using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.TiepXucService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiepXucController : ControllerBase
    {
        private readonly ITiepXucService _tiepXucService;
        public TiepXucController(ITiepXucService tiepXucService)
        {
            _tiepXucService = tiepXucService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<TiepXucDto>> Get(int pageNum, int pageSize)
        {
            return await _tiepXucService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<TiepXucDto> Get(int id)
        {
            return await _tiepXucService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<TiepXucDto> Post([FromBody] TiepXucDto Dto)
        {
            return await _tiepXucService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<TiepXucDto> Put([FromBody] TiepXucDto Dto)
        {
            return await _tiepXucService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _tiepXucService.DeleteAsync(id);
        }
    }
}
