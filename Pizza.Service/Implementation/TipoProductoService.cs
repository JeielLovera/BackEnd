using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;
namespace Pizza.Service.Implementation
{
    public class TipoProductoService : ITipoProductoService
    {
        private ITipoProductoRepository tpRepository;

        public TipoProductoService(ITipoProductoRepository tpRepository)
        {
            this.tpRepository=tpRepository;
        }        

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public TipoProducto Get(int id)
        {
            return tpRepository.Get(id);
        }

        public IEnumerable<TipoProducto> GetAll()
        {
            return tpRepository.GetAll();
        }

        public bool Save(TipoProducto entity)
        {
            return tpRepository.Save(entity);
        }

        public bool Update(TipoProducto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}