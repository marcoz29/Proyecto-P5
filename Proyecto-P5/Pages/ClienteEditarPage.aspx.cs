using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class ClienteEditarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idCliente = Convert.ToInt32(Request.QueryString["id"]);
                txtIdCliente.Text = idCliente.ToString();

                try
                {
                    using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                    {
                        var datosCliente = db.spConsultarClienteId(idCliente).FirstOrDefault();

                        if (datosCliente != null)
                        {
                            TxtNombre.Text = datosCliente.NombreCliente;
                            TxtApellidos.Text = datosCliente.ApellidosCliente;
                            TxtCorreo.Text = datosCliente.CorreoCliente; 
                            TxtDireccion.Text = datosCliente.DireccionCliente;
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
                int idCliente = Convert.ToInt32(txtIdCliente.Text.Trim());
                string nombreCliente = TxtNombre.Text.Trim();
                string apellidosCliente = TxtApellidos.Text.Trim();
                string correoCliente = TxtCorreo.Text.Trim();
                string direccionCliente = TxtDireccion.Text.Trim();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spEditarCliente(idCliente, nombreCliente, apellidosCliente, correoCliente, direccionCliente);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
            Response.Redirect("ResultadoEditarCliente.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClienteListarPage.aspx");
        }
    }
}