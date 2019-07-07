using Pizza.Domain;
using System.Collections;
namespace Pizza.Repository
{
    public interface IProductoRepository:IRepository<Producto>
    {
         IEnumerable fetchByTipoProducto(int tpId);
    }
}