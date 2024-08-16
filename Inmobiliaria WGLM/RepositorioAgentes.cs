/*using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Datos
{
    public class RepositorioAgentes : RepositorioBase<Agentes>
    {
        public RepositorioAgentes(string filePath) : base(filePath) { }

        public void AgregarAgentes(Agentes agente)
        {
            var agentes = ObtenerTodos();
            agentes.Add(agente);
            GuardarTodos(agentes);
        }

        // Métodos adicionales para eliminar, modificar, etc.
    }
}*/
using Inmobiliaria.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Inmobiliaria.Datos
{
    public class RepositorioAgentes : RepositorioBase<Agentes>
    {
        public RepositorioAgentes(string filePath) : base(filePath) { }

        public void AgregarAgente(Agentes agente)
        {
            var agentes = ObtenerTodos();
            agentes.Add(agente);
            GuardarTodos(agentes);
        }

        public Agentes ObtenerPorId(int id)
        {
            var agentes = ObtenerTodos();
            return agentes.FirstOrDefault(p => p.Id == id);
        }

        public void EliminarAgente(int id)
        {
            var agentes = ObtenerTodos();
            var agente = agentes.FirstOrDefault(p => p.Id == id);
            if (agente != null)
            {
                agentes.Remove(agente);
                GuardarTodos(agentes);
            }
        }

        public void ActualizarAgente(Agentes agenteActualizada)
        {
            var agentes = ObtenerTodos();
            var agenteExistente = agentes.FirstOrDefault(p => p.Id == agenteActualizada.Id);
            if (agenteExistente != null)
            {
                agenteExistente.Nombre = agenteActualizada.Nombre;
                agenteExistente.Apellido = agenteActualizada.Apellido;
                agenteExistente.Puesto = agenteActualizada.Puesto;
                agenteExistente.Salario = agenteActualizada.Salario;

                GuardarTodos(agentes);
            }
        }
    }
}