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
                            TxtNombre.Text = datosEmpleado.Nombre;
                            TxtApellidos.Text = datosEmpleado.Apellidos;
                            TxtCorreo.Text = datosEmpleado.Correo;
                            TxtDireccion.Text = datosEmpleado.Direccion;
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
                string nombre = TxtNombre.Text.Trim();
                string apellidos = TxtApellidos.Text.Trim();
                string correo = TxtCorreo.Text.Trim();
                string direccion = TxtDireccion.Text.Trim();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spEditarEmpleado(idEmpleado, nombre, apellidos, correo, direccion);
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