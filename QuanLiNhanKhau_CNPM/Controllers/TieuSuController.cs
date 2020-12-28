using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.TieuSuService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TieuSuController : ControllerBase
    {
        private readonly ITieuSuService _tieuSuService;
        public TieuSuController(ITieuSuService tieuSuService)
        {
            _tieuSuService = tieuSuService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<TieuSuDto>> Get(int pageNum, int pageSize)
        {
            return await _tieuSuService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<TieuSuDto> Get(int id)
        {
            return await _tieuSuService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<TieuSuDto> Post([FromBody] TieuSuDto Dto)
        {
            return await _tieuSuService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<TieuSuDto> Put([FromBody] TieuSuDto Dto)
        {
            return await _tieuSuService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _tieuSuService.DeleteAsync(id);
        }
    }
}
