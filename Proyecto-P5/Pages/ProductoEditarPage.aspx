<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductoEditarPage.aspx.cs" Inherits="Proyecto_P5.Pages.ProductoEditarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar Producto</h2>

    <div>
        <div>
            <span>Id</span>
            <asp:TextBox ID="TxtIdProducto" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
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
            <asp:Button ID="BtnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="BtnModificar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" BackColor="#F29200" ForeColor="White" CssClass="btn btn-primary" OnClick="BtnRegresar_Click" />
        </div>
    </div>
</asp:Content>
