using System;
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
    /// Contrato  del Acceso a datos de la entidad Linea Base.
    /// </summary>
    public class LineaBaseData : DataBase, ILineaBaseData
    {
        public LineaBaseData(String connectionString)
            : base(connectionString)
        {
        }

        /// <summary>
        /// Agrega un registro a la tabla LineaBase.
        /// </summary>
        /// <param name="lineaBase">LineaBase</param>
        public void Agregar(LineaBase lineaBase)
        {
            using (DbCommand command = DB.GetStoredProcCommand("dbo.USP_FASE_INS"))
            {
                DB.AddInParameter(command, "@NOMBRE", DbType.String, lineaBase.Nombre);
                DB.AddInParameter(command, "@CODIGO_FASE", DbType.Int32, lineaBase.ProyectoFase.Id);
                DB.AddInParameter(command, "@DESCRIPCION", DbType.String, lineaBase.Descripcion);
                DB.AddInParameter(command, "@ESTADO", DbType.String, lineaBase.Estado);

                DB.AddOutParameter(command, "@CODIGO", DbType.Int32, 4);

                DB.ExecuteNonQuery(command);

                lineaBase.Id = Convert.ToInt32(DB.GetParameterValue(command, "@CODIGO"));
            }
        }

        /// <summary>
        /// Lista las lineas base de un proyecto.
        /// </summary>
        /// <param name="proyectoFase"></param>
        /// <returns></returns>
        public List<LineaBase> ListarPorProyecto(Proyecto proyecto)
        {
            List<LineaBase> listaLineaBase = new List<LineaBase>();

            using (DbCommand command = DB.GetStoredProcCommand("dbo.USP_LINEA_BASE_SEL_CODIGO_PROYECTO"))
            {
                DB.AddInParameter(command, "@CODIGO_PROYECTO", DbType.Int32, proyecto.Id);

                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaLineaBase.Add(LineaBaseMap.Select(reader));
                    }
                }
            }

            return listaLineaBase;
        }
    }
}
