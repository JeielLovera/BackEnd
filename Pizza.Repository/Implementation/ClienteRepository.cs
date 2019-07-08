using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pizza.Domain;
using Pizza.Repository.Context;

namespace Pizza.Repository.Implementation
{
    public class ClienteRepository : IClienteRepository
    {   
        private ApplicationDbContext context;

        public ClienteRepository (ApplicationDbContext context){
            this.context = context;
        }
        public Cliente fetchByDni(string dni)
        {
            var result = new Cliente();
            try
            {
                result = context.Clientes.Single(x => x.Dni == dni);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Cliente> fetchByNombre(string nombre)
        {
            var result = new List<Cliente>();
            try
            {
                result = context.Clientes.Where(x=> x.Nombres == nombre).ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public Cliente Get(int id)
        {
           var result = new Cliente();
            try
            {
                result = context.Clientes.Single(x => x.Id == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Cliente> GetAll()
        {
            var result = context.Clientes
                .Include(d => d.Direccion)
                .ToList();
            return result.Select(d => new Cliente{
                Id=d.Id,
                Nombres = d.Nombres,
                Telefono =d.Telefono,
                Direccion=d.Direccion,
                Direccionid = d.Direccion.Id,
                Numerodireccion = d.Numerodireccion,
                Referencia=d.Referencia,
                Correo=d.Correo,
                Dni=d.Dni
            });
        }

        public bool Save(Cliente entity)
        {
            Cliente cliente = new Cliente(){
                Nombres = entity.Nombres,
                Telefono =entity.Telefono,
                Direccionid = entity.Direccionid,
                Numerodireccion = entity.Numerodireccion,
                Referencia=entity.Referencia,
                Correo=entity.Correo,
                Dni=entity.Dni
            };

            try{
                context.Clientes.Add (cliente);
                context.SaveChanges ();
            }
            catch{
                return false;
            }
            return true;
        }

        public bool Update(Cliente entity)
        {
            throw new System.NotImplementedException();
        }
    }
}