using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.GiaDinhService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaDinhController : ControllerBase
    {
        private readonly IGiaDinhService _giaDinhService;
        public GiaDinhController(IGiaDinhService giaDinhService)
        {
            _giaDinhService = giaDinhService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<GiaDinhDto>> Get(int pageNum, int pageSize)
        {
            return await _giaDinhService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<GiaDinhDto> Get(int id)
        {
            return await _giaDinhService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<GiaDinhDto> Post([FromBody] GiaDinhDto Dto)
        {
            return await _giaDinhService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<GiaDinhDto> Put([FromBody] GiaDinhDto Dto)
        {
            return await _giaDinhService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _giaDinhService.DeleteAsync(id);
        }
    }
}
