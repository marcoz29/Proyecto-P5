<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClienteListarPage.aspx.cs" Inherits="Proyecto_P5.Pages.ClienteListarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <a href="ClienteAgregarPage.aspx" class="btn btn-primary">Agregar</a>
    </div>
    <div style="display: flex; justify-content: flex-start;">
        <asp:TextBox ID="TxtFiltrar" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" CssClass="btn btn-primary" OnClick="BtnFiltrar_Click" />
    </div>
    <asp:GridView ID="GvListarCliente" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
        <Columns>
            <asp:BoundField DataField="IdCliente" HeaderText="Id" />
            <asp:BoundField DataField="NombreCliente" HeaderText="Nombre" />
            <asp:BoundField DataField="ApellidosCliente" HeaderText="Apellidos" />
            <asp:BoundField DataField="CorreoCliente" HeaderText="Correo" />
            <asp:BoundField DataField="DireccionCliente" HeaderText="Direccion" />
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="ClienteEditarPage.aspx?id=<%# Eval("IdCliente") %> ">Editar</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
