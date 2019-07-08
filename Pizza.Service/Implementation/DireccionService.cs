using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;

namespace Pizza.Service.Implementation
{
    public class DireccionService : IDireccionService
    {
        private IDireccionRepository direccionrepository;
        public DireccionService(IDireccionRepository direccionrepository){
            this.direccionrepository =direccionrepository;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Direccion Get(int id)
        {
            return direccionrepository.Get(id);
        }

        public IEnumerable<Direccion> GetAll()
        {
            return direccionrepository.GetAll();
        }

        public bool Save(Direccion entity)
        {

            return direccionrepository.Save(entity);
        }

        public bool Update(Direccion entity)
        {
            throw new System.NotImplementedException();
        }
    }
}