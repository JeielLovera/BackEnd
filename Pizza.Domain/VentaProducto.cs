namespace Pizza.Domain
{
    public class VentaProducto
    {
        public int Id{get;set;}
        public Producto Producto{get;set;}
        public int ProductoId{get;set;}
        public Venta Venta{get;set;}
        public int VentaId{get;set;}
        public int Cantidad{get;set;}
    }
}