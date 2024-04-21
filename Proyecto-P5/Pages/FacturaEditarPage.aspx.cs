using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class FacturaEditarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarListaEmpleados();
            LlenarListaClientes();
            LlenarListaProductos();
        }

        private void LlenarListaEmpleados()
        {
            try
            {
                var ListaEmpleados = new List<ListItem>();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    var query = (from lr in db.spListarEmpleado()
                                 select new ListItem
                                 {
                                     Value = lr.IdEmpleado.ToString(),
                                     Text = lr.NombreEmpleado.ToString()
                                 }
                                 ).ToList();

                    ListaEmpleados.AddRange(query);

                    DdEmpleados.DataTextField = "Text";
                    DdEmpleados.DataValueField = "Value";

                    DdEmpleados.DataSource = ListaEmpleados;
                    DdEmpleados.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
        private void LlenarListaClientes()
        {
            try
            {
                var ListaClientes = new List<ListItem>();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    var query = (from lr in db.spListarCliente()
                                 select new ListItem
                                 {
                                     Value = lr.IdCliente.ToString(),
                                     Text = lr.NombreCliente.ToString()
                                 }
                                 ).ToList();

                    ListaClientes.AddRange(query);

                    DdClientes.DataTextField = "Text";
                    DdClientes.DataValueField = "Value";

                    DdClientes.DataSource = ListaClientes;
                    DdClientes.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
        private void LlenarListaProductos()
        {
            try
            {
                var ListaProductos = new List<ListItem>();

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    var query = (from lr in db.spListarProducto()
                                 select new ListItem
                                 {
                                     Value = lr.IdProducto.ToString(),
                                     Text = lr.NombreProducto.ToString()
                                 }
                                 ).ToList();

                    ListaProductos.AddRange(query);

                    DdProductos.DataTextField = "Text";
                    DdProductos.DataValueField = "Value";

                    DdProductos.DataSource = ListaProductos;
                    DdProductos.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            int idFactura = Convert.ToInt32(TxtIdFactura.Text.Trim());
            int idEmpleado = Convert.ToInt32(DdEmpleados.SelectedItem.Value);
            DateTime fecha = DateTime.ParseExact(TxtFecha.Text.Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            decimal total = decimal.Parse(TxtTotal.Text.Trim());
            string TipoPago = TxtTipoPago.Text.Trim();
            int idClinte = Convert.ToInt32(DdClientes.SelectedItem.Value);
            int idProducto = Convert.ToInt32(DdProductos.SelectedItem.Value);

            try
            {
                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spEditarFactura(idFactura ,idEmpleado, fecha, total, TipoPago, idClinte, idProducto);
                }
            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("ResultadoEditarFactura.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/ProductoListarPage.aspx");
        }
    }
}