using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.KhaiTuService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhaiTuController : ControllerBase
    {
        private readonly IKhaiTuService _khaiTuService;
        public KhaiTuController(IKhaiTuService khaiTuService)
        {
            _khaiTuService = khaiTuService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<KhaiTuDto>> Get(int pageNum, int pageSize)
        {
            return await _khaiTuService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<KhaiTuDto> Get(int id)
        {
            return await _khaiTuService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<KhaiTuDto> Post([FromBody] KhaiTuDto Dto)
        {
            return await _khaiTuService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<KhaiTuDto> Put([FromBody] KhaiTuDto Dto)
        {
            return await _khaiTuService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _khaiTuService.DeleteAsync(id);
        }
    }
}
