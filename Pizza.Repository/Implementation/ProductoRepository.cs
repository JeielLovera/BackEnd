using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository.Context;
using System.Linq;
using System.Collections;

namespace Pizza.Repository.Implementation
{
    public class ProductoRepository : IProductoRepository
    {
        private ApplicationDbContext context;

        public ProductoRepository(ApplicationDbContext context)
        {
            this.context=context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable fetchByTipoProducto(int tpId)
        {
            var lista= new List<Producto>();
            try
            {
                lista=context.Productos.Where(p=>p.TipoproductoId==tpId).ToList();
            
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return lista;
        }

        public Producto Get(int id)
        {
            var producto=new Producto();
            try
            {
                producto=context.Productos.Single(p=>p.Id==id);
            }
            catch (System.Exception)
            {                
                throw;
            }
            return producto;
        }

        public IEnumerable<Producto> GetAll()
        {
            var lista=new List<Producto>();
            try
            {
                lista=context.Productos.ToList();   
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return lista;
        }

        public bool Save(Producto entity)
        {
            var producto=new Producto{
                Id=entity.Id,
                nombre=entity.nombre,
                precio=entity.precio,
                TipoproductoId=entity.TipoproductoId,
                Descripcion=entity.Descripcion,
                Img=entity.Img       
            };
            try
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Producto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}