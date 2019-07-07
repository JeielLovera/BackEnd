using Microsoft.AspNetCore.Mvc;
using Pizza.Domain;
using Pizza.Service;

namespace Pizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController:ControllerBase
    {
        private IClienteService clienteServ;
        public ClienteController(IClienteService clienteServ){
            this.clienteServ=clienteServ;
        }

        [HttpGet]
        public ActionResult GetAll(){
            return Ok(clienteServ.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id){
            return Ok(clienteServ.Get(id));
        }

        [HttpGet("Nombres/{nombre}")]
        public ActionResult fetchByNombre([FromRoute] string nombre){
            return Ok(clienteServ.fetchByNombre(nombre));
        }

        [HttpPost]
        public ActionResult Save([FromBody] Cliente entity)
        {
            return Ok(clienteServ.Save(entity));
        }

        [HttpPut]
        public ActionResult Update([FromBody] Cliente entity){
            return Ok(clienteServ.Update(entity));
        }

    }
}