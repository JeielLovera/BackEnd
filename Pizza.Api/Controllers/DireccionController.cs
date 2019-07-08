using Microsoft.AspNetCore.Mvc;
using Pizza.Domain;
using Pizza.Service;

namespace Pizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DireccionController : ControllerBase
    {
        private IDireccionService direccionService;
        public DireccionController(IDireccionService direccionService)
        {
            this.direccionService = direccionService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(
                direccionService.GetAll()
            );
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                direccionService.Get(id)
            );
        }
        
        [HttpPost]
        public ActionResult Save([FromBody] Direccion direccion)
        {
            return Ok(
                direccionService.Save(direccion)
            );
        }
    }
}