/*using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioPago
    {
        private RepositorioPago _repositorioPago;

        public ServicioPago(string filePath)
        {
            _repositorioPago = new RepositorioPago(filePath);
        }

        public void CrearPago(Pago pago)
        {
            _repositorioPago.AgregarPago(pago);
        }

        public List<Pago> ObtenerPagos()
        {
            return _repositorioPago.ObtenerTodos();
        }

        // Otros métodos para eliminar, modificar, etc.
    }
}*/
using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioPago
    {
        private RepositorioPago _repositorioPago;

        public ServicioPago(string filePath)
        {
            _repositorioPago = new RepositorioPago(filePath);
        }

        public void CrearPago(Pago pago)
        {
            _repositorioPago.AgregarPago(pago);
        }

        public List<Pago> ObtenerPagos()
        {
            return _repositorioPago.ObtenerTodos();
        }

        public Pago ObtenerPagoPorId(int id)
        {
            return _repositorioPago.ObtenerPorId(id);
        }

        public void EliminarPago(int id)
        {
            _repositorioPago.EliminarPago(id);
        }

        public void ModificarPago(int id, Pago pagoActualizada)
        {
            var pagoExistente = _repositorioPago.ObtenerPorId(id);
            if (pagoExistente != null)
            {
                pagoExistente.Contrato = pagoActualizada.Contrato;
                pagoExistente.Monto = pagoActualizada.Monto;
                pagoExistente.Fecha = pagoActualizada.Fecha;

                _repositorioPago.ActualizarPago(pagoExistente);
            }
        }
    }
}
