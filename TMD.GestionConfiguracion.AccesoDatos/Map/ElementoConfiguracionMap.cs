﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.Entidades;
using System.Data;
using TMD.CF.AccesoDatos.Util;

namespace TMD.CF.AccesoDatos.Map
{
    static class ElementoConfiguracionMap
    {
        public static ElementoConfiguracion Select(IDataReader reader)
        {
            return new ElementoConfiguracion
            {
                Id = reader.GetInt("CODIGO"),
                Nombre = reader.GetString("NOMBRE"),
                Descripcion = reader.GetString("DECRIPCION"),
                Fase = new Fase
                {
                    Id = reader.GetInt("CODIGO_FASE")
                },
                Tipo = "DOC".Equals(reader.GetInt("TIPO")) ? TipoElementoConfiguracion.Documento : TipoElementoConfiguracion.Release
            };
        }
    }
}
