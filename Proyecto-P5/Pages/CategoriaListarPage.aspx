<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CategoriaListarPage.aspx.cs" Inherits="Proyecto_P5.Pages.CategoriaListarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background-color: gray">
        <div style="margin-bottom: 10px;">
            <a href="CategoriaAgregarPage.aspx" class="btn btn-primary">Agregar</a>
        </div>
        <div style="display: flex; justify-content: flex-start; margin-bottom: 10px;">
            <asp:TextBox ID="TxtFiltrar" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" CssClass="btn btn-primary" OnClick="BtnFiltrar_Click" Style="margin-left: 10px" />
        </div>
        <asp:GridView ID="GvListarCategoria" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" Style="margin-bottom: 10px">
            <Columns>
                <asp:BoundField DataField="IdCategoria" HeaderText="Id" />
                <asp:BoundField DataField="NombreCategoria" HeaderText="Nombre" />
                <asp:BoundField DataField="DescripcionCategoria" HeaderText="Descripcion" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="CategoriaEditarPage.aspx?id=<%# Eval("IdCategoria") %> " style="color:blue">Editar</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
