using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMD.CF.LogicaNegocios.Contrato;
using TMD.CF.LogicaNegocios.Implementacion;
using TMD.CF.AccesoDatos.Implementacion;
using TMD.CF.Entidades;

namespace TMD.CF.Site.Controladora
{
    /// <summary>
    /// Controladora de la vista Proyecto
    /// </summary>
    class LineaBaseControladora : Base
    {
        private static readonly IProyectoLogica _proyectoLogica = new ProyectoLogica(new ProyectoData(BaseDatos));
        private static readonly ILineaBaseLogica _lineaBaseLogica = new LineaBaseLogica(new LineaBaseData(BaseDatos));

        public static List<Proyecto> ListarProyectoPorUsuario(int idUsuario)
        {
            List<Proyecto> lista = _proyectoLogica.ListarPorUsuario(new Usuario { Id = idUsuario });
            lista.Insert(0, new Proyecto { Id = 0 , Nombre = "--Seleccione--" });

            return lista;
        }

        public static List<LineaBase> ListarLineaBasePorProyecto(int idProyecto)
        {
            return _lineaBaseLogica.ListarPorProyecto(new Proyecto { Id = idProyecto });
        }

    }
}