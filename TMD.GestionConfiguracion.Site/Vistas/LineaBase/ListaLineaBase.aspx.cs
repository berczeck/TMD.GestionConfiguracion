using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMD.CF.Site.Controladora;
using TMD.CF.Site.Util;

namespace TMD.GC.Site.Vistas.LineaBase
{
    public partial class ListaLineaBase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlProyecto.DataSource = LineaBaseControladora.ListarProyectoPorUsuario(SesionFachada.Usuario.Id);
                ddlProyecto.DataValueField = "Id";
                ddlProyecto.DataTextField = "Nombre";
                ddlProyecto.DataBind();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            grvLineaBase.DataSource = LineaBaseControladora.ListarLineaBasePorProyecto(Convert.ToInt32(ddlProyecto.SelectedValue));
            grvLineaBase.DataBind();
        }
    }
}