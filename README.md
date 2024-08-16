# Inmobiliaria WGLM

## Descripción

Inmobiliaria WGLM es un sistema de gestión inmobiliaria diseñado para facilitar la administración de propiedades, clientes, contratos, pagos y agentes. Este software permite a los usuarios llevar un control eficiente de las operaciones relacionadas con el sector inmobiliario, ofreciendo funcionalidades para agregar, modificar y eliminar registros, así como generar reportes.

## Estructura del Proyecto

El proyecto está organizado en varias clases que representan las entidades y servicios necesarios para la gestión inmobiliaria. A continuación se presenta una breve descripción de las principales clases:

### Entidades

- **Agentes**: Representa a los agentes inmobiliarios, incluyendo propiedades como `Id`, `Nombre`, `Apellido`, `Puesto` y `Salario`.

- **Cliente**: Representa a los clientes de la inmobiliaria, con propiedades como `Id`, `Nombre`, `Apellido`, `Telefono` y `Email`.

- **Contrato**: Representa los contratos de alquiler, incluyendo `Id`, `Propiedad`, `Cliente`, `Monto`, `FechaInicio` y `FechaFin`.

- **Pago**: Representa los pagos realizados, con propiedades como `Id`, `Contrato`, `Monto` y `Fecha`.

- **Propiedad**: Representa las propiedades disponibles, incluyendo `Id`, `Direccion`, `Tipo`, `Precio`, `Propietario` y `Descripcion`.

### Repositorios

Los repositorios son responsables de la gestión de datos, permitiendo realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre las entidades:

- **RepositorioAgentes**: Maneja las operaciones relacionadas con los agentes.

- **RepositorioCliente**: Maneja las operaciones relacionadas con los clientes.

- **RepositorioContrato**: Maneja las operaciones relacionadas con los contratos.

- **RepositorioPago**: Maneja las operaciones relacionadas con los pagos.

- **RepositorioPropiedad**: Maneja las operaciones relacionadas con las propiedades.

### Servicios

Los servicios encapsulan la lógica de negocio y utilizan los repositorios para realizar las operaciones necesarias:

- **ServicioAgentes**: Proporciona métodos para crear, obtener, eliminar y modificar agentes.

- **ServicioCliente**: Proporciona métodos para gestionar clientes.

- **ServicioContrato**: Proporciona métodos para gestionar contratos.

- **ServicioPago**: Proporciona métodos para gestionar pagos.

- **ServicioPropiedad**: Proporciona métodos para gestionar propiedades.

## Uso

Para utilizar el sistema, se debe ejecutar el programa principal, que presenta un menú interactivo donde se pueden seleccionar diferentes opciones para administrar propiedades, clientes, contratos, pagos y agentes. A continuación se muestra un ejemplo de cómo se estructura el menú principal:

```csharp
Console.WriteLine("\n ---Bienvenido a la Inmobiliaria WGLM---");
Console.WriteLine("1. Administrar Propiedades");
Console.WriteLine("2. Administrar Clientes");
Console.WriteLine("3. Administrar Contratos");
Console.WriteLine("4. Administrar Pagos");
Console.WriteLine("5. Administrar Agentes");
Console.WriteLine("6. Generar Reportes");
Console.WriteLine("7. Salir");
```

## Requisitos

- .NET Framework 5.0 o superior.
- Newtonsoft.Json para la serialización y deserialización de datos.

## Contribuciones

Las contribuciones son bienvenidas. Para contribuir, por favor sigue estos pasos:

1. Haz un fork del proyecto.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -m 'Añadir nueva funcionalidad'`).
4. Haz push a la rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un Pull Request.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.

Citations:
[1] https://ppl-ai-file-upload.s3.amazonaws.com/web/direct-files/2012438/2fb99504-22cd-4ad8-89f1-3bad47c77e11/paste.txt
