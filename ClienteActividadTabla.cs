using System;
using System.Collections.Generic;
using System.Text;

namespace CapaCliente
{
    public class ClienteActividadTabla: IClienteActividad
    {

        // Clase que administra Alta, Baja, Modificacion y Consulta
        private List<ClienteActividad> ClienteActividades  { get; set; }

        public ClienteActividadTabla()
        {
            ClienteActividades = new List<ClienteActividad>();
        }

        // Metodo para agregar datos de Actividad
        public void AgregarClienteActividad(ClienteActividad clienteActividad)
        {
            if (clienteActividad == null)
                throw new ArgumentNullException(nameof(clienteActividad), "La actividad del cliente no puede ser nulo");
            ClienteActividades.Add(clienteActividad);
        }

        // Metodo para buscar cliente actividad por numero de documento
        public ClienteActividad BuscarClienteActividadPorDocumento(int numeroDocumento)
        {
            return ClienteActividades.Find(d => d.NumeroDocumento == numeroDocumento);

        }

        // Metodo que devuelve todos los clientes actividad de una lista
        public List<ClienteActividad> ObtenerTodosLosClienteActividad()
        {
            var retornodatos = ClienteActividades;
            return retornodatos;
            // Otra manera de hacerlo
            // return new List<Cliente>(Clientes);
        }

        // Metodo para eliminar un cliente de la tabla de Clientes
        public bool EliminarClienteActividadPorDocumento(int numeroDocumento)
        {
            var busqueda = BuscarClienteActividadPorDocumento(numeroDocumento);
            if (busqueda != null)
            {
                ClienteActividades.Remove(busqueda);
                return true;
            }
            return false;
        }

        // Metodo para actualizar un cliente
        public bool ActualizarClienteActividadPorDocumento(int numeroDocumento, ClienteActividad clienteActividadActualizado)
        {
            var busqueda = BuscarClienteActividadPorDocumento(numeroDocumento);
            if (busqueda != null)
            {
                busqueda.NumeroDocumento = clienteActividadActualizado.NumeroDocumento;
                busqueda.CodigoActividad = clienteActividadActualizado.CodigoActividad;
                busqueda.FechaInicio = clienteActividadActualizado.FechaInicio;
                return true;
            }
            return false;
        }

    }
}
