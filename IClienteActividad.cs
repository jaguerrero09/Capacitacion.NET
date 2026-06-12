using System;
using System.Collections.Generic;
using System.Text;

namespace CapaCliente
{
    public interface IClienteActividad
    {

        void AgregarClienteActividad(ClienteActividad clienteActividad);

        ClienteActividad BuscarClienteActividadPorDocumento(int numeroDocumento);

        List<ClienteActividad> ObtenerTodosLosClienteActividad();

        bool EliminarClienteActividadPorDocumento(int numeroDocumento);

        bool ActualizarClienteActividadPorDocumento(int numeroDocumento, ClienteActividad clienteActividadActualizado);

    }
}
