using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pizza.Repository.Implementation
{
    public class TipoProductoRepository : ITipoProductoRepository
    {
        private ApplicationDbContext context;

        public TipoProductoRepository(ApplicationDbContext context)
        {
            this.context=context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public TipoProducto Get(int id)
        {
            var tproducto=new TipoProducto();
            try
            {
                tproducto=context.TipoProductos.Single(tp=>tp.Id==id);
            }
            catch (System.Exception)
            {                
                throw;
            }
            return tproducto;
        }

        public IEnumerable<TipoProducto> GetAll()
        {
            var lista=new List<TipoProducto>();
            try
            {
                lista=context.TipoProductos.ToList();
            }
            catch (System.Exception)
            {                
                throw;
            }
            return lista;
        }

        public bool Save(TipoProducto entity)
        {
            TipoProducto tproducto=new TipoProducto{
                Id=entity.Id,
                nombre=entity.nombre,
                SubtipoproductoId=entity.SubtipoproductoId
            };
            try
            {
                context.TipoProductos.Add(tproducto);
                context.SaveChanges();
            }
            catch (System.Exception)
            {                
                return false;
            }
            return true;
        }

        public bool Update(TipoProducto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}