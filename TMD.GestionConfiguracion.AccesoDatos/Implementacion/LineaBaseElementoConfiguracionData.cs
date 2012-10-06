using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.AccesoDatos.Contrato;
using TMD.CF.AccesoDatos.Core;
using TMD.CF.Entidades;
using System.Data.Common;
using System.Data;

namespace TMD.CF.AccesoDatos.Implementacion
{
    public class LineaBaseElementoConfiguracionData : DataBase, ILineaBaseElementoConfiguracionData
    {
        public LineaBaseElementoConfiguracionData(String connectionString)
            : base(connectionString)
        {
        }

        /// <summary>
        /// Agrega un registro a la tabla Elemento de Configuracion Linea Base.
        /// </summary>
        /// <param name="elemento">ElementoConfiguracion</param>
        public void Agregar(LineaBaseElementoConfiguracion elemento)
        {
            using (DbCommand command = DB.GetStoredProcCommand("dbo.USP_ELEMENTO_CONFIGURACION_INS"))
            {
                DB.AddInParameter(command, "@VERSION_MAYOR", DbType.Int32, elemento.Version.Mayor);
                DB.AddInParameter(command, "@VERSION_MENOR", DbType.Int32, elemento.Version.Menor);
                DB.AddInParameter(command, "@CODIGO_LINEA_BASE", DbType.Int32, elemento.LineaBase.Id);
                DB.AddInParameter(command, "@CODIGO_ELEMENTO_CONFIGURACION", DbType.Int32, elemento.ElementoConfiguracion.Id);
                DB.AddInParameter(command, "@CODIGO_USUARIO_RESPONSABLE", DbType.Int32, elemento.Responsable.Id);

                DB.AddOutParameter(command, "@CODIGO", DbType.Int32, 4);

                DB.ExecuteNonQuery(command);

                elemento.Id = Convert.ToInt32(DB.GetParameterValue(command, "@CODIGO"));
            }
        }
    }
}
