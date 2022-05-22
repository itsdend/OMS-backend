using DomainModel.Model;
using Infrastructure.Service.Contract_interface;
using Microsoft.AspNetCore.Mvc;

namespace OMS_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimController : Controller
    {
        private readonly ITim _tim;

        public TimController(ITim tim)
        {
            this._tim = tim;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _tim.GetSveTimove();
            return Ok(res);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_tim.GetTim(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Tim tim)
        {
            return Ok(_tim.AddTim(tim));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_tim.DeleteTim(id));
        }
        [HttpPut("update")]
        public IActionResult Update(Tim  tim)
        {
            return Ok(_tim.UpdateTim(tim));
        }
    }
}
