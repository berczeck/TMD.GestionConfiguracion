using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.Entidades;

namespace TMD.CF.AccesoDatos.Contrato
{
    /// <summary>
    /// Contrato  del Acceso a datos de la entidad Proyecto.
    /// </summary>
    public interface IProyectoData
    {
        /// <summary>
        /// Lista los proyectos de un Usuario.
        /// </summary>
        /// <param name="usuario">Objeto Usuario</param>
        /// <returns>List Proyecto</returns>
        List<Proyecto> ListarPorUsuario(Usuario usuario);
    }
}
