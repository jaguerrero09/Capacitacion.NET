using CapaCliente;
using System.Runtime.Intrinsics.Arm;

namespace CapaCliente
{
    // Simula capa de presentacion de la aplicacion
    class Program
    {

        static ClienteTabla clienteTabla = new ClienteTabla();

        static void Main(string[] args)
        {
            int opcion;
            

            opcion = 1;

            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu de clientes");
                Console.WriteLine("Opcion 1 Alta de cliente");
                Console.WriteLine("Opcion 2 Modificacion de cliente");
                Console.WriteLine("Opcion 3 Baja de cliente");
                Console.WriteLine("Opcion 4 Busqueda de cliente");
                Console.WriteLine("Opcion 5 Mostrar todos los cliente");
                Console.WriteLine("Opcion 0 Salir");
                Console.Write("Elija una opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {

                    // Console.WriteLine($"\nSeleccionaste la opcion: {opcion}");

                    // Aquí es donde usualmente pondrías un switch para manejar cada opción
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ejecutando Alta de cliente...");
                            InsertarCliente();
                            break;
                        case 2:
                            Console.WriteLine("Ejecutando Modificación...");
                            break;
                        case 5:
                            Console.WriteLine("Mostrando datos de clientes");
                            MostrarClientes();
                            break;
                        //default:
                        //    Console.WriteLine("Esa opción no existe en el menú.");
                        //    break;
                    }
                }
                else
                {
                    opcion = 1;
                    // Console.WriteLine("\nError: Por favor, ingresa un número válido.");
                }

            }  /* Fin While */

            // Console.WriteLine("\nPresione cualquier tecla para salir...");
            // Console.ReadKey();

        }

        private static void InsertarCliente()
        {
            //throw new NotImplementedException();

            // Crear otro objeto derivado de la misma clase
            Cliente cliente2 = new Cliente("Angel", "Kame", 2345678, new DateTime(2000, 10, 10), "M", "Peron 2302");

            // Crear objeto mediante Data Transfer Object
            ClienteDTO ClienteDTO = new ClienteDTO
            {
                Nombre = "Pablo",
                Apellido = "Gomez",
                NumeroDocumento = 3456789,
                FechaNacimiento = new DateTime(1995, 11, 11),
                Sexo = "M",
                Direccion = "Peron 2302"
            };


            Cliente cliente3 = new Cliente(ClienteDTO);


            clienteTabla.AgregarCliente(cliente2);

            clienteTabla.AgregarCliente(cliente3);


        }

        private static void MostrarClientes()
        {
            // throw new NotImplementedException();

            Console.Clear();

            List<Cliente> Respuesta;

            Respuesta = clienteTabla.ObtenerTodosLosCliente();

            for (int i = 0; i < Respuesta.Count; i++)
            {
                Console.WriteLine("Cliente: " + Respuesta[i].Apellido + ", " + Respuesta[i].Nombre);
            }

            Console.ReadKey();

        }
    }
}


/*************

// Crear otro objeto derivado de la misma clase
Cliente cliente2 = new Cliente("Angel", "Kame", 2345678, new DateTime(2000, 10, 10), "M", "Peron 2302");

// Crear objeto mediante Data Transfer Object
ClienteDTO ClienteDTO = new ClienteDTO
{
    Nombre = "Pablo",
    Apellido = "Gomez",
    NumeroDocumento = 3456789,
    FechaNacimiento = new DateTime(1995, 11, 11),
    Sexo = "M",
    Direccion = "Peron 2302"
};


ClienteTabla clienteTabla = new ClienteTabla();

Cliente cliente3 = new Cliente(ClienteDTO);


clienteTabla.AgregarCliente(cliente2);

clienteTabla.AgregarCliente(cliente3);

List<Cliente> Respuesta;

Respuesta=clienteTabla.ObtenerTodosLosCliente();

for (int i=0; i<Respuesta.Count; i++)
{
    Console.WriteLine("Apellido "+Respuesta[i].Apellido+", Nombre " + Respuesta[i].Nombre);
}

************/



