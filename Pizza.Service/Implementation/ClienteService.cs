using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;

namespace Pizza.Service.Implementation
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository clienteRepo;
        public ClienteService(IClienteRepository clienteRepo){
            this.clienteRepo=clienteRepo;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Cliente fetchByNombre(string Nombre)
        {
            return clienteRepo.fetchByNombre(Nombre);
        }

        public Cliente Get(int id)
        {
            return clienteRepo.Get(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return clienteRepo.GetAll();
        }

        public bool Save(Cliente entity)
        {
            return clienteRepo.Save(entity);
        }

        public bool Update(Cliente entity)
        {
            return clienteRepo.Update(entity);
        }
    }
}