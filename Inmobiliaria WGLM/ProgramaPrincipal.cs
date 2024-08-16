using Inmobiliaria.Entidades;
using Inmobiliaria.Negocio;
using System;

namespace Inmobiliaria
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            var servicioPropiedad = new ServicioPropiedad("Propiedades.json");
            var servicioCliente = new ServicioCliente("Clientes.json");
            var servicioContrato = new ServicioContrato("Contratos.json");
            var servicioPago = new ServicioPago("Pagos.json");
            var servicioAgentes = new ServicioAgentes("Agentes.json");

            while (true)
            {
                Console.WriteLine("\n ---Bienvenido a la Inmobiliaria WGLM---");
                Console.WriteLine("1. Administrar Propiedades");
                Console.WriteLine("2. Administrar Clientes");
                Console.WriteLine("3. Administrar Contratos");
                Console.WriteLine("4. Administrar Pagos");
                Console.WriteLine("5. Administrar Agentes");
                Console.WriteLine("6. Generar Reportes");
                Console.WriteLine("7. Salir");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AdministrarPropiedades(servicioPropiedad);
                        break;
                    case "2":
                        AdministrarClientes(servicioCliente);
                        break;
                    case "3":
                        AdministrarContratos(servicioContrato, servicioCliente, servicioPropiedad);
                        break;
                    case "4":
                        AdministrarPagos(servicioPago, servicioContrato);
                        break;
                    case "5":
                        AdministrarAgentes(servicioAgentes);
                        break;
                    case "6":
                        GenerarReportes(servicioPropiedad, servicioCliente, servicioContrato, servicioPago, servicioAgentes);
                        break;
                    case "7":
                        Console.WriteLine("Saliendo del sistema...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void AdministrarPropiedades(ServicioPropiedad servicioPropiedad)
{
    while (true)
    {
        Console.WriteLine("\n -Administración de Propiedades-");
        Console.WriteLine("1. Listar Propiedades");
        Console.WriteLine("2. Agregar Propiedad");
        Console.WriteLine("3. Modificar Propiedad");
        Console.WriteLine("4. Eliminar Propiedad");
        Console.WriteLine("5. Volver al Menú Principal");

        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ListarPropiedades(servicioPropiedad);
                break;
            case "2":
                AgregarPropiedad(servicioPropiedad);
                break;
            case "3":
                ModificarPropiedad(servicioPropiedad);
                break;
            case "4":
                EliminarPropiedad(servicioPropiedad);
                break;
            case "5":
                return;
            default:
                Console.WriteLine("Opción no válida, intenta de nuevo.");
                break;
        }
    }
}

private static void ListarPropiedades(ServicioPropiedad servicioPropiedad)
{
    var propiedades = servicioPropiedad.ObtenerPropiedades();
    if (propiedades.Count == 0)
    {
        Console.WriteLine("No hay propiedades registradas.");
    }
    else
    {
        Console.WriteLine("Lista de Propiedades:");
        foreach (var propiedad in propiedades)
        {
            Console.WriteLine($"ID: {propiedad.Id}, Dirección: {propiedad.Direccion}, Tipo: {propiedad.Tipo}, Precio: {propiedad.Precio}, Propietario: {propiedad.Propietario}, Descripción: {propiedad.Descripcion}");
        }
    }
}

private static void AgregarPropiedad(ServicioPropiedad servicioPropiedad)
{
    Console.WriteLine("Agregar nueva propiedad:");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Dirección: ");
    string direccion = Console.ReadLine();
    Console.Write("Tipo: ");
    string tipo = Console.ReadLine();
    Console.Write("Precio: ");
    decimal precio = decimal.Parse(Console.ReadLine());
    Console.Write("Propietario: ");
    string propietario = Console.ReadLine();
    Console.Write("Descripción: ");
    string descripcion = Console.ReadLine();

    var nuevaPropiedad = new Propiedad(id, direccion, tipo, precio, propietario, descripcion);
    servicioPropiedad.CrearPropiedad(nuevaPropiedad);
    Console.WriteLine("Propiedad agregada exitosamente.");
}

private static void ModificarPropiedad(ServicioPropiedad servicioPropiedad)
{
    Console.Write("Ingrese el ID de la propiedad a modificar: ");
    int id = int.Parse(Console.ReadLine());
    var propiedadExistente = servicioPropiedad.ObtenerPropiedadPorId(id);

    if (propiedadExistente != null)
    {
        Console.Write("Nueva Dirección: ");
        propiedadExistente.Direccion = Console.ReadLine();
        Console.Write("Nuevo Tipo: ");
        propiedadExistente.Tipo = Console.ReadLine();
        Console.Write("Nuevo Precio: ");
        propiedadExistente.Precio = decimal.Parse(Console.ReadLine());
        Console.Write("Nuevo Propietario: ");
        propiedadExistente.Propietario = Console.ReadLine();
        Console.Write("Nueva Descripción: ");
        propiedadExistente.Descripcion = Console.ReadLine();

        servicioPropiedad.ModificarPropiedad(id, propiedadExistente);
        Console.WriteLine("Propiedad modificada exitosamente.");
    }
    else
    {
        Console.WriteLine("Propiedad no encontrada.");
    }
}

private static void EliminarPropiedad(ServicioPropiedad servicioPropiedad)
{
    Console.Write("Ingrese el ID de la propiedad a eliminar: ");
    int id = int.Parse(Console.ReadLine());
    servicioPropiedad.EliminarPropiedad(id);
    Console.WriteLine("Propiedad eliminada exitosamente.");
}

       static void AdministrarClientes(ServicioCliente servicioCliente)
{
    while (true)
    {
        Console.WriteLine("\n -Administración de Clientes-");
        Console.WriteLine("1. Listar Clientes");
        Console.WriteLine("2. Agregar Cliente");
        Console.WriteLine("3. Modificar Cliente");
        Console.WriteLine("4. Eliminar Cliente");
        Console.WriteLine("5. Volver al Menú Principal");

        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ListarClientes(servicioCliente);
                break;
            case "2":
                AgregarCliente(servicioCliente);
                break;
            case "3":
                ModificarCliente(servicioCliente);
                break;
            case "4":
                EliminarCliente(servicioCliente);
                break;
            case "5":
                return;
            default:
                Console.WriteLine("Opción no válida, intenta de nuevo.");
                break;
        }
    }
}

private static void ListarClientes(ServicioCliente servicioCliente)
{
    var clientes = servicioCliente.ObtenerClientees();
    if (clientes.Count == 0)
    {
        Console.WriteLine("No hay clientes registrados.");
    }
    else
    {
        Console.WriteLine("Lista de Clientes:");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"{cliente.Id} - {cliente.Nombre} {cliente.Apellido}");
        }
    }
}

private static void AgregarCliente(ServicioCliente servicioCliente)
{
    Console.WriteLine("Agregar nuevo cliente:");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();
    Console.Write("Teléfono: ");
    string telefono = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();

    var nuevoCliente = new Cliente(id, nombre, apellido, telefono, email);
    servicioCliente.CrearCliente(nuevoCliente);
    Console.WriteLine("Cliente agregado exitosamente.");
}

private static void ModificarCliente(ServicioCliente servicioCliente)
{
    Console.Write("Ingrese el ID del Cliente a modificar: ");
    int id = int.Parse(Console.ReadLine());
    var clienteExistente = servicioCliente.ObtenerClientePorId(id);

    if (clienteExistente != null)
    {
        Console.Write("Nuevo Nombre: ");
        clienteExistente.Nombre = Console.ReadLine();
        Console.Write("Nuevo Apellido: ");
        clienteExistente.Apellido = Console.ReadLine();
        Console.Write("Nuevo Teléfono: ");
        clienteExistente.Telefono = Console.ReadLine();
        Console.Write("Nuevo Email: ");
        clienteExistente.Email = Console.ReadLine();

        servicioCliente.ModificarCliente(id, clienteExistente);
        Console.WriteLine("Cliente modificado exitosamente.");
    }
    else
    {
        Console.WriteLine("Cliente no encontrado.");
    }
}

private static void EliminarCliente(ServicioCliente servicioCliente)
{
    Console.Write("Ingrese el ID del Cliente a eliminar: ");
    int id = int.Parse(Console.ReadLine());
    servicioCliente.EliminarCliente(id);
    Console.WriteLine("Cliente eliminado exitosamente.");
}
        static void AdministrarContratos(ServicioContrato servicioContrato, ServicioCliente servicioCliente, ServicioPropiedad servicioPropiedad)
{
    while (true)
    {
        Console.WriteLine("\n -Administración de Contratos-");
        Console.WriteLine("1. Listar Contratos");
        Console.WriteLine("2. Agregar Contrato");
        Console.WriteLine("3. Modificar Contrato");
        Console.WriteLine("4. Eliminar Contrato");
        Console.WriteLine("5. Volver al Menú Principal");

        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ListarContratos(servicioContrato);
                break;

            case "2":
                AgregarContrato(servicioContrato, servicioCliente, servicioPropiedad);
                break;

            case "3":
                ModificarContrato(servicioContrato);
                break;

            case "4":
                EliminarContrato(servicioContrato);
                break;

            case "5":
                return;

            default:
                Console.WriteLine("Opción no válida, intenta de nuevo.");
                break;
        }
    }
}

private static void ListarContratos(ServicioContrato servicioContrato)
{
    var contratos = servicioContrato.ObtenerContratos();
    if (contratos.Count == 0)
    {
        Console.WriteLine("No hay contratos registrados.");
    }
    else
    {
        Console.WriteLine("Lista de Contratos:");
        foreach (var contrato in contratos)
        {
            Console.WriteLine($"{contrato.Id} - Propiedad: {contrato.Propiedad.Direccion} - Cliente: {contrato.Cliente.Nombre} {contrato.Cliente.Apellido} - Monto: {contrato.Monto}");
        }
    }
}

private static void AgregarContrato(ServicioContrato servicioContrato, ServicioCliente servicioCliente, ServicioPropiedad servicioPropiedad)
{
    Console.WriteLine("Agregar nuevo contrato:");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.WriteLine("Seleccione la propiedad:");
    var propiedades = servicioPropiedad.ObtenerPropiedades();
    foreach (var propiedad in propiedades)
    {
        Console.WriteLine($"{propiedad.Id} - {propiedad.Direccion}");
    }
    Console.Write("ID de la propiedad: ");
    int idPropiedad = int.Parse(Console.ReadLine());
    var propiedadSeleccionada = servicioPropiedad.ObtenerPropiedadPorId(idPropiedad);

    Console.WriteLine("Seleccione el cliente:");
    var clientes = servicioCliente.ObtenerClientees();
    foreach (var cliente in clientes)
    {
        Console.WriteLine($"{cliente.Id} - {cliente.Nombre} {cliente.Apellido}");
    }
    Console.Write("ID del cliente: ");
    int idCliente = int.Parse(Console.ReadLine());
    var clienteSeleccionado = servicioCliente.ObtenerClientePorId(idCliente);

    Console.Write("Monto: ");
    decimal monto = decimal.Parse(Console.ReadLine());
    Console.Write("Fecha de Inicio (dd/mm/yyyy): ");
    DateTime fechaInicio = DateTime.Parse(Console.ReadLine());
    Console.Write("Fecha de Fin (dd/mm/yyyy): ");
    DateTime fechaFin = DateTime.Parse(Console.ReadLine());

    var nuevoContrato = new Contrato(id, propiedadSeleccionada, clienteSeleccionado, monto, fechaInicio, fechaFin);
    servicioContrato.CrearContrato(nuevoContrato);
    Console.WriteLine("Contrato agregado exitosamente.");
}

private static void ModificarContrato(ServicioContrato servicioContrato)
{
    Console.Write("Ingrese el ID del contrato a modificar: ");
    int id = int.Parse(Console.ReadLine());
    var contratoExistente = servicioContrato.ObtenerContratoPorId(id);

    if (contratoExistente != null)
    {
        Console.Write("Nuevo Monto: ");
        contratoExistente.Monto = decimal.Parse(Console.ReadLine());
        Console.Write("Nueva Fecha de Inicio (dd/mm/yyyy): ");
        contratoExistente.FechaInicio = DateTime.Parse(Console.ReadLine());
        Console.Write("Nueva Fecha de Fin (dd/mm/yyyy): ");
        contratoExistente.FechaFin = DateTime.Parse(Console.ReadLine());

        servicioContrato.ModificarContrato(id, contratoExistente);
        Console.WriteLine("Contrato modificado exitosamente.");
    }
    else
    {
        Console.WriteLine("Contrato no encontrado.");
    }
}

private static void EliminarContrato(ServicioContrato servicioContrato)
{
    Console.Write("Ingrese el ID del contrato a eliminar: ");
    int id = int.Parse(Console.ReadLine());
    servicioContrato.EliminarContrato(id);
    Console.WriteLine("Contrato eliminado exitosamente.");
}

        static void AdministrarPagos(ServicioPago servicioPago, ServicioContrato servicioContrato)
{
    while (true)
    {
        Console.WriteLine("\n -Administración de Pagos-");
        Console.WriteLine("1. Listar Pagos");
        Console.WriteLine("2. Agregar Pago");
        Console.WriteLine("3. Modificar Pago");
        Console.WriteLine("4. Eliminar Pago");
        Console.WriteLine("5. Volver al Menú Principal");

        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ListarPagos(servicioPago);
                break;

            case "2":
                AgregarPago(servicioPago, servicioContrato);
                break;

            case "3":
                ModificarPago(servicioPago);
                break;

            case "4":
                EliminarPago(servicioPago);
                break;

            case "5":
                return;

            default:
                Console.WriteLine("Opción no válida, intenta de nuevo.");
                break;
        }
    }
}

private static void ListarPagos(ServicioPago servicioPago)
{
    var pagos = servicioPago.ObtenerPagos();
    if (pagos.Count == 0)
    {
        Console.WriteLine("No hay pagos registrados.");
    }
    else
    {
        Console.WriteLine("Lista de Pagos:");
        foreach (var pago in pagos)
        {
            Console.WriteLine($"{pago.Id} - Monto: {pago.Monto} - Fecha: {pago.Fecha.ToShortDateString()}");
        }
    }
}

private static void AgregarPago(ServicioPago servicioPago, ServicioContrato servicioContrato)
{
    Console.WriteLine("Agregar nuevo pago:");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.WriteLine("Seleccione el contrato para el pago:");
    var contratos = servicioContrato.ObtenerContratos();
    foreach (var contrato in contratos)
    {
        Console.WriteLine($"{contrato.Id} - Propiedad: {contrato.Propiedad.Direccion} - Cliente: {contrato.Cliente.Nombre} {contrato.Cliente.Apellido}");
    }
    Console.Write("ID del contrato: ");
    int idContrato = int.Parse(Console.ReadLine());
    var contratoSeleccionado = servicioContrato.ObtenerContratoPorId(idContrato);

    Console.Write("Monto: ");
    decimal monto = decimal.Parse(Console.ReadLine());
    Console.Write("Fecha (dd/mm/yyyy): ");
    DateTime fecha = DateTime.Parse(Console.ReadLine());

    var nuevoPago = new Pago(id, contratoSeleccionado, monto, fecha);
    servicioPago.CrearPago(nuevoPago);
    Console.WriteLine("Pago agregado exitosamente.");
}

private static void ModificarPago(ServicioPago servicioPago)
{
    Console.Write("Ingrese el ID del pago a modificar: ");
    int id = int.Parse(Console.ReadLine());
    var pagoExistente = servicioPago.ObtenerPagoPorId(id);

    if (pagoExistente != null)
    {
        Console.Write("Nuevo Monto: ");
        pagoExistente.Monto = decimal.Parse(Console.ReadLine());
        Console.Write("Nueva Fecha (dd/mm/yyyy): ");
        pagoExistente.Fecha = DateTime.Parse(Console.ReadLine());

        servicioPago.ModificarPago(id, pagoExistente);
        Console.WriteLine("Pago modificado exitosamente.");
    }
    else
    {
        Console.WriteLine("Pago no encontrado.");
    }
}

private static void EliminarPago(ServicioPago servicioPago)
{
    Console.Write("Ingrese el ID del pago a eliminar: ");
    int id = int.Parse(Console.ReadLine());
    servicioPago.EliminarPago(id);
    Console.WriteLine("Pago eliminado exitosamente.");
}

        static void AdministrarAgentes(ServicioAgentes servicioAgentes)
{
    while (true)
    {
        Console.WriteLine("\n -Administración de Agentes-");
        Console.WriteLine("1. Listar Agentes");
        Console.WriteLine("2. Agregar Agente");
        Console.WriteLine("3. Modificar Agente");
        Console.WriteLine("4. Eliminar Agente");
        Console.WriteLine("5. Volver al Menú Principal");

        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ListarAgentes(servicioAgentes);
                break;

            case "2":
                AgregarAgente(servicioAgentes);
                break;

            case "3":
                ModificarAgente(servicioAgentes);
                break;

            case "4":
                EliminarAgente(servicioAgentes);
                break;

            case "5":
                return;

            default:
                Console.WriteLine("Opción no válida, intenta de nuevo.");
                break;
        }
    }
}

private static void ListarAgentes(ServicioAgentes servicioAgentes)
{
    var agentes = servicioAgentes.ObtenerAgentes();
    if (agentes.Count == 0)
    {
        Console.WriteLine("No hay agentes registrados.");
    }
    else
    {
        Console.WriteLine("Lista de Agentes:");
        foreach (var agente in agentes)
        {
            Console.WriteLine($"{agente.Id} - {agente.Nombre} {agente.Apellido} - Puesto: {agente.Puesto} - Salario: {agente.Salario}");
        }
    }
}

private static void AgregarAgente(ServicioAgentes servicioAgentes)
{
    Console.WriteLine("Agregar nuevo agente:");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();
    Console.Write("Puesto: ");
    string puesto = Console.ReadLine();
    Console.Write("Salario: ");
    decimal salario = decimal.Parse(Console.ReadLine());

    var nuevoAgente = new Agentes(id, nombre, apellido, puesto, salario);
    servicioAgentes.CrearAgentes(nuevoAgente);
    Console.WriteLine("Agente agregado exitosamente.");
}

private static void ModificarAgente(ServicioAgentes servicioAgentes)
{
    Console.Write("Ingrese el ID del agente a modificar: ");
    int id = int.Parse(Console.ReadLine());
    var agenteExistente = servicioAgentes.ObtenerAgentesPorId(id);

    if (agenteExistente != null)
    {
        Console.Write("Nuevo Nombre: ");
        agenteExistente.Nombre = Console.ReadLine();
        Console.Write("Nuevo Apellido: ");
        agenteExistente.Apellido = Console.ReadLine();
        Console.Write("Nuevo Puesto: ");
        agenteExistente.Puesto = Console.ReadLine();
        Console.Write("Nuevo Salario: ");
        agenteExistente.Salario = decimal.Parse(Console.ReadLine());

        servicioAgentes.ModificarAgente(id, agenteExistente);
        Console.WriteLine("Agente modificado exitosamente.");
    }
    else
    {
        Console.WriteLine("Agente no encontrado.");
    }
}

private static void EliminarAgente(ServicioAgentes servicioAgentes)
{
    Console.Write("Ingrese el ID del agente a eliminar: ");
    int id = int.Parse(Console.ReadLine());
    servicioAgentes.EliminarAgentes(id);
    Console.WriteLine("Agente eliminado exitosamente.");
}

       static void GenerarReportes(ServicioPropiedad servicioPropiedad, ServicioCliente servicioCliente, ServicioContrato servicioContrato, ServicioPago servicioPago, ServicioAgentes servicioAgentes)
{
    Console.WriteLine("\n -Generación de Reportes-");
    Console.WriteLine("1. Reporte de Propiedades");
    Console.WriteLine("2. Reporte de Clientes");
    Console.WriteLine("3. Reporte de Contratos");
    Console.WriteLine("4. Reporte de Pagos");
    Console.WriteLine("5. Reporte de Agentes");
    Console.Write("Seleccione una opción: ");
    
    var opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            var propiedades = servicioPropiedad.ObtenerPropiedades();
            foreach (var propiedad in propiedades)
            {
                Console.WriteLine($"{propiedad.Id} - Dirección: {propiedad.Direccion}, Tipo: {propiedad.Tipo}, Precio: {propiedad.Precio}");
            }
            break;

        case "2":
            var clientes = servicioCliente.ObtenerClientees(); // Asegúrate de que este método esté definido
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{cliente.Id} - {cliente.Nombre} {cliente.Apellido}");
            }
            break;

        case "3":
            var contratos = servicioContrato.ObtenerContratos(); // Asegúrate de que este método esté definido
            foreach (var contrato in contratos)
            {
                Console.WriteLine($"{contrato.Id} - Propiedad: {contrato.Propiedad.Direccion} - Cliente: {contrato.Cliente.Nombre} {contrato.Cliente.Apellido}");
            }
            break;

        case "4":
            var pagos = servicioPago.ObtenerPagos(); // Asegúrate de que este método esté definido
            foreach (var pago in pagos)
            {
                Console.WriteLine($"{pago.Id} - Monto: {pago.Monto} - Fecha: {pago.Fecha.ToShortDateString()}");
            }
            break;

        case "5":
            var agentes = servicioAgentes.ObtenerAgentes(); // Asegúrate de que este método esté definido
            foreach (var agente in agentes)
            {
                Console.WriteLine($"{agente.Id} - {agente.Nombre} {agente.Apellido} - Puesto: {agente.Puesto}");
            }
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}
    }
}