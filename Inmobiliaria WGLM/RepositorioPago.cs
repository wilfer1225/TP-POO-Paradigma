/*using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Datos
{
    public class RepositorioPago : RepositorioBase<Pago>
    {
        public RepositorioPago(string filePath) : base(filePath) { }

        public void AgregarPago(Pago pago)
        {
            var pagos = ObtenerTodos();
            pagos.Add(pago);
            GuardarTodos(pagos);
        }

        // Métodos adicionales para eliminar, modificar, etc.
    }
}*/
using Inmobiliaria.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Inmobiliaria.Datos
{
    public class RepositorioPago : RepositorioBase<Pago>
    {
        public RepositorioPago(string filePath) : base(filePath) { }

        public void AgregarPago(Pago pago)
        {
            var pagos = ObtenerTodos();
            pagos.Add(pago);
            GuardarTodos(pagos);
        }

        public Pago ObtenerPorId(int id)
        {
            var pagos = ObtenerTodos();
            return pagos.FirstOrDefault(p => p.Id == id);
        }

        public void EliminarPago(int id)
        {
            var pagos = ObtenerTodos();
            var pago = pagos.FirstOrDefault(p => p.Id == id);
            if (pago != null)
            {
                pagos.Remove(pago);
                GuardarTodos(pagos);
            }
        }

        public void ActualizarPago(Pago pagoActualizada)
        {
            var pagos = ObtenerTodos();
            var pagoExistente = pagos.FirstOrDefault(p => p.Id == pagoActualizada.Id);
            if (pagoExistente != null)
            {
                pagoExistente.Contrato = pagoActualizada.Contrato;
                pagoExistente.Monto = pagoActualizada.Monto;
                pagoExistente.Fecha = pagoActualizada.Fecha;
                

                GuardarTodos(pagos);
            }
        }
    }
}
