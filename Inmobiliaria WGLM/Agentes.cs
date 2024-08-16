namespace Inmobiliaria.Entidades
{
    public class Agentes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }

        public Agentes(int id, string nombre, string apellido, string puesto, decimal salario)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Puesto = puesto;
            Salario = salario;
        }
    }
}
