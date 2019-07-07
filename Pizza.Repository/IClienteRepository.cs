using Pizza.Domain;

namespace Pizza.Repository
{
    public interface IClienteRepository:IRepository<Cliente>
    {
         Cliente fetchByNombre(string Nombre);
    }
}