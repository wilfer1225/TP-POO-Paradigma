/*using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Datos
{
    public class RepositorioCliente : RepositorioBase<Cliente>
    {
        public RepositorioCliente(string filePath) : base(filePath) { }

        public void AgregarCliente(Cliente Cliente)
        {
            var Clientes = ObtenerTodos();
            Clientes.Add(Cliente);
            GuardarTodos(Clientes);
        }

        // Métodos adicionales para eliminar, modificar, etc.
    }
}*/
using Inmobiliaria.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Inmobiliaria.Datos
{
    public class RepositorioCliente : RepositorioBase<Cliente>
    {
        public RepositorioCliente(string filePath) : base(filePath) { }

        public void AgregarCliente(Cliente client)
        {
            var clientes = ObtenerTodos();
            clientes.Add(client);
            GuardarTodos(clientes);
        }

        public Cliente ObtenerPorId(int id)
        {
            var clientes = ObtenerTodos();
            return clientes.FirstOrDefault(p => p.Id == id);
        }

        public void EliminarCliente(int id)
        {
            var clientes = ObtenerTodos();
            var cliente = clientes.FirstOrDefault(p => p.Id == id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                GuardarTodos(clientes);
            }
        }

        public void ActualizarCliente(Cliente clienteActualizada)
        {
            var clientes = ObtenerTodos();
            var clienteExistente = clientes.FirstOrDefault(p => p.Id == clienteActualizada.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nombre = clienteActualizada.Nombre;
                clienteExistente.Apellido = clienteActualizada.Apellido;
                clienteExistente.Telefono = clienteActualizada.Telefono;
                clienteExistente.Email = clienteActualizada.Email;
                

                GuardarTodos(clientes);
            }
        }
    }
}

