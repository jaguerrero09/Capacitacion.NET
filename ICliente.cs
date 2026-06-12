using System;
using System.Collections.Generic;
using System.Text;

namespace CapaCliente
{
    public interface ICliente
    {
        // Firma de los metodos Nombre del metodo, Parametro de entrada, Parametros de salida 
        void AgregarCliente(Cliente cliente);

        Cliente BuscarClientePorDocumento(int numeroDocumento);

        List<Cliente> ObtenerTodosLosCliente();

        bool EliminarClientePorDocumento(int numeroDocumento);

        bool ActualizarClientePorDocumento(int numeroDocumento, Cliente clienteActualizado);
    }
}
