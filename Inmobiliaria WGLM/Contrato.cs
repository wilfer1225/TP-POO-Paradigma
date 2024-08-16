namespace Inmobiliaria.Entidades
{
    public class Contrato
    {
       public int Id { get; set; }
        public Propiedad Propiedad { get; set; }
        public Cliente Cliente { get; set; }  
        public decimal Monto { get; set; }    // Monto del alquiler
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Contrato(int id, Propiedad propiedad, Cliente cliente, decimal Monto, DateTime fechaInicio, DateTime fechaFin)
        {
            Id = id;
            Propiedad = propiedad;
            Cliente = cliente;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
    }
}
