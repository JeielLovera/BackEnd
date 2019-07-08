using Pizza.Domain;

namespace Pizza.Repository
{
    public interface IDistritoRepository :IRepository<Distrito>
    {
        Distrito fetchByNombre(string nombre);           
    }
}