using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.LogicaNegocios.Contrato;
using TMD.CF.AccesoDatos.Contrato;
using TMD.CF.Entidades;

namespace TMD.CF.LogicaNegocios.Implementacion
{
    /// <summary>
    /// Implementa  la Logica de Negocios de la entidad Linea Base.
    /// </summary>
    public class LineaBaseLogica : ILineaBaseLogica
    {
        private readonly ILineaBaseData _lineaBaseData;

        public LineaBaseLogica(ILineaBaseData lineaBaseData)
        {
            _lineaBaseData = lineaBaseData;
        }

        /// <summary>
        /// Agrega un registro a la tabla LineaBase.
        /// </summary>
        /// <param name="lineaBase">LineaBase</param>
        public void Agregar(LineaBase lineaBase)
        {
            _lineaBaseData.Agregar(lineaBase);
        }

        /// <summary>
        /// Lista las lineas base de una fase de un proyecto.
        /// </summary>
        /// <param name="proyectoFase">ProyectoFase</param>
        /// <returns>Lista LineaBase</returns>
        public List<LineaBase> ListarPorProyecto(Proyecto proyecto)
        {
            return _lineaBaseData.ListarPorProyecto(proyecto);
        }
    }
}
