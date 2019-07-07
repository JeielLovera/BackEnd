using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository.Context;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pizza.Repository.Implementation
{
    public class VentaRepository : IVentaRepository
    {
        private ApplicationDbContext context;
        public VentaRepository(ApplicationDbContext context){
            this.context=context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Venta Get(int id)
        {
            var venta=new Venta();
            try{
                venta=context.Ventas.Single(v => v.Id==id);
            }
            catch(System.Exception){
                throw;
            }
            return venta;
        }

        public IEnumerable<Venta> GetAll()
        {
            var ventas=new List<Venta>();
            try{
                ventas=context.Ventas.ToList();
            }
            catch(System.Exception){
                throw;
            }
            return ventas;
        }

        public bool Save(Venta entity)
        {
            Venta venta=new Venta{
                LocalId=entity.LocalId,
                ClienteId=entity.ClienteId,
                Fechaventa=DateTime.Now.ToString("dd/MM/yyyy"),
                Monto=entity.Monto,
                Igv=entity.Igv,
                Descuento=entity.Descuento,
                Montoneto=entity.Montoneto,
                Horaentrega=DateTime.Now.ToString("dd/MM/yyyy"),
                Mediopago=entity.Mediopago,
                Numerotarjeta=entity.Numerotarjeta,
                Pagado=entity.Pagado
            };

            try{
                context.Ventas.Add(venta);
                context.SaveChanges();
                var ventaId=venta.Id;
                foreach (var item in entity.VentaProducto)
                {
                    VentaProducto vntprdct=new VentaProducto{
                        VentaId=ventaId,
                        ProductoId=item.ProductoId,
                        Cantidad=item.Cantidad
                    };
                    context.VentaProductos.Add(vntprdct);
                }
            }
            catch(System.Exception){
                return false;
            }
            return true;
        }

        public bool Update(Venta entity)
        {
            try{
                var ventaoriginal=context.Ventas.Single(v => v.Id==entity.Id);

                ventaoriginal.LocalId=entity.LocalId;
                ventaoriginal.ClienteId=entity.ClienteId;
                ventaoriginal.Fechaventa=DateTime.Now.ToString("dd/MM/yyyy");
                ventaoriginal.Monto=entity.Monto;
                ventaoriginal.Pagado=entity.Pagado;
                ventaoriginal.Igv=entity.Igv;
                ventaoriginal.Descuento=entity.Descuento;
                ventaoriginal.Montoneto=entity.Montoneto;
                ventaoriginal.Horaentrega=DateTime.Now.ToString("dd/MM/yyyy");
                ventaoriginal.Numerotarjeta=entity.Numerotarjeta;
                ventaoriginal.Pagado=entity.Pagado;

                context.Ventas.Update(ventaoriginal);
                context.SaveChanges();
            }
            catch(System.Exception){
                return false;
            }
            return true;
        }
    }
}