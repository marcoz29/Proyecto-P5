<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClienteEditarPage.aspx.cs" Inherits="Proyecto_P5.Pages.ClienteEditarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar Cliente</h2>
    <div>
        <div>
            <span>Id</span>
            <asp:TextBox ID="txtIdCliente" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div>
            <span>Nombre</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Apellidos</span>
            <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Correo</span>
            <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Direccion</span>
            <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div style="margin-top: 10px">
            <asp:Button ID="BtnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="BtnModificar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" BackColor="#F29200" ForeColor="White" CssClass="btn btn-primary" OnClick="BtnRegresar_Click" />
        </div>
    </div>
</asp:Content>
