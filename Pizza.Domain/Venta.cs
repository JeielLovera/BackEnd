using System.Collections.Generic;
namespace Pizza.Domain
{
    public class Venta
    {
        public int Id{get;set;}
        public int LocalId {get;set;}
        public int ClienteId{get;set;}
        public Cliente Cliente{get;set;}
        public string Fechaventa{get;set;}
        public decimal Monto{get;set;}
        public decimal Igv{get;set;}
        public decimal Descuento{get;set;}
        public decimal Montoneto{get;set;}
        public string Horaentrega{get;set;}
        public string Mediopago{get;set;}
        public string Numerotarjeta{get;set;}
        public bool Pagado{get;set;}

        public IEnumerable<VentaProducto> VentaProducto{get;set;}
    }
}