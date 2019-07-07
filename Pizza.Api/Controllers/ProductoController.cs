using Pizza.Service;
using Microsoft.AspNetCore.Mvc;
using Pizza.Domain;

namespace Pizza.Api.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ProductoController:ControllerBase
    {
        private IProductoService productoService;

        public ProductoController(IProductoService productoService)
        {
            this.productoService=productoService;
        }

        [HttpGet]
        public ActionResult GetAll(){
            return Ok(productoService.GetAll());
        }

        [HttpGet("{productoId}")]
        public ActionResult GetById([FromRoute]int productoId){
            return Ok(productoService.Get(productoId));
        }

        [HttpPost]
        public ActionResult CrearProducto([FromBody] Producto producto){
            return Ok(productoService.Save(producto));
        }

       [HttpGet("TipoProducto/{tpId}")]
        public ActionResult GetByTipoProducto([FromRoute]int tpId){
            return Ok(productoService.fetchByTipoProducto(tpId));
        }
    }
}