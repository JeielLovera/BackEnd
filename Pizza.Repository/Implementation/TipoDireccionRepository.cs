using System.Collections.Generic;
using System.Linq;
using Pizza.Domain;
using Pizza.Repository.Context;

namespace Pizza.Repository.Implementation
{
    public class TipoDireccionRepository : ITipoDireccionRepository
    {
        
        private ApplicationDbContext context;
        public TipoDireccion fetchByNombre(string nombre)
        {
            var result = new TipoDireccion();
            try
            {
                result = context.TipoDirecciones.Single(x => x.Nombre  == nombre);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public TipoDireccion Get(int id)
        {
            var result = new TipoDireccion();
            try
            {
                result = context.TipoDirecciones.Single(x => x.Id == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<TipoDireccion> GetAll()
        {
            var result = new List<TipoDireccion>();
            try
            {
                result = context.TipoDirecciones.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(TipoDireccion entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }
    }
}