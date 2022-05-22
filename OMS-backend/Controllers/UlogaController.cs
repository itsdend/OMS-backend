using DomainModel.Model;
using Infrastructure.Service.Contract_interface;
using Infrastructure.Service.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace OMS_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UlogaController : Controller
    {
        private readonly IUloga _uloga;

        public UlogaController(IUloga uloga)
        {
            this._uloga = uloga;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _uloga.GetSveUloge();
            return Ok(res);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_uloga.GetUloga(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Uloga uloga)
        {
            return Ok(_uloga.AddUloga(uloga));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_uloga.DeleteUloga(id));
        }
        [HttpPut("update")]
        public IActionResult Update(Uloga  uloga)
        {
            return Ok(_uloga.UpdateUloga(uloga));
        }
    }
}
