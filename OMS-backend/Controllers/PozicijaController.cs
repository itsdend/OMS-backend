using DomainModel.Model;
using Infrastructure.Service.Contract_interface;
using Microsoft.AspNetCore.Mvc;

namespace OMS_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PozicijaController : Controller
    {
        private readonly IPozicija _pozicija;

        public PozicijaController(IPozicija pozicija)
        {
            this._pozicija = pozicija;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _pozicija.GetSvePozicije();
            return Ok(res);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_pozicija.GetPozicija(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Pozicija pozicija)
        {
            return Ok(_pozicija.AddPozicija(pozicija));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_pozicija.DeletePozicija(id));
        }
        [HttpPut("update")]
        public IActionResult Update(Pozicija pozicija)
        {
            return Ok(_pozicija.UpdatePozicija(pozicija));
        }
    }
}
