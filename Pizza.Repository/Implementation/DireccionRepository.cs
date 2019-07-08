using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pizza.Domain;
using Pizza.Repository.Context;

namespace Pizza.Repository.Implementation
{
    public class DireccionRepository : IDireccionRepository
    {
        private ApplicationDbContext context;

        public DireccionRepository(ApplicationDbContext context){
            this.context=context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Direccion Get(int id)
        {
           var result = new Direccion();
            try
            {
                result = context.Direcciones.Single(x => x.Id == id);
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }
        public IEnumerable<Direccion> GetAll()
        {
            var result = context.Direcciones
                .Include(t => t.Tipodireccion)
                .Include(d => d.Distrito)
                .ToList();
            return result.Select(d => new Direccion{
                Id=d.Id,
                Nombre = d.Nombre,
                Tipodireccion =d.Tipodireccion,
                TipodireccionId=d.Tipodireccion.Id,
                Distrito = d.Distrito,
                DistritoId=d.Distrito.Id
            });
        }

        public bool Save(Direccion entity)
        {
            Direccion direccion = new Direccion(){
                Nombre = entity.Nombre,
                TipodireccionId = entity.TipodireccionId,
                DistritoId = entity.DistritoId
            };

            try{
                context.Direcciones.Add (direccion);
                context.SaveChanges ();
            }
            catch{
                return false;
            }
            return true;
        }

        public bool Update(Direccion entity)
        {
            throw new System.NotImplementedException();
        }
    }
}