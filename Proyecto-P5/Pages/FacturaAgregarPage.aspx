<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacturaAgregarPage.aspx.cs" Inherits="Proyecto_P5.Pages.FacturaAgregarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Crear Factura</h2>

    <div>
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
            <asp:Button ID="BtnAgregar" runat="server" Text="Guardar"
                BackColor="#33CC33" ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnAgregar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" BackColor="#F29200" ForeColor="White" CssClass="btn btn-primary" OnClick="BtnRegresar_Click" />
        </div>
    </div>
</asp:Content>
