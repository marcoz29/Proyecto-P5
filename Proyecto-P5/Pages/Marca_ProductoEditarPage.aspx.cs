using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class Marca_ProductoEditarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idMarca = Convert.ToInt32(Request.QueryString["id"]);
                txtIdMarca.Text = idMarca.ToString();

                try
                {
                    using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                    {
                        var datosMarca = db.spConsultarMarca_ProductoId(idMarca).FirstOrDefault();

                        if (datosMarca != null)
                        {
                            TxtNombre.Text = datosMarca.NombreMarca;
                            TxtDescripcion.Text = datosMarca.DescripcionMarca;
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
                int idMarca = Convert.ToInt32(txtIdMarca.Text.Trim());
                string nombreMarca = TxtNombre.Text.Trim();
                string descripcionMarca = TxtDescripcion.Text.Trim();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spEditarMarca_Producto(idMarca, nombreMarca, descripcionMarca);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
            Response.Redirect("ResultadoEditarMarca_Producto.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Marca_ProductoListarPage.aspx");
        }
    }
}