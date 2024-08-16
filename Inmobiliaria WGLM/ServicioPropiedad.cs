/*using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioPropiedad
    {
        private RepositorioPropiedad _repositorioPropiedad;

        public ServicioPropiedad(string filePath)
        {
            _repositorioPropiedad = new RepositorioPropiedad(filePath);
        }

        public void CrearPropiedad(Propiedad propiedad)
        {
            _repositorioPropiedad.AgregarPropiedad(propiedad);
        }

        public List<Propiedad> ObtenerPropiedades()
        {
            return _repositorioPropiedad.ObtenerTodos();
        }

        // Quiero que aqui agregues métodos para eliminar, modificar, etc.
    }
}*/
using Inmobiliaria.Datos;
using Inmobiliaria.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.Negocio
{
    public class ServicioPropiedad
    {
        private RepositorioPropiedad _repositorioPropiedad;

        public ServicioPropiedad(string filePath)
        {
            _repositorioPropiedad = new RepositorioPropiedad(filePath);
        }

        public void CrearPropiedad(Propiedad propiedad)
        {
            _repositorioPropiedad.AgregarPropiedad(propiedad);
        }

        public List<Propiedad> ObtenerPropiedades()
        {
            return _repositorioPropiedad.ObtenerTodos();
        }

        public Propiedad ObtenerPropiedadPorId(int id)
        {
            return _repositorioPropiedad.ObtenerPorId(id);
        }

        public void EliminarPropiedad(int id)
        {
            _repositorioPropiedad.EliminarPropiedad(id);
        }

        public void ModificarPropiedad(int id, Propiedad propiedadActualizada)
        {
            var propiedadExistente = _repositorioPropiedad.ObtenerPorId(id);
            if (propiedadExistente != null)
            {
                propiedadExistente.Direccion = propiedadActualizada.Direccion;
                propiedadExistente.Descripcion = propiedadActualizada.Descripcion;
                propiedadExistente.Precio = propiedadActualizada.Precio;
                propiedadExistente.Tipo = propiedadActualizada.Tipo;

                _repositorioPropiedad.ActualizarPropiedad(propiedadExistente);
            }
        }
    }
}

