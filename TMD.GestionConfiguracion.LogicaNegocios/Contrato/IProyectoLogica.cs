using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.Entidades;

namespace TMD.CF.LogicaNegocios.Contrato
{
    /// <summary>
    /// Contrato  de la Logica de Negocios de la entidad Proyecto.
    /// </summary>
    public interface IProyectoLogica
    {
        /// <summary>
        /// Lista los proyectos de un Usuario.
        /// </summary>
        /// <param name="usuario">Objeto Usuario</param>
        /// <returns>List Proyecto</returns>
        List<Proyecto> ListarPorUsuario(Usuario usuario);
    }
}
