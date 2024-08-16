namespace Inmobiliaria.Entidades
{
    public class Pago
    {
        public int Id { get; set; }
        public Contrato Contrato { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Pago(int id, Contrato contrato, decimal monto, DateTime fecha)
        {
            Id = id;
            Contrato = contrato;
            Monto = monto;
            Fecha = fecha;
        }
    }
}
