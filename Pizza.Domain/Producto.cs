namespace Pizza.Domain
{
    public class Producto
    {
        public int Id{get;set;}
        public string nombre{get;set;}
        public decimal precio{get;set;}
        public TipoProducto Tipoproducto{get;set;}
        public int TipoproductoId{get;set;}
        public string Descripcion{get;set;}
    //public decimal.Round(decimal precio2, int decimales);
    }

}