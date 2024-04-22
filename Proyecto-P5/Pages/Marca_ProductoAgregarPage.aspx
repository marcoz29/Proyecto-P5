<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Marca_ProductoAgregarPage.aspx.cs" Inherits="Proyecto_P5.Pages.Marca_ProductoAgregarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Crear Marca de un Producto</h2>

    <div>
        <div>
            <span>Nombre</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Descripcion</span>
            <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div style="margin-top: 10px">
            <asp:Button ID="BtnAgregar" runat="server" Text="Guardar"
                BackColor="#33CC33" ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnAgregar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" BackColor="#F29200" ForeColor="White" CssClass="btn btn-primary" OnClick="BtnRegresar_Click" />
        </div>
    </div>

</asp:Content>
