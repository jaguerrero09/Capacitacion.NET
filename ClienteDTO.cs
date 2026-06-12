using System;
using System.Collections.Generic;
using System.Text;

namespace CapaCliente
{
    // Tiene que ir como public. Funciona como estructura de datos de PBuilder
    public class ClienteDTO
    {
        // Atributos (Solo contiene los atributos)
        // No tiene metodos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
    }
}
