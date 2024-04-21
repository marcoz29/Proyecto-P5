<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Marca_ProductoListarPage.aspx.cs" Inherits="Proyecto_P5.Pages.Marca_ProductoPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style=" margin-bottom: 10px;">
        <a href="Marca_ProductoAgregarPage.aspx" class="btn btn-primary">Agregar</a>
    </div>
    <div style="display: flex; justify-content: flex-start; margin-bottom: 10px;">
        <asp:TextBox ID="TxtFiltrar" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" CssClass="btn btn-primary" OnClick="BtnFiltrar_Click" style="margin-left: 10px" />
    </div>
    <asp:GridView ID="GvListarMarca_Producto" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" style="margin-bottom: 10px">
        <Columns>
            <asp:BoundField DataField="IdMarca" HeaderText="Id" />
            <asp:BoundField DataField="NombreMarca" HeaderText="Nombre" />
            <asp:BoundField DataField="DescripcionMarca" HeaderText="Descripcion" />
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="Marca_ProductoEditarPage.aspx?id=<%# Eval("IdMarca") %> ">Editar</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
