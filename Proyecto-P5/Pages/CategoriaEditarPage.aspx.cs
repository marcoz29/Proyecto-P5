using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class CategoriaEditarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idCategoria = Convert.ToInt32(Request.QueryString["id"]);
                txtIdCategoria.Text = idCategoria.ToString();

                try
                {
                    using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                    {
                        var datosCategoria = db.spConsultarCategoriaId(idCategoria).FirstOrDefault();

                        if (datosCategoria != null)
                        {
                            TxtNombre.Text = datosCategoria.Nombre;
                            TxtDescripcion.Text = datosCategoria.Descripcion;
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
                int idCategoria = Convert.ToInt32(txtIdCategoria.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string descripcion = TxtDescripcion.Text.Trim();

                using(Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spEditarCategoria(idCategoria, nombre, descripcion);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
            Response.Redirect("ResultadoEditarCategoria.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/CategoriaListarPage.aspx");
        }
    }
}