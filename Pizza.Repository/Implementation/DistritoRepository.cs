using System.Collections.Generic;
using System.Linq;
using Pizza.Domain;
using Pizza.Repository.Context;

namespace Pizza.Repository.Implementation
{
    public class DistritoRepository : IDistritoRepository
    {   
        private ApplicationDbContext context;
        public DistritoRepository(ApplicationDbContext context){
            this.context = context;
        }
        public Distrito fetchByNombre(string nombre)
        {
            
           var result = new Distrito();
            try
            {
                result = context.Distritos.Single(x => x.Nombre == nombre);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public Distrito Get(int id)
        {
            var result = new Distrito();
            try
            {
                result = context.Distritos.Single(x => x.Id == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Distrito> GetAll()
        {
            var result = new List<Distrito>();
            try
            {
                result = context.Distritos.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Distrito entity)
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