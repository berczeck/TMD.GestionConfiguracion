using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.CF.Entidades
{
    public class Proyecto : Base
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Usuario JefeProyecto { get; set; }
        public Cliente Cliente { get; set; }
        public String Estado { get; set; }
        public List<ProyectoFase> Fases { get; set; }
    }
}
