/*using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioCliente
    {
        private RepositorioCliente _repositorioCliente;

        public ServicioCliente(string filePath)
        {
            _repositorioCliente = new RepositorioCliente(filePath);
        }

        public void CrearClientes(Cliente Cliente)
        {
            _repositorioCliente.AgregarCliente(Cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _repositorioCliente.ObtenerTodos();
        }

        // Otros métodos para eliminar, modificar, etc.
    }
}*/
using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioCliente
    {
        private RepositorioCliente _repositorioCliente;

        public ServicioCliente(string filePath)
        {
            _repositorioCliente = new RepositorioCliente(filePath);
        }

        public void CrearCliente(Cliente propiedad)
        {
            _repositorioCliente.AgregarCliente(propiedad);
        }

        public List<Cliente> ObtenerClientees()
        {
            return _repositorioCliente.ObtenerTodos();
        }

        public Cliente ObtenerClientePorId(int id)
        {
            return _repositorioCliente.ObtenerPorId(id);
        }

        public void EliminarCliente(int id)
        {
            _repositorioCliente.EliminarCliente(id);
        }

        public void ModificarCliente(int id, Cliente propiedadActualizada)
        {
            var propiedadExistente = _repositorioCliente.ObtenerPorId(id);
            if (propiedadExistente != null)
            {
                propiedadExistente.Nombre = propiedadActualizada.Nombre;
                propiedadExistente.Apellido = propiedadActualizada.Apellido;
                propiedadExistente.Telefono = propiedadActualizada.Telefono;
                propiedadExistente.Email = propiedadActualizada.Email;

                _repositorioCliente.ActualizarCliente(propiedadExistente);
            }
        }
    }
}


