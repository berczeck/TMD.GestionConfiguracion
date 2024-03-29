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
    /// Implementa el Acceso a datos de la entidad Usuario.
    /// </summary>
    public class UsuarioData : DataBase, IUsuarioData
    {

        public UsuarioData(String connectionString)
            : base(connectionString)
        {
        }

        /// <summary>
        /// Lista los usuario de un proyecto.
        /// </summary>
        /// <param name="proyecto">Proyecto</param>
        /// <returns>List Usuario</returns>
        public List<Usuario> ListaPorProyecto(Proyecto proyecto)
        {
            List<Usuario> listaUsuario = new List<Usuario>();

            using (DbCommand command = DB.GetStoredProcCommand("dbo.USP_FASE_PROYECO_SEL"))
            {
                DB.AddInParameter(command, "@CODIGO_PROYECTO", DbType.Int32, proyecto.Id);

                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaUsuario.Add(UsuarioDataMap.Select(reader));
                    }
                }
            }

            return listaUsuario;
        }
    }
}
