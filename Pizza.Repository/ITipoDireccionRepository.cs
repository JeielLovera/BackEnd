using Pizza.Domain;

namespace Pizza.Repository
{
    public interface ITipoDireccionRepository : IRepository<TipoDireccion>
    {
        TipoDireccion fetchByNombre(string nombre);         
    }
}