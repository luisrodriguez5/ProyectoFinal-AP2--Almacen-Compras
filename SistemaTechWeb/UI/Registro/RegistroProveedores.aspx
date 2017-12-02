<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="RegistroProveedores.aspx.cs" Inherits="SistemaTechWeb.UI.Registro.RegistroProveedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="page-header text-center col-6">
        <h1><strong>Registro Proveedores</strong></h1>
        <br />

    </div>

    <div class="row">
        <div class="col-6">

            <div class="form-group row">
                <label for="ProeveedorId" class="col-5 col-form-label text-right">Id:</label>
                <asp:TextBox ID="ProveedorTexBox" class="form-control justify-content-between col-3" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Buscar" class="form-control justify-content-around col-4" OnClick="Button1_Click"  />

            </div>


            <div class="form-group row">
                <label for="Nombre: " class="col-5 col-form-label text-right">Razon Social:</label>
                <asp:TextBox ID="RarozSocialTextBox" class="form-control col-7" placeholder="Razon Social" runat="server"></asp:TextBox>
            </div>


            <div class="form-group row">
                <label for="Dirrecion" class="col-5 col-form-label text-right">Direccion:</label>
                <asp:TextBox ID="DireccionTextBox" class="form-control col-7" placeholder="Direccion" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="Telefono" class="col-5 col-form-label text-right">Telefono:</label>
                <asp:TextBox class="form-control col-7" ID="TelefonoTextBox" placeholder="Telefono" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="Email" class="col-5 col-form-label text-right">Email:</label>
                <asp:TextBox class="form-control col-7" ID="EmailTextBox" placeholder="Email" runat="server"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="Clave" class="col-5 col-form-label text-right">Sector Comercial :</label>
                <asp:DropDownList CssClass="form-control col-7" ID="SectorDropDownList" runat="server">
                    <asp:ListItem>Alimentos</asp:ListItem>
                    <asp:ListItem>Limpiez</asp:ListItem>
                </asp:DropDownList>

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
                        <asp:Button ID="BtnEliminar" runat="server" class="btn btn-primary" Text="Eliminar" />
                        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" class="btn btn-primary " OnClick="BtnGuardar_Click" />
                    </div>
                </div>
            </div>
            <br />


        </div>
    </div>

    <footer>
        <div class="alert bg-dark color-blanco color-blanco fondo-azul-oscuro">
            <p class="text-center">Almacen Luis G. 2017.</p>
        </div>
    </footer>

</asp:Content>
