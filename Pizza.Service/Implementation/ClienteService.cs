using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;

namespace Pizza.Service.Implementation
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository clienterepository;
        public ClienteService(IClienteRepository clienterepository){
            this.clienterepository =clienterepository;
        }
        public Cliente fetchByDni(string dni)
        {
            return clienterepository.fetchByDni(dni);
        }

        public IEnumerable<Cliente> fetchByNombre(string nombre)
        {
            return clienterepository.fetchByNombre(nombre);
        }

        public Cliente Get(int id)
        {
            return clienterepository.Get(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return clienterepository.GetAll();
        }

        public bool Save(Cliente entity)
        {
           return clienterepository.Save(entity);
        }

        public bool Update(Cliente entity)
        {
            throw new System.NotImplementedException();
        }
    }
}