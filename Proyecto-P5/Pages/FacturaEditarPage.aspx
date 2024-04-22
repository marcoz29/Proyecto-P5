<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacturaEditarPage.aspx.cs" Inherits="Proyecto_P5.Pages.FacturaEditarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar Factura</h2>

    <div>
        <div>
            <span>Id</span>
            <asp:TextBox ID="TxtIdFactura" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div>
            <span>Empleado</span>
            <asp:DropDownList ID="DdEmpleados" runat="server" Enabled="true"></asp:DropDownList>
        </div>
        <div>
            <span>Total</span>
            <asp:TextBox ID="TxtTotal" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Tipo de Pago</span>
            <asp:TextBox ID="TxtTipoPago" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Cliente</span>
            <asp:DropDownList ID="DdClientes" runat="server" Enabled="true"></asp:DropDownList>
        </div>
        <div>
            <span>Producto</span>
            <asp:DropDownList ID="DdProductos" runat="server" Enabled="true"></asp:DropDownList>
        </div>

        <div style="margin-top: 10px">
            <asp:Button ID="BtnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="BtnModificar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" BackColor="#F29200" ForeColor="White" CssClass="btn btn-primary" OnClick="BtnRegresar_Click" />
        </div>
    </div>
</asp:Content>
