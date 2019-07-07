using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository.Context;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pizza.Repository.Implementation
{
    public class ClienteRepository : IClienteRepository
    {
        private ApplicationDbContext context;
        public ClienteRepository(ApplicationDbContext context){
            this.context=context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Cliente fetchByNombre(string Nombre)
        {
            var cliente=new Cliente();
            try{
                cliente=context.Clientes.Single(c => c.Nombres==Nombre);
            }
            catch(System.Exception){
                throw;
            }
            return cliente;
        }

        public Cliente Get(int id)
        {
            var cliente=new Cliente();
            try{
                cliente=context.Clientes.Single(c => c.Id==id);
            }
            catch(System.Exception){
                throw;
            }
            return cliente;
        }

        public IEnumerable<Cliente> GetAll()
        {
            var clientes=new List<Cliente>();
            try{
                clientes=context.Clientes.ToList();
            }
            catch(System.Exception){
                throw;
            }
            return clientes;
        }

        public bool Save(Cliente entity)
        {
            Cliente cliente=new Cliente(){
                Nombres=entity.Nombres,
                Telefono=entity.Telefono,
                DireccionId=entity.DireccionId,
                NumeroDireccion=entity.NumeroDireccion,
                Referencia=entity.Referencia,
                Correo=entity.Correo,
                Dni=entity.Dni

            };

            try{
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
            catch(System.Exception){
                return false;
            }
            return true;

        }

        public bool Update(Cliente entity)
        {
            try{
                var clienteoriginal=context.Clientes.Single(c =>c.Id==entity.Id);
                clienteoriginal.Nombres=entity.Nombres;
                clienteoriginal.Telefono=entity.Telefono;
                clienteoriginal.DireccionId=entity.DireccionId;
                clienteoriginal.NumeroDireccion=entity.NumeroDireccion;
                clienteoriginal.Referencia=entity.Referencia;
                clienteoriginal.Correo=entity.Correo;
                clienteoriginal.Dni=entity.Dni;

                context.Clientes.Update(clienteoriginal);
                context.SaveChanges();
            }
            catch(System.Exception){
                return false;
            }
            return true;
        }
    }
}