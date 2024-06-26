﻿using Proyecto_P5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_P5.Pages
{
    public partial class ProductoAgregarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaMarcas();
                LlenarListaCategorias();
                LlenarListaEstados();
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
                                     Text = lr.NombreMarca.ToString()
                                 }
                                 ).ToList();

                    ListaMarcas.AddRange(query);

                    DdMarcas.DataTextField = "Text";
                    DdMarcas.DataValueField = "Value";

                    DdMarcas.DataSource = ListaMarcas;
                    DdMarcas.DataBind();
                }
            }
            catch (Exception)
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
                                     Text = lr.NombreCategoria.ToString()
                                 }
                                 ).ToList();

                    ListaCategorias.AddRange(query);

                    DdCategorias.DataTextField = "Text";
                    DdCategorias.DataValueField = "Value";

                    DdCategorias.DataSource = ListaCategorias;
                    DdCategorias.DataBind();
                }
            }
            catch (Exception)
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
                                     Text = lr.estado.ToString()
                                 }
                                 ).ToList();

                    ListaEstados.AddRange(query);

                    DdEstados.DataTextField = "Text";
                    DdEstados.DataValueField = "Value";

                    DdEstados.DataSource = ListaEstados;
                    DdEstados.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            int idMarca = Convert.ToInt32(DdMarcas.SelectedItem.Value);
            int idCategoria = Convert.ToInt32(DdCategorias.SelectedItem.Value);
            string nombre = TxtNombre.Text.Trim();
            int idEstado = Convert.ToInt32(DdEstados.SelectedItem.Value);
            string descripcion = TxtDescripcion.Text.Trim();
            decimal precio = decimal.Parse(TxtPrecio.Text.Trim());
            int cantidad = int.Parse(TxtCantidad.Text.Trim());

            try
            {
                using (Proyecto_P5Entities db = new Proyecto_P5Entities())
                {
                    db.spCrearProducto(idMarca, idCategoria, nombre, idEstado, descripcion, precio, cantidad);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("~/Pages/ResultadoDeCrearProducto.aspx");
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/ProductoListarPage.aspx");
        }
    }
}