using Microsoft.AspNetCore.Mvc;
using Pizza.Domain;
using Pizza.Service;

namespace Pizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritoController : ControllerBase
    {
        private IDistritoService distritoService;
        public DistritoController(IDistritoService distritoService)
        {
            this.distritoService = distritoService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(
                distritoService.GetAll()
            );
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                distritoService.Get(id)
            );
        }

        [HttpGet("fbn/{nombre}")]
        public ActionResult fetchByNombre(string nombre)
        {
            return Ok(
                distritoService.fetchByNombre(nombre)
            );
        }

        [HttpPost]
        public ActionResult Save([FromBody] Distrito distrito)
        {
            return Ok(
                distritoService.Save(distrito)
            );
        }

    }
}