using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class ProductoListarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    var Lista = db.spListarProducto().ToList();

                    GvListarProducto.DataSource = Lista;
                    GvListarProducto.DataBind();
                }
            }
            catch
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
        }

        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (TxtFiltrar.Text != "")
            {
                string filterText = TxtFiltrar.Text.ToUpper(); // Convertir el texto del filtro a mayúsculas para un filtrado no sensible a mayúsculas/minúsculas

                foreach (GridViewRow row in GvListarProducto.Rows)
                {
                    bool rowVisible = false; // Indicador para rastrear si alguna celda en la fila coincide con el filtro

                    foreach (DataControlFieldCell cell in row.Cells)
                    {
                        if (cell.Text != null && cell.Text.ToUpper().IndexOf(filterText) == 0) // Verificar la propiedad Text de la celda
                        {
                            rowVisible = true;
                            break; // Detener la iteración de celdas si se encuentra una coincidencia
                        }
                    }

                    row.Visible = rowVisible; // Establecer la visibilidad de la fila según el indicador
                }
            }
            else
            {
                // Mostrar todas las filas si el texto del filtro está vacío
                foreach (GridViewRow row in GvListarProducto.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}