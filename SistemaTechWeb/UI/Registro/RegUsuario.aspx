<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="RegUsuario.aspx.cs" Inherits="SistemaTechWeb.UI.Registro.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <br />
    <br />
    <div class="page-header text-center col-6">
        <h1><strong>Registro Usuario</strong></h1>
        <br />

    </div>

    <div class="row">
        <div class="col-6">

            <div class="form-group row">
                <label for="UsuarioId" class="col-5 col-form-label text-right">Id:</label>
                <asp:TextBox ID="UsuarioIdTexBox" class="form-control col-7" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="Nombre: " class="col-5 col-form-label text-right">Nombre:</label>
                <asp:TextBox ID="NombreTextBox" class="form-control col-7" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>


            <div class="form-group row">
                <label for="NombreUsuario" class="col-5 col-form-label text-right">Nombre:</label>
                <asp:TextBox ID="NombreUsuarioTextBox" class="form-control col-7" placeholder="Nombre de usuario" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="ClaveLabel" class="col-5 col-form-label text-right">Clave:</label>
                <asp:TextBox class="form-control col-7" ID="ClaveTextBox" placeholder="Clave" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="ConfirmarClaveLabel" class="col-5 col-form-label text-right">Confirmar Clave:</label>
                <asp:TextBox class="form-control col-7" ID="ConfirmarTextBox" placeholder="Clave" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="Clave" class="col-5 col-form-label text-right">Fecha :</label>
                <asp:TextBox class="form-control col-7" ID="FechaTextBox" placeholder="Fecha" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            
           
        </div>
        
    </div>
</asp:Content>
