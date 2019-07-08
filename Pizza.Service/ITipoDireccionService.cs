using Pizza.Domain;

namespace Pizza.Service
{
    public interface ITipoDireccionService : IService<TipoDireccion>
    {
         TipoDireccion fetchByNombre(string nombre);     
    }
}