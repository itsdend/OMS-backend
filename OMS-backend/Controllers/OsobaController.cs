using DomainModel.Model;
using Infrastructure.Service.Contract_interface;
using Microsoft.AspNetCore.Mvc;

namespace OMS_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OsobaController : Controller
    {
        private readonly IOsoba _osoba;

        public OsobaController(IOsoba osoba)
        {
            this._osoba = osoba;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _osoba.GetSveOsobe();
            return Ok(res);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_osoba.GetOsoba(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Osoba osoba)
        {
            return Ok(_osoba.AddOsoba(osoba));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_osoba.DeleteOsoba(id));
        }
        [HttpPut("update")]
        public IActionResult Update(Osoba osoba)
        {
            return Ok(_osoba.UpdateOsoba(osoba));
        }
    }
}
