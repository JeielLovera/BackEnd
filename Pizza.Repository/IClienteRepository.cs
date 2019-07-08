using System.Collections.Generic;
using Pizza.Domain;

namespace Pizza.Repository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
         IEnumerable <Cliente> fetchByNombre(string nombre); 
         Cliente fetchByDni(string dni); 
    }
}