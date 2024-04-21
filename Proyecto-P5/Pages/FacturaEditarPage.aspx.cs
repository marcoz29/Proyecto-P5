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
            if(IsPostBack == false) { 
            CargarInformacionDeFactura();
            LlenarListaEmpleados();
            LlenarListaClientes();
            LlenarListaProductos();
            }
        }

        private void CargarInformacionDeFactura()
        {

            int idFactura = Convert.ToInt32(Request.QueryString["id"]);

            TxtIdFactura.Text = idFactura.ToString();


            try

            {

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())

                {

                    var datosFactura = db.spConsultarFacturaId(idFactura).FirstOrDefault();


                    if (datosFactura != null)

                    {

                        TxtTotal.Text = datosFactura.TotalFactrura.ToString();
                        TxtTipoPago.Text = datosFactura.TipoPagoFactrura;


                        string idEmpleado = datosFactura.IdEmpleado.ToString();

                        string idCliente = datosFactura.IdEmpleado.ToString();

                        string idProducto = datosFactura.IdProducto.ToString();


                        DdEmpleados.SelectedValue = idEmpleado;

                        DdClientes.SelectedValue = idCliente;

                        DdProductos.SelectedValue = idProducto;

                    }

                }

            }

            catch (Exception)

            {

                Response.Redirect("Error.aspx");

            }

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
            try
            {
            int idFactura = Convert.ToInt32(TxtIdFactura.Text.Trim());
            int idEmpleado = Convert.ToInt32(DdEmpleados.SelectedItem.Value);
            decimal total = decimal.Parse(TxtTotal.Text.Trim());
            string TipoPago = TxtTipoPago.Text.Trim();
            int idClinte = Convert.ToInt32(DdClientes.SelectedItem.Value);
            int idProducto = Convert.ToInt32(DdProductos.SelectedItem.Value);

                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spEditarFactura(idFactura, idEmpleado, total, TipoPago, idClinte, idProducto);
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
            Response.Redirect("~/Pages/FacturaListarPage.aspx");
        }
    }
}