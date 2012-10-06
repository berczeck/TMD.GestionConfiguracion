using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.Entidades;

namespace TMD.CF.AccesoDatos.Contrato
{
    /// <summary>
    /// Contrato  del Acceso a datos de la entidad Linea Base .
    /// </summary>
    public interface ILineaBaseElementoConfiguracionData
    {
        /// <summary>
        /// Agrega un registro a la tabla Elemento de Configuracion Linea Base.
        /// </summary>
        /// <param name="elemento">ElementoConfiguracion</param>
        void Agregar(LineaBaseElementoConfiguracion elemento);
    }
}
