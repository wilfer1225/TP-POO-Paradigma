namespace Inmobiliaria.Entidades
{
    public class Propiedad
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Tipo { get; set; } // Ejemplo: "Casa", "Departamento"
        public decimal Precio { get; set; }
        public string Propietario { get; set; } // Nombre del propietario
        public string Descripcion { get; set; }

        public Propiedad(int id, string direccion, string tipo, decimal precio, string propietario, string descripcion)
        {
            Id = id;
            Direccion = direccion;
            Tipo = tipo;
            Precio = precio;
            Propietario = propietario;
            Descripcion = descripcion;
        }
    }
}
