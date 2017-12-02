<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="RegistroCategortia.aspx.cs" Inherits="SistemaTechWeb.UI.Registro.RegistroCategortia" %>

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
                <label for="CategoriaId" class="col-5 col-form-label text-right">Id:</label>
                <asp:TextBox ID="CategoriaIdTexBox" class="form-control justify-content-between col-3" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Buscar" class="form-control justify-content-around col-4" OnClick="Button1_Click" />

            </div>


            <div class="form-group row">
                <label for="Nombre" class="col-5 col-form-label text-right">Nombre:</label>
                <asp:TextBox ID="NombreTextBox" class="form-control col-7" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>


            <div class="form-group row">
                <label for="Codigo" class="col-5 col-form-label text-right">Codigo:</label>
                <asp:TextBox ID="CodigoTextBox" class="form-control col-7" placeholder="Codigo" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="Descripcion" class="col-5 col-form-label text-right">Descripcion:</label>
                <asp:TextBox class="form-control col-7" ID="DescripcionTextBox" placeholder="Descricion" runat="server" Height="60px" Width="327px"></asp:TextBox>
            </div>


            <div class="col-lg-12">
                <div class="col-7 ml-md-auto">
                    <asp:Panel ID="AlertGuardar" Class="form-control alert-success text-center" runat="server" role="alert">
                        <asp:Label ID="MensajeGuardado" runat="server">!Se Guardo Con Exito! </asp:Label>
                    </asp:Panel>

                    <asp:Panel ID="AlertError" class="alert alert-danger text-center" role="alert" runat="server">
                        <asp:Label ID="MensajError" runat="server">¡Error!</asp:Label>
                    </asp:Panel>

                    <asp:Panel ID="AlerteExistencia" class="alert-success text-center" runat="server" role="alert">
                        <asp:Label ID="MensajeYa" runat="server">!Ya existe Este Usuario! </asp:Label>
                    </asp:Panel>


                    <asp:Panel ID="Alert" class="alert-success text-center" runat="server" role="alert">
                        <asp:Label ID="MensajeLlenar" runat="server">! Favor Llenar Los Campos ! </asp:Label>
                    </asp:Panel>
                </div>

                <div class="col-lg-12">
                    <div class="col-6 ml-md-auto">
                        <asp:Button ID="BtnNuevo" runat="server" class="btn btn-primary" Text="Nuevo" OnClick="BtnNuevo_Click" />
                        <asp:Button ID="BtnEliminar" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="BtnEliminar_Click" />
                        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" class="btn btn-primary " OnClick="BtnGuardar_Click" />
                    </div>
                </div>
            </div>
            <br />


        </div>
    </div>
</asp:Content>
