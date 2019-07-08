using Microsoft.AspNetCore.Mvc;
using Pizza.Domain;
using Pizza.Service;

namespace Pizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDireccionController : ControllerBase
    {
        private ITipoDireccionService tipodireccionService;
        public TipoDireccionController(ITipoDireccionService tipodireccionService)
        {
            this.tipodireccionService = tipodireccionService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(
                tipodireccionService.GetAll()
            );
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                tipodireccionService.Get(id)
            );
        }

        [HttpGet("Nombre/{nombre}")]
        public ActionResult fetchByNombre(string nombre)
        {
            return Ok(
                tipodireccionService.fetchByNombre(nombre)
            );
        }

        [HttpPost]
        public ActionResult Save([FromBody] TipoDireccion tipodireccion)
        {
            return Ok(
                tipodireccionService.Save(tipodireccion)
            );
        }
    }
}