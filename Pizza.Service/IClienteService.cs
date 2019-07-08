using System.Collections.Generic;
using Pizza.Domain;

namespace Pizza.Service
{
    public interface IClienteService: IService<Cliente>
    {
         IEnumerable <Cliente> fetchByNombre(string nombre); 
         Cliente fetchByDni(string dni); 
    }
}