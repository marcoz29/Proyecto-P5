using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class ProductoEditarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                CargarInformacionDeProducto();
                LlenarListaMarcas();
                LlenarListaCategorias();
                LlenarListaEstados();
            }
        }
        private void CargarInformacionDeProducto()
        {

            int idProducto = Convert.ToInt32(Request.QueryString["id"]);

            TxtIdProducto.Text = idProducto.ToString();


            try

            {

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())

                {

                    var datosProducto = db.spConsultarProductoId(idProducto).FirstOrDefault();


                    if (datosProducto != null)

                    {

                        TxtNombre.Text = datosProducto.NombreProducto;

                        TxtDescripcion.Text = datosProducto.DescripcionProducto;

                        TxtPrecio.Text = datosProducto.PrecioProducto.ToString();

                        TxtCantidad.Text = datosProducto.CantidadProducto.ToString();


                        string idMarca = datosProducto.IdMarca.ToString();

                        string idCategoria = datosProducto.IdCategoria.ToString();

                        string idEstado = datosProducto.IdEstado.ToString();


                        DdMarcas.SelectedValue = idMarca;

                        DdCategorias.SelectedValue = idCategoria;

                        DdEstados.SelectedValue = idEstado;

                    }

                }

            }

            catch (Exception)

            {

                Response.Redirect("Error.aspx");

            }

        }
        private void LlenarListaMarcas()
        {
            try
            {
                var ListaMarcas = new List<ListItem>();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    var query = (from lr in db.spListarMarca_Producto()
                                 select new ListItem
                                 {
                                     Value = lr.IdMarca.ToString(),
                                     Text = lr.NombreMarca
                                 }
                                 ).ToList();

                    ListaMarcas.AddRange(query);

                    DdMarcas.DataTextField = "Text";
                    DdMarcas.DataValueField = "Value";

                    DdMarcas.DataSource = ListaMarcas;
                    DdMarcas.DataBind();
                }
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }
        private void LlenarListaCategorias()
        {
            try
            {
                var ListaCategorias = new List<ListItem>();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    var query = (from lr in db.spListarCategoria()
                                 select new ListItem
                                 {
                                     Value = lr.IdCategoria.ToString(),
                                     Text = lr.NombreCategoria
                                 }
                                 ).ToList();

                    ListaCategorias.AddRange(query);

                    DdCategorias.DataTextField = "Text";
                    DdCategorias.DataValueField = "Value";

                    DdCategorias.DataSource = ListaCategorias;
                    DdCategorias.DataBind();
                }
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }
        private void LlenarListaEstados()
        {
            try
            {
                var ListaEstados = new List<ListItem>();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    var query = (from lr in db.spListarEstado()
                                 select new ListItem
                                 {
                                     Value = lr.idEstado.ToString(),
                                     Text = lr.estado
                                 }
                                 ).ToList();

                    ListaEstados.AddRange(query);

                    DdEstados.DataTextField = "Text";
                    DdEstados.DataValueField = "Value";

                    DdEstados.DataSource = ListaEstados;
                    DdEstados.DataBind();
                }
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(TxtIdProducto.Text.Trim());
                int idMarca = Convert.ToInt32(DdMarcas.SelectedItem.Value);
                int idCategoria = Convert.ToInt32(DdCategorias.SelectedItem.Value);
                string nombre = TxtNombre.Text.Trim();
                int idEstado = Convert.ToInt32(DdEstados.SelectedItem.Value);
                string descripcion = TxtDescripcion.Text.Trim();
                decimal precio = decimal.Parse(TxtPrecio.Text.Trim());
                int cantidad = int.Parse(TxtCantidad.Text.Trim());

                //Esto valida que se haya digitado info en el cuadro de texto
                //if (!string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
                //{
                //    contrasennia = TxtContrasennia.Text.Trim();
                //}

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spEditarProducto(idProducto, idMarca, idCategoria, nombre, idEstado, descripcion, precio, cantidad);
                }
            }
            catch
            {
                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("~/Pages/ResultadoEditarProducto.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/ProductoListarPage.aspx");
        }
    }
}