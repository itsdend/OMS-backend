using DomainModel.Model;
using Infrastructure.Service.Contract_interface;
using Microsoft.AspNetCore.Mvc;

namespace OMS_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KategorijaopremeController : Controller
    {
        private readonly IKategorijaopreme _kategorijaopreme;

        public KategorijaopremeController(IKategorijaopreme kategorijaopreme)
        {
            this._kategorijaopreme = kategorijaopreme;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _kategorijaopreme.GetSveKategorijeopreme();
            return Ok(res);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_kategorijaopreme.GetKategorijaopreme(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Kategorijaopreme kategorijaopreme)
        {
            return Ok(_kategorijaopreme.AddKategorijaopreme(kategorijaopreme));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_kategorijaopreme.DeleteKategorijaopreme(id));
        }
        [HttpPut("update")]
        public IActionResult Update(Kategorijaopreme kategorijaopreme)
        {
            return Ok(_kategorijaopreme.UpdateKategorijaopreme(kategorijaopreme));
        }
    }
}
