<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductoListarPage.aspx.cs" Inherits="Proyecto_P5.Pages.ProductoListarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style=" margin-bottom: 10px;">
        <a href="ProductoAgregarPage.aspx" class="btn btn-primary">Agregar</a>
    </div>
    <div style="display: flex; justify-content: flex-start; margin-bottom: 10px;">
        <asp:TextBox ID="TxtFiltrar" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" CssClass="btn btn-primary" OnClick="BtnFiltrar_Click" style="margin-left: 10px" />
    </div>
    <asp:GridView ID="GvListarProducto" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" style="margin-bottom: 10px">
        <Columns>
            <asp:BoundField DataField="IdProducto" HeaderText="Id" />
            <asp:BoundField DataField="NombreMarca" HeaderText="Marca" />
            <asp:BoundField DataField="NombreCategoria" HeaderText="Categoria" />
            <asp:BoundField DataField="NombreProducto" HeaderText="Nombre" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" />
            <asp:BoundField DataField="DescripcionProducto" HeaderText="Descripcion" />
            <asp:BoundField DataField="PrecioProducto" HeaderText="Precio" />
            <asp:BoundField DataField="CantidadProducto" HeaderText="Cantidad" />
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="ProductoEditarPage.aspx?id=<%# Eval("IdProducto") %> ">Editar</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
