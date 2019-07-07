using Pizza.Domain;
using System.Collections;
namespace Pizza.Service
{
    public interface IProductoService:IService<Producto>
    {
         IEnumerable fetchByTipoProducto(int tpId);
    }
}