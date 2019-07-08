using Microsoft.AspNetCore.Mvc;
using Pizza.Domain;
using Pizza.Service;

namespace Pizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController :ControllerBase
    {
         private IClienteService clienteService;
        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(
                clienteService.GetAll()
            );
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                clienteService.Get(id)
            );
        }
        [HttpGet("Dni/{dni}")]
        public ActionResult fetchByDni(string dni)
        {
            return Ok(
                clienteService.fetchByDni(dni)
            );
        }
        [HttpGet("Nombre/{nombre}")]
        public ActionResult fetchByNombre(string nombre)
        {
            return Ok(
                clienteService.fetchByNombre(nombre)
            );
        }
        [HttpPost]
        public ActionResult Save([FromBody] Cliente cliente)
        {
            return Ok(
                clienteService.Save(cliente)
            );
        }
    }
}