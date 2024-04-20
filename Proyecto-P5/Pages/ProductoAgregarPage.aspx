<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductoAgregarPage.aspx.cs" Inherits="Proyecto_P5.Pages.ProductoAgregarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Crear Producto</h2>

    <div>
        <div>
            <span>Marca</span>
            <asp:DropDownList ID="DdMarcas" runat="server" Enabled="true"></asp:DropDownList>
        </div>
        <div>
            <span>Categoria</span>
            <asp:DropDownList ID="DdCategorias" runat="server" Enabled="true"></asp:DropDownList>
        </div>
        <div>
            <span>Nombre</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Estado</span>
            <asp:DropDownList ID="DdEstados" runat="server" Enabled="true"></asp:DropDownList>
        </div>
        <div>
            <span>Descripcion</span>
            <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Precio</span>
            <asp:TextBox ID="TxtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Cantidad</span>
            <asp:TextBox ID="TxtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="BtnAgregar" runat="server" Text="Guardar"
                BackColor="#33CC33" ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnAgregar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" BackColor="#F29200" ForeColor="White" CssClass="btn btn-primary" OnClick="BtnRegresar_Click" />
        </div>
    </div>
</asp:Content>
