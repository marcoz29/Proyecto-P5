<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Marca_ProductoEditarPage.aspx.cs" Inherits="Proyecto_P5.Pages.Marca_ProductoEditarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar Marca</h2>
    <div>
        <div>
            <span>Id</span>
            <asp:TextBox ID="txtIdMarca" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div>
            <span>Nombre</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Descripcion</span>
            <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div style="margin-top: 10px">
            <asp:Button ID="BtnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="BtnModificar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" BackColor="#F29200" ForeColor="White" CssClass="btn btn-primary" OnClick="BtnRegresar_Click" />
        </div>
    </div>
</asp:Content>
