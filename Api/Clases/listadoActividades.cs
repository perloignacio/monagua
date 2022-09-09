using monaguaRules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Clases
{
    public class listadoActividades
    {
        public List<Provincias> provincias { get; set; }
        public List<Actividades> actividades { get; set; }

        public List<Categorias> categorias { get; set; }
        public List<Prestadores> prestadores { get; set; }
        public List<decimal> duracion { get; set; }

        public List<string> idiomas { get; set; }
        public List<string> dificultades { get; set; }
        public int cantPaginas { get; set; }
    }
}