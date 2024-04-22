using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                lnkCerrarSesion.Visible = true;
                navCategoria.Visible = true;
                navCliente.Visible = true;
                navEmpleado.Visible = true;
                navFactura.Visible = true;
                navMarca.Visible = true;
                navProducto.Visible = true;
            }
        }

        protected void lnkCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();

            Response.Redirect("~/Default.aspx");
        }
    }
}