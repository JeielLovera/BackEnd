using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;

namespace Pizza.Service.Implementation
{
    public class TipoDireccionService : ITipoDireccionService
    {
        private ITipoDireccionRepository tipodireccionrepository;
        public TipoDireccionService(ITipoDireccionRepository tipodireccionrepository){
            this.tipodireccionrepository =tipodireccionrepository;
        }

        public TipoDireccion fetchByNombre(string nombre)
        {
           return tipodireccionrepository.fetchByNombre(nombre);
        }

        public TipoDireccion Get(int id)
        {
            return tipodireccionrepository.Get(id);
        }

        public IEnumerable<TipoDireccion> GetAll()
        {
            return tipodireccionrepository.GetAll();
        }

        public bool Save(TipoDireccion entity)
        {
           return tipodireccionrepository.Save(entity);
        }
    }
}