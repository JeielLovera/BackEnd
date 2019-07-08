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
                Nombre = d.Nombre,
                Tipodireccion =d.Tipodireccion,
                Distrito = d.Distrito,
            });
        }

        public bool Save(Direccion entity)
        {
            Direccion direccion = new Direccion {
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
    }
}