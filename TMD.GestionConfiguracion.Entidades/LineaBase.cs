﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.CF.Entidades
{
    public class LineaBase : Base
    {
        public int Id { get; set; }
        public ProyectoFase ProyectoFase { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Estado { get; set; }
        public DateTime FechaLiberacion { get; set; }
    }
}
