/*using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioContrato
    {
        private RepositorioContrato _repositorioContrato;

        public ServicioContrato(string filePath)
        {
            _repositorioContrato = new RepositorioContrato(filePath);
        }

        public void CrearContrato(Contrato contrato)
        {
            _repositorioContrato.AgregarContrato(contrato);
        }

        public List<Contrato> ObtenerContratos()
        {
            return _repositorioContrato.ObtenerTodos();
        }

        // Otros métodos para eliminar, modificar, etc.
    }
}*/
using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioContrato
    {
        private RepositorioContrato _repositorioContrato;

        public ServicioContrato(string filePath)
        {
            _repositorioContrato = new RepositorioContrato(filePath);
        }

        public void CrearContrato(Contrato contrato)
        {
            _repositorioContrato.AgregarContrato(contrato);
        }

        public List<Contrato> ObtenerContratos()
        {
            return _repositorioContrato.ObtenerTodos();
        }

        public Contrato ObtenerContratoPorId(int id)
        {
            return _repositorioContrato.ObtenerPorId(id);
        }

        public void EliminarContrato(int id)
        {
            _repositorioContrato.EliminarContrato(id);
        }

        public void ModificarContrato(int id, Contrato contratoActualizada)
        {
            var contratoExistente = _repositorioContrato.ObtenerPorId(id);
            if (contratoExistente != null)
            {
                contratoExistente.Propiedad = contratoActualizada.Propiedad;
                contratoExistente.Cliente = contratoActualizada.Cliente;
                contratoExistente.Monto = contratoActualizada.Monto;
                contratoExistente.FechaInicio = contratoActualizada.FechaInicio;
                contratoExistente.FechaFin = contratoActualizada.FechaFin;

                _repositorioContrato.ActualizarContrato(contratoExistente);
            }
        }
    }
}

