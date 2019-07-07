using Microsoft.AspNetCore.Mvc;
using Pizza.Domain;
using Pizza.Service;

namespace Pizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController:ControllerBase
    {
        private IVentaService ventaServ;
        public VentaController(IVentaService ventaServ){
            this.ventaServ=ventaServ;
        }

        [HttpGet]
        public ActionResult GetAll(){
            return Ok(ventaServ.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id){
            return Ok(ventaServ.Get(id));
        }

        [HttpPost]
        public ActionResult Save([FromBody] Venta entity){
            return Ok(ventaServ.Save(entity));
        }

        [HttpPut]
        public ActionResult Update([FromBody] Venta entity){
            return Ok(ventaServ.Update(entity));
        }
    }
}