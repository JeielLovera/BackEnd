using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;

namespace Pizza.Service.Implementation
{
    public class DireccionService : IDireccionService
    {
        private IDireccionRepository direccionrepository;
        private IDistritoRepository distritorepository;
        private ITipoDireccionRepository tipodireccionrepository;
        public DireccionService(IDireccionRepository direccionrepository,IDistritoRepository distritorepository,ITipoDireccionRepository tipodireccionrepository){
            this.direccionrepository =direccionrepository;
            this.distritorepository = distritorepository;
            this.tipodireccionrepository = tipodireccionrepository;
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
            Distrito distrito = distritorepository.Get(entity.DistritoId);
            TipoDireccion tipodireccion = tipodireccionrepository.Get(entity.TipodireccionId);
            entity.Distrito = distrito;
            entity.Tipodireccion = tipodireccion;

            return direccionrepository.Save(entity);
        }
    }
}