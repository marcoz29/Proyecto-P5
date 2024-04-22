using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            bool usuarioCorrecto = false;

            try
            {
                string usuario = txtUsuario.Text;
                string password = txtContra.Text;
                if (usuario == "Admin" && password == "1234")
                {
                    usuarioCorrecto = true;

                    Session["usuario"] = usuario;

                }
                else
                {
                    lblMensaje.Text = "Usuario o Contraseña Incorrecto";
                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }
            if (usuarioCorrecto == true)
            {
                Response.Redirect("~/Pages/CategoriaListarPage.aspx");
            }
        }
    }
}