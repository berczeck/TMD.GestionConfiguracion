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
    /// <summary>
    /// Implementa el Acceso a datos de la entidad Proyecto.
    /// </summary>
    public class ProyectoData : DataBase, IProyectoData
    {
        public ProyectoData(String connectionString)
            : base(connectionString)
        {
        }

        /// <summary>
        /// Lista los proyectos de un Usuario.
        /// </summary>
        /// <param name="usuario">Objeto Usuario</param>
        /// <returns>List Proyecto</returns>
        public List<Proyecto> ListarPorUsuario(Usuario usuario)
        {
            List<Proyecto> listaProyecto = new List<Proyecto>();

            using (DbCommand command = DB.GetStoredProcCommand("dbo.USP_PROYECTO_SEL_CODIGO_USUARIO"))
            {
                DB.AddInParameter(command, "@CODIGO_USUARIO", DbType.Int32, usuario.Id);

                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaProyecto.Add(ProyectoDataMap.Select(reader));
                    }   
                }
            }

            return listaProyecto;
        }
    }
}
