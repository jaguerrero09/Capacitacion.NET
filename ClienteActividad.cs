using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaCliente
{
    public class ClienteActividad
    {
        // Atributos
        public int NumeroDocumento { get; set; }
        public int CodigoActividad { get; set; }
        public DateTime FechaInicio { get; set; }

        public ClienteActividad(int numeroDocumento, int codigoActividad, DateTime fechaInicio)
        {

            ValidarClienteActividad(numeroDocumento, codigoActividad, fechaInicio);

            NumeroDocumento = numeroDocumento;
            CodigoActividad = codigoActividad;
            FechaInicio = fechaInicio;
        }

        public ClienteActividad(ClienteActividadDTO clienteActividadDTO)
        {
            ValidarClienteActividad(clienteActividadDTO.NumeroDocumento, clienteActividadDTO.CodigoActividad, clienteActividadDTO.FechaInicio);

            NumeroDocumento = clienteActividadDTO.NumeroDocumento;
            CodigoActividad = clienteActividadDTO.CodigoActividad;
            FechaInicio = clienteActividadDTO.FechaInicio;
        }


        private void ValidarClienteActividad(int numeroDocumento, int codigoActividad, DateTime fechaInicio)
        {
            if (numeroDocumento <= 0)
            {
                throw new ArgumentNullException("El numeroDocumento no puede ser menor a cero");
            }
            if (codigoActividad <= 0)
            {
                throw new ArgumentNullException("El codigoActividad no puede ser menor a cero");
            }
            if (fechaInicio > DateTime.Today)
            {
                throw new ArgumentNullException("El fechaInicio no puede ser mayor a hoy");
            }
        }

    }
}
