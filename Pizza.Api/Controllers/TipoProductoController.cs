using Microsoft.AspNetCore.Mvc;
using Pizza.Domain;
using Pizza.Service;

namespace Pizza.Api.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class TipoProductoController:ControllerBase
    {
        private ITipoProductoService tpService;

        public TipoProductoController(ITipoProductoService tpService)
        {
            this.tpService=tpService;
        }

        [HttpGet]
        public ActionResult GetAll(){
            return Ok(tpService.GetAll());
        }
/* 
        [HttpGet("{tpId}")]
        public ActionResult GetById(int tpId){
            return Ok(tpService.Get(tpId));
        }*/

        [HttpPost]
        public ActionResult CrearTipoProducto([FromBody] TipoProducto tp){
            return Ok(tpService.Save(tp));
        }
    }
}