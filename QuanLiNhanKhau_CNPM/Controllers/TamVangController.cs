using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.TamVangService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamVangController : ControllerBase
    {
        private readonly ITamVangService _tamVangService;
        public TamVangController(ITamVangService tamVangService)
        {
            _tamVangService = tamVangService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<TamVangDto>> Get(int pageNum, int pageSize)
        {
            return await _tamVangService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<TamVangDto> Get(int id)
        {
            return await _tamVangService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<TamVangDto> Post([FromBody] TamVangDto Dto)
        {
            return await _tamVangService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<TamVangDto> Put([FromBody] TamVangDto Dto)
        {
            return await _tamVangService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _tamVangService.DeleteAsync(id);
        }
    }
}
