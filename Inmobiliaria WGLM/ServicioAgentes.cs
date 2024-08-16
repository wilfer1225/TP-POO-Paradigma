/*using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioEmpleado
    {
        private RepositorioEmpleado _repositorioEmpleado;

        public ServicioEmpleado(string filePath)
        {
            _repositorioEmpleado = new RepositorioEmpleado(filePath);
        }

        public void CrearContrato(Empleado agentes)
        {
            _repositorioEmpleado.AgregarEmpleado(agentes);
        }

        public List<Empleado> ObtenerAgentes()
        {
            return _repositorioEmpleado.ObtenerTodos();
        }

        // Otros métodos para eliminar, modificar, etc.
    }
}*/
using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioAgentes
    {
        private RepositorioAgentes _repositorioAgentes;

        public ServicioAgentes(string filePath)
        {
            _repositorioAgentes = new RepositorioAgentes(filePath);
        }

        public void CrearAgentes(Agentes agentes)
        {
            _repositorioAgentes.AgregarAgente(agentes);
        }

        public List<Agentes> ObtenerAgentes()
        {
            return _repositorioAgentes.ObtenerTodos();
        }

        public Agentes ObtenerAgentesPorId(int id)
        {
            return _repositorioAgentes.ObtenerPorId(id);
        }

        public void EliminarAgentes(int id)
        {
            _repositorioAgentes.EliminarAgente(id);
        }

        public void ModificarAgente(int id, Agentes agenteActualizada)
        {
            var agenteExistente = _repositorioAgentes.ObtenerPorId(id);
            if (agenteExistente != null)
            {
                agenteExistente.Nombre = agenteActualizada.Nombre;
                agenteExistente.Apellido = agenteActualizada.Apellido;
                agenteExistente.Puesto = agenteActualizada.Puesto;
                agenteExistente.Salario = agenteActualizada.Salario;

                _repositorioAgentes.ActualizarAgente(agenteExistente);
            }
        }
    }
}
