using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;

namespace Pizza.Service.Implementation
{
    public class DistritoService : IDistritoService
    {
        private IDistritoRepository distritorepository;
        public DistritoService (IDistritoRepository distritorepository){
            this.distritorepository = distritorepository;
        }
        public Distrito fetchByNombre(string nombre)
        {
            return distritorepository.fetchByNombre(nombre);
        }

        public Distrito Get(int id)
        {
            return distritorepository.Get(id);
        }

        public IEnumerable<Distrito> GetAll()
        {
            return distritorepository.GetAll();
        }

        public bool Save(Distrito entity)
        {
            return distritorepository.Save(entity);
        }
    }
}