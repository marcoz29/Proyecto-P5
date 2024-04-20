<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpleadoListarPage.aspx.cs" Inherits="Proyecto_P5.Pages.EmpleadoListarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <a href="EmpleadoAgregarPage.aspx" class="btn btn-primary">Agregar</a>
    </div>
    <div style="display: flex; justify-content: flex-start;">
        <asp:TextBox ID="TxtFiltrar" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" CssClass="btn btn-primary" OnClick="BtnFiltrar_Click" />
    </div>
    <asp:GridView ID="GvListarEmpleado" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
        <Columns>
            <asp:BoundField DataField="IdEmpleado" HeaderText="Id" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
            <asp:BoundField DataField="Correo" HeaderText="Correo" />
            <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="EmpleadoEditarPage.aspx?id=<%# Eval("IdEmpleado") %> ">Editar</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
