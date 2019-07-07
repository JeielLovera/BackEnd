using Pizza.Domain;

namespace Pizza.Service
{
    public interface IClienteService:IService<Cliente>
    {
         Cliente fetchByNombre(string Nombre);
    }
}