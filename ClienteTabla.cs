using System;
using System.Collections.Generic;
using System.Text;

namespace CapaCliente
{
    public class ClienteTabla: ICliente
    {
        // Clase que administra Alta, Baja, Modificacion y Consulta

        // Definir la variable tabla
        private List<Cliente> Clientes {  get; set; }

        // Este es el constructor 
        public ClienteTabla()
        {
            Clientes = new List<Cliente>();
        }

        // Metodo para agregar datos de cliente 
        public void AgregarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof (cliente),"El cliente no puede ser nulo");
            Clientes.Add(cliente);
        }

        // Metodo para buscar cliente por numero de documento
        public Cliente BuscarClientePorDocumento(int numeroDocumento)
        {
            return Clientes.Find(c => c.NumeroDocumento == numeroDocumento);

        }

        // Metodo que devuelve todos los clientes de una lista
        public List<Cliente> ObtenerTodosLosCliente()
        {
            var retornodatos = Clientes;
            return retornodatos;
            // Otra manera de hacerlo
            // return new List<Cliente>(Clientes);
        }

        // Metodo para eliminar un cliente de la tabla de Clientes
        public bool EliminarClientePorDocumento(int numeroDocumento)
        {
            var cliente = BuscarClientePorDocumento(numeroDocumento);
            if (cliente != null) 
            {
                Clientes.Remove(cliente);
                return true;
            }
            return false;

        }

        // Metodo para actualizar un cliente
        public bool ActualizarClientePorDocumento(int numeroDocumento, Cliente clienteActualizado)
        {
            var cliente = BuscarClientePorDocumento(numeroDocumento);
            if (cliente != null)
            {
                cliente.Nombre = clienteActualizado.Nombre;
                cliente.Apellido = clienteActualizado.Apellido;
                cliente.NumeroDocumento = clienteActualizado.NumeroDocumento;
                cliente.FechaNacimiento = clienteActualizado.FechaNacimiento;
                cliente.Sexo = clienteActualizado.Sexo;
                cliente.Direccion = clienteActualizado.Direccion;
                return true;
            }
            return false;
        }
    }
}
