<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_P5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main style="background-color: gray">
        <div style="margin-left: 10px">
            <div>
                <span>Usuario</span>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <span>Contraseña</span>
                <asp:TextBox ID="txtContra" runat="server" CssClass="form-control" Type="password" onfocus="this.select();" onpaste="return false;" oncut="return false;" oncopy="return false;"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnIngresar_Click" style="margin-top: 10px"/>
            </div>
        </div>
    </main>

</asp:Content>
