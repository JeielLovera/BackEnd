using System.Collections;
using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;
namespace Pizza.Service.Implementation
{
    public class ProductoService : IProductoService
    {
        private IProductoRepository productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            this.productoRepository=productoRepository;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable fetchByTipoProducto(int tpId)
        {
            return productoRepository.fetchByTipoProducto(tpId);
        }

        public Producto Get(int id)
        {
            return productoRepository.Get(id);
        }

        public IEnumerable<Producto> GetAll()
        {
            return productoRepository.GetAll();
        }

        public bool Save(Producto entity)
        {
            return productoRepository.Save(entity);
        }

        public bool Update(Producto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}