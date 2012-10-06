using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CF.Entidades;

namespace TMD.CF.LogicaNegocios.Contrato
{
    public interface ILineaBaseElementoConfiguracionLogica
    {
        /// <summary>
        /// Agrega un registro a la tabla Elemento de Configuracion Linea Base.
        /// </summary>
        /// <param name="elemento">ElementoConfiguracion</param>
        void Agregar(LineaBaseElementoConfiguracion elemento);
    }
}
