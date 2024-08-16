/*using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Datos
{
    public class RepositorioPropiedad : RepositorioBase<Propiedad>
    {
        public RepositorioPropiedad(string filePath) : base(filePath) { }

        public void AgregarPropiedad(Propiedad propiedad)
        {
            var propiedades = ObtenerTodos();
            propiedades.Add(propiedad);
            GuardarTodos(propiedades);
        }

        // quiero que le agres una definición para "ObtenerPorId"
    }
}*/
using Inmobiliaria.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Inmobiliaria.Datos
{
    public class RepositorioPropiedad : RepositorioBase<Propiedad>
    {
        public RepositorioPropiedad(string filePath) : base(filePath) { }

        public void AgregarPropiedad(Propiedad propiedad)
        {
            var propiedades = ObtenerTodos();
            propiedades.Add(propiedad);
            GuardarTodos(propiedades);
        }

        public Propiedad ObtenerPorId(int id)
        {
            var propiedades = ObtenerTodos();
            return propiedades.FirstOrDefault(p => p.Id == id);
        }

        public void EliminarPropiedad(int id)
        {
            var propiedades = ObtenerTodos();
            var propiedad = propiedades.FirstOrDefault(p => p.Id == id);
            if (propiedad != null)
            {
                propiedades.Remove(propiedad);
                GuardarTodos(propiedades);
            }
        }

        public void ActualizarPropiedad(Propiedad propiedadActualizada)
        {
            var propiedades = ObtenerTodos();
            var propiedadExistente = propiedades.FirstOrDefault(p => p.Id == propiedadActualizada.Id);
            if (propiedadExistente != null)
            {
                propiedadExistente.Direccion = propiedadActualizada.Direccion;
                propiedadExistente.Tipo = propiedadActualizada.Tipo;
                propiedadExistente.Precio = propiedadActualizada.Precio;
                propiedadExistente.Propietario = propiedadActualizada.Propietario;
                propiedadExistente.Descripcion = propiedadActualizada.Descripcion;
                

                GuardarTodos(propiedades);
            }
        }
    }
}
