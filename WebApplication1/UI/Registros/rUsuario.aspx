<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="rUsuario.aspx.cs" Inherits="WebApplication1.UI.Registros.rUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1 class="text-center col-9"><strong>Registro Usuario</strong></h1>

    </div>
    <br />
    <div class="row">
        <div class="col-6">
            <div class="form-group row">
                <label for="UsuarioId" class="col-5 col-form-label text-right">ID:</label>
                <asp:TextBox ID="UsuarioIdTexBox" class="form-control col-7" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="form-group row">
                <label for="Nombre: " class="col-5 col-form-label text-right">Nombre:</label>
                <asp:TextBox ID="nombresTextBox" class="form-control col-7" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="nombreUsuario" class="col-5 col-form-label text-right">Nombre Usuario:</label>
                <asp:TextBox class="form-control col-7" ID="nombreUsuario" placeholder="Nombre del Usuario" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="Clave" class="col-5 col-form-label text-right">Clave :</label>
                <asp:TextBox class="form-control col-7" ID="claveTextBox" placeholder="clave" runat="server"></asp:TextBox>
            </div>
            <div class="form-group row">
                <label for="ConfirmarClave" class="col-5 col-form-label text-right">Confirmar Clave:</label>
                <asp:TextBox class="form-control col-7" ID="confirmarClaveTextBox" placeholder="Confimar clave" runat="server" BorderStyle="Double"></asp:TextBox>
            </div>

            <div class="col-lg-12">
                <div class="col-6 ml-md-auto">
                    <button type="submit" class="btn btn-info">Nuevo</button>
                    <button type="submit" class="btn btn-info ">Guardar</button>
                    <button type="submit" class="btn btn-info ">Eliminar</button>
                </div>

            </div>
        </div>
</asp:Content>
