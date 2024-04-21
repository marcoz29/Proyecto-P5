using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class ClienteAgregarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombreCliente = TxtNombre.Text.Trim();
            string apellidosCliente = TxtApellidos.Text.Trim();
            string correoCliente = TxtCorreo.Text.Trim();
            string direccionCliente = TxtDireccion.Text.Trim();

            try
            {
                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spCrearCliente(nombreCliente, apellidosCliente, correoCliente, direccionCliente);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
            Response.Redirect("~/Pages/ResultadoDeCrearCliente.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/ClienteListarPage.aspx");
        }
    }
}