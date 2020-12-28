using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiNhanKhau_CNPM.DAL.Dtos;
using QuanLiNhanKhau_CNPM.Services.TamTruService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLiNhanKhau_CNPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamTruController : ControllerBase
    {
        private readonly ITamTruService _tamTruService;
        public TamTruController(ITamTruService tamTruService)
        {
            _tamTruService = tamTruService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<TamTruDto>> Get(int pageNum, int pageSize)
        {
            return await _tamTruService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<TamTruDto> Get(int id)
        {
            return await _tamTruService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<TamTruDto> Post([FromBody] TamTruDto Dto)
        {
            return await _tamTruService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<TamTruDto> Put([FromBody] TamTruDto Dto)
        {
            return await _tamTruService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _tamTruService.DeleteAsync(id);
        }
    }
}
