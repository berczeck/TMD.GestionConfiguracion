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
    /// Implementa la Logica de Negocios de la entidad Proyecto
    /// </summary>
    public class ProyectoLogica : IProyectoLogica
    {
        private readonly IProyectoData _proyectoData;

        public ProyectoLogica(IProyectoData proyectoData)
        {
            _proyectoData = proyectoData;
        }

        /// <summary>
        /// Lista los proyectos de un Usuario.
        /// </summary>
        /// <param name="usuario">Objeto Usuario</param>
        /// <returns>List Proyecto</returns>
        public List<Proyecto> ListarPorUsuario(Usuario usuario)
        {
            return _proyectoData.ListarPorUsuario(usuario);
        }

    }
}
