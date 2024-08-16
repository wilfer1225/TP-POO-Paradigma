/*using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Datos
{
    public class RepositorioContrato : RepositorioBase<Contrato>
    {
        public RepositorioContrato(string filePath) : base(filePath) { }

        public void AgregarContrato(Contrato contrato)
        {
            var contratos = ObtenerTodos();
            contratos.Add(contrato);
            GuardarTodos(contratos);
        }

        // Métodos adicionales para eliminar, modificar, etc.
    }
}
*/
using Inmobiliaria.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Inmobiliaria.Datos
{
    public class RepositorioContrato : RepositorioBase<Contrato>
    {
        public RepositorioContrato(string filePath) : base(filePath) { }

        public void AgregarContrato(Contrato contrato)
        {
            var contratoes = ObtenerTodos();
            contratoes.Add(contrato);
            GuardarTodos(contratoes);
        }

        public Contrato ObtenerPorId(int id)
        {
            var contratoes = ObtenerTodos();
            return contratoes.FirstOrDefault(p => p.Id == id);
        }

        public void EliminarContrato(int id)
        {
            var contratoes = ObtenerTodos();
            var contrato = contratoes.FirstOrDefault(p => p.Id == id);
            if (contrato != null)
            {
                contratoes.Remove(contrato);
                GuardarTodos(contratoes);
            }
        }

        public void ActualizarContrato(Contrato contratoActualizada)
        {
            var contratoes = ObtenerTodos();
            var contratoExistente = contratoes.FirstOrDefault(p => p.Id == contratoActualizada.Id);
            if (contratoExistente != null)
            {
                contratoExistente.Propiedad = contratoActualizada.Propiedad;
                contratoExistente.Cliente = contratoActualizada.Cliente;
                contratoExistente.Monto = contratoActualizada.Monto;
                contratoExistente.FechaInicio = contratoActualizada.FechaInicio;
                contratoExistente.FechaFin = contratoActualizada.FechaFin;
                

                GuardarTodos(contratoes);
            }
        }
    }
}
