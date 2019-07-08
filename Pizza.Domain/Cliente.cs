namespace Pizza.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public int Telefono { get; set; }
        public int Direccionid { get; set; }
        public Direccion Direccion { get; set; }
        public int Numerodireccion { get; set; }
        public string Referencia { get; set; }
        public string Correo { get; set; }
        public string Dni { get; set; }
    }
}