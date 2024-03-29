﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.AccesoDatos.Core;
using TMD.CF.AccesoDatos.Contrato;
using TMD.CF.Entidades;
using System.Data.Common;
using System.Data;
using TMD.CF.AccesoDatos.Map;

namespace TMD.CF.AccesoDatos.Implementacion
{
    public class ElementoConfiguracionData : DataBase, IElementoConfiguracionData
    {
        public ElementoConfiguracionData(String connectionString)
            : base(connectionString)
        {
        }

        /// <summary>
        /// Lista los Elementos de configuracion por Fase.
        /// </summary>
        /// <param name="fase">Fase</param>
        /// <returns>Lista ElementoConfiguracion</returns>
        public List<ElementoConfiguracion> ListarPorFase(Fase fase)
        {
            List<ElementoConfiguracion> listaElemento = new List<ElementoConfiguracion>();

            using (DbCommand command = DB.GetStoredProcCommand("dbo.USP_ELEMENTO_CONFIGURACION_SEL"))
            {
                DB.AddInParameter(command, "@CODIGO_FASE", DbType.Int32, fase.Id);

                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaElemento.Add(ElementoConfiguracionMap.Select(reader));
                    }
                }
            }

            return listaElemento;
        }        
    }
}
