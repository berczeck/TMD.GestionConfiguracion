using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.Entidades;

namespace TMD.CF.LogicaNegocios.Contrato
{
    /// <summary>
    /// Contrato  de la Logica de Negocios de la entidad Linea Base.
    /// </summary>
    public interface ILineaBaseLogica
    {
        /// <summary>
        /// Agrega un registro a la tabla LineaBase.
        /// </summary>
        /// <param name="lineaBase">LineaBase</param>
        void Agregar(LineaBase lineaBase);

        /// <summary>
        /// Lista las lineas base de una fase de un proyecto.
        /// </summary>
        /// <param name="proyectoFase">ProyectoFase</param>
        /// <returns>Lista LineaBase</returns>
        List<LineaBase> ListarPorProyecto(Proyecto proyecto);
    }
}
