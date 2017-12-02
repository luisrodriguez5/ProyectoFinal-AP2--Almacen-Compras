﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaTechWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">AlmacenTech</h1>
        <h1 class="display-4 d-sm-none">AlmacenTech</h1>
    </header>

    <div class="row">
        <div class="col-xs-12 col-sm-2 col-md-4 col-lg-4"></div>
        <div class="col-xs-12 col-sm-8 col-md-4 col-lg-4">
         
            <div class="page-header text-center">
                <h1 id="H1Inicio">Inicio de sesión</h1>
            </div>
            <br />

           
            <div class="form-group">
                <label for="UsuarioTextBox">Usuario</label>
                <asp:TextBox class="form-control" ID="UsuarioTextBox" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="ContrasenaTextBox">Contraseña</label>
                <asp:TextBox type="password" class="form-control" ID="ContrasenaTextBox" runat="server"></asp:TextBox>
            </div>

            <br />
            <div class="text-center">
                <asp:Button CssClass="btn-notificacion btn btn-primary btn-lg" ID="LoginButton" runat="server" Text="Iniciar sesión" OnClick="LoginButton_Click" />
                <br />
            </div>
        </div>
      
        <div class="col-xs-12 col-sm-2 col-md-4 col-lg-4"></div>

    </div>
    <!--Fin row-->

    <br />
    <br />
    <br />
</asp:Content>
