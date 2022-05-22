using DomainModel.Model;
using Infrastructure.Service.Contract_interface;
using Microsoft.AspNetCore.Mvc;

namespace OMS_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusopremeController : Controller
    {
        private readonly IStatusopreme _statusopreme;

        public StatusopremeController(IStatusopreme statusopreme)
        {
            this._statusopreme = statusopreme;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _statusopreme.GetSveStatuseopreme();
            return Ok(res);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_statusopreme.GetStatusopreme(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Statusopreme statusopreme)
        {
            return Ok(_statusopreme.AddStatusopreme(statusopreme));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_statusopreme.DeleteStatusopreme(id));
        }
        [HttpPut("update")]
        public IActionResult Update(Statusopreme statusopreme)
        {
            return Ok(_statusopreme.UpdateStatusopreme(statusopreme));
        }
    }
}
