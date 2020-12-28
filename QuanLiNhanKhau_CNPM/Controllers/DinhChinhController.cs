using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.DinhChinhService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinhChinhController : ControllerBase
    {
        private readonly IDinhChinhService _dinhChinhService;
        public DinhChinhController(IDinhChinhService dinhChinhService)
        {
            _dinhChinhService = dinhChinhService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<DinhChinhDto>> Get(int pageNum, int pageSize)
        {
            return await _dinhChinhService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<DinhChinhDto> Get(int id)
        {
            return await _dinhChinhService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<DinhChinhDto> Post([FromBody] DinhChinhDto Dto)
        {
            return await _dinhChinhService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<DinhChinhDto> Put([FromBody] DinhChinhDto Dto)
        {
            return await _dinhChinhService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _dinhChinhService.DeleteAsync(id);
        }
    }
}
