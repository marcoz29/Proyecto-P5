<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacturaListarPage.aspx.cs" Inherits="Proyecto_P5.Pages.FacturaListarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <a href="FacturaAgregarPage.aspx" class="btn btn-primary">Agregar</a>
    </div>
    <div style="display: flex; justify-content: flex-start;">
        <asp:TextBox ID="TxtFiltrar" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" CssClass="btn btn-primary" OnClick="BtnFiltrar_Click" />
    </div>
    <asp:GridView ID="GvListarFactura" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
        <Columns>
            <asp:BoundField DataField="IdFactrura" HeaderText="Id" />
            <asp:BoundField DataField="NombreEmpleado" HeaderText="Empleado" />
            <asp:BoundField DataField="FechaFactrura" HeaderText="Fecha" />
            <asp:BoundField DataField="TotalFactrura" HeaderText="Total" />
            <asp:BoundField DataField="TipoPagoFactrura" HeaderText="Tipo de Pago" />
            <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
            <asp:BoundField DataField="NombreProducto" HeaderText="Producto" />
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="FacturaEditarPage.aspx?id=<%# Eval("IdFactrura") %> ">Editar</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
