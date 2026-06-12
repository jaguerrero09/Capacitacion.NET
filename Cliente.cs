using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaCliente
{
    public class Cliente
    {
        // Son atributos 
        public string Nombre { get; set; }
        public string Apellido { get; set; }   
        public int NumeroDocumento { get; set; } 
        public DateTime FechaNacimiento { get; set; }   
        public string Sexo { get; set; }
        public string Direccion { get; set; }

        
        // Metodos de construccion 

        // Constructor
        public Cliente (string nombre, string apellido, int numeroDocumento, DateTime fechaNacimiento, string sexo, string direccion)
        {
            ValidarCliente(nombre, apellido, numeroDocumento, fechaNacimiento, sexo, direccion);

            Nombre = nombre;
            Apellido = apellido;
            NumeroDocumento = numeroDocumento;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Direccion = direccion;
        }

        // Constructor con DTO 
        public Cliente(ClienteDTO clienteDTO)
        {
            ValidarCliente(clienteDTO.Nombre, clienteDTO.Apellido, clienteDTO.NumeroDocumento, clienteDTO.FechaNacimiento, clienteDTO.Sexo, clienteDTO.Direccion);

            Nombre = clienteDTO.Nombre;
            Apellido = clienteDTO.Apellido;
            NumeroDocumento = clienteDTO.NumeroDocumento;
            FechaNacimiento = clienteDTO.FechaNacimiento;
            Sexo = clienteDTO.Sexo;
            Direccion = clienteDTO.Direccion;
        }

        private void ValidarCliente(string nombre, string apellido, int numeroDocumento, DateTime fechaNacimiento, string sexo, string direccion)
        {
            // Aqui deberian ir las validaciones de cada campo
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentNullException("El nombre no puede ser vacio");
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                throw new ArgumentNullException("El apellido no puede ser vacio");
            }
            if (numeroDocumento <= 0)
            {
                throw new ArgumentNullException("El numeroDocumento no puede ser menor a cero");
            }
            if (fechaNacimiento > DateTime.Today)
            {
                throw new ArgumentNullException("El fechaNacimiento no puede ser mayor a hoy");
            }
            if (string.IsNullOrWhiteSpace(sexo))
            {
                throw new ArgumentNullException("El Sexo no puede ser  vacio");
            }
            if (string.IsNullOrWhiteSpace(direccion))
            {
                throw new ArgumentNullException("La direccion no puede ser  vacio");
            }
        }


    }
}
