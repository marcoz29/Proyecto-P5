using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class EmpleadoAgregarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string apellidos = TxtApellidos.Text.Trim();
            string correo = TxtCorreo.Text.Trim();
            string direccion = TxtDireccion.Text.Trim();

            try
            {
                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spCrearEmpleado(nombre, apellidos, correo, direccion);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
            Response.Redirect("~/Pages/ResultadoDeCrearEmpleado.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/EmpleadoListarPage.aspx");
        }
    }
}