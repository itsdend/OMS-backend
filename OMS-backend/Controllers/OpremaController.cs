using DomainModel.Model;
using Infrastructure.Service.Contract_interface;
using Microsoft.AspNetCore.Mvc;

namespace OMS_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpremaController : Controller
    {
        private readonly IOprema _oprema;

        public OpremaController(IOprema oprema)
        {
            this._oprema = oprema;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _oprema.GetSveOpreme();
            return Ok(res);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_oprema.GetOprema(id));
        }
        [HttpGet("getbyuserid")]
        public IActionResult Getbyuserid(int osobaid)
        {
            return Ok(_oprema.GetOpremaByUser(osobaid));
        }
        [HttpPost("add")]
        public IActionResult Add(Oprema oprema)
        {
            var res = _oprema.AddOprema(oprema);
            if (res == "ok")
            {
                return Ok(res);
            }
            return StatusCode(409, res);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_oprema.DeleteOprema(id));
        }
        [HttpPut("update")]
        public IActionResult Update(Oprema oprema)
        {
            return Ok(_oprema.UpdateOprema(oprema));
        }
    }
}
