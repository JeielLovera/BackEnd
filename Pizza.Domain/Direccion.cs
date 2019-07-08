namespace Pizza.Domain
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipodireccionId { get; set; }
        public int DistritoId { get; set; }

        public Distrito Distrito { get; set; }
        public TipoDireccion Tipodireccion { get; set; }
    }
}