using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.Entidades;

namespace TMD.CF.AccesoDatos.Contrato
{
    /// <summary>
    /// Contrato  del Acceso a datos de la entidad Linea Base.
    /// </summary>
    public interface ILineaBaseData
    {
        /// <summary>
        /// Agrega un registro a la tabla LineaBase.
        /// </summary>
        /// <param name="lineaBase">LineaBase</param>
        void Agregar(LineaBase lineaBase);

        /// <summary>
        /// Lista las lineas base de una fase de un proyecto.
        /// </summary>
        /// <param name="proyectoFase"></param>
        /// <returns></returns>
        List<LineaBase> ListarPorProyecto(Proyecto proyecto);
    }
}
