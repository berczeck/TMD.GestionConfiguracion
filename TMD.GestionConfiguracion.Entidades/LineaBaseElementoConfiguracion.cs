using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.CF.Entidades
{
    public class LineaBaseElementoConfiguracion
    {
        public int Id { get; set; }
        public ElementoConfiguracion ElementoConfiguracion { get; set; }
        public LineaBase LineaBase { get; set; }
        public Usuario Responsable { get; set; }
        public Version Version { get; set; }
    }
}
