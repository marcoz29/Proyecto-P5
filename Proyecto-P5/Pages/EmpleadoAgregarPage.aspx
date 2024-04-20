﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpleadoAgregarPage.aspx.cs" Inherits="Proyecto_P5.Pages.EmpleadoAgregarPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Crear Empleado</h2>

    <div>
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

        <div>
            <asp:Button ID="BtnAgregar" runat="server" Text="Guardar"
                BackColor="#33CC33" ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnAgregar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" BackColor="#F29200" ForeColor="White" CssClass="btn btn-primary" OnClick="BtnRegresar_Click" />
        </div>
    </div>
</asp:Content>