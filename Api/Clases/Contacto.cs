using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Clases
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Consulta { get; set; }
    }
}