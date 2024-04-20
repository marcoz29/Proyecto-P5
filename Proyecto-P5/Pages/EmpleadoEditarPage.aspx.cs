using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class EmpleadoEditarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idEmpleado = Convert.ToInt32(Request.QueryString["id"]);
                txtIdEmpleado.Text = idEmpleado.ToString();

                try
                {
                    using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                    {
                        var datosEmpleado = db.spConsultarEmpleadoId(idEmpleado).FirstOrDefault();

                        if (datosEmpleado != null)
                        {
                            TxtNombre.Text = datosEmpleado.NombreEmpleado;
                            TxtApellidos.Text = datosEmpleado.ApellidosEmpleado;
                            TxtCorreo.Text = datosEmpleado.CorreoEmpleado;
                            TxtDireccion.Text = datosEmpleado.DireccionEmpleado;
                        }
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text.Trim());
                string nombreEmpleado = TxtNombre.Text.Trim();
                string apellidosEmpleado = TxtApellidos.Text.Trim();
                string correoEmpleado = TxtCorreo.Text.Trim();
                string direccionEmpleado = TxtDireccion.Text.Trim();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spEditarEmpleado(idEmpleado, nombreEmpleado, apellidosEmpleado, correoEmpleado, direccionEmpleado);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
            Response.Redirect("ResultadoEditarEmpleado.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpleadoListarPage.aspx");
        }
    }
}