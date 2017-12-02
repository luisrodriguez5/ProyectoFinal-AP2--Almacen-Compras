<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="RegistroFactura.aspx.cs" Inherits="SistemaTechWeb.UI.Registro.RegistroFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-7 col-sm-9 col-md-10">
            </div>
            <div class="col-5 col-sm-3 col-md-2">
                <asp:Label ID="FechaFacturaLabel" runat="server" Font-Size="Large" CssClass="h4"></asp:Label>
            </div>
        </div>

        <div class="page-header col-12">
            <h1>Factura</h1>
            <br />
        </div>

        <!--Formulario-->
        <div class="col-12 col-sm-8 col-md-6 col-lg-5">
            <div class="float-right">
            </div>
            <br />
            <!--Factura Id-->
            <div class="col-6">

                <div class="form-group row">
                    <label for="Id" class="col-5 col-form-label text-right">Id:</label>
                    <asp:TextBox ID="ProductoIdTexBox" class="form-control justify-content-between col-3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Buscar" class="form-control justify-content-around col-4" />

                </div>
            </div>
            <!--Cliente-->
            <div class="form-group">
                <asp:Label ID="ClienteIdLabel" runat="server" Text="Proveedor Id:"></asp:Label>
                <div class="row">
                    <div class="col-10 col-md-3">
                        <asp:TextBox type="number" ID="ClienteIdTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="col-0">
                        <asp:Button ID="BuscarProvedorButton" runat="server" CssClass="btn btn-secondary" OnClick="BuscarProvedorButton_Click" />
                    </div>
                    <div class="col-10 col-md-7">
                        <asp:TextBox ID="NombreProveedorTextBox" runat="server" CssClass="form-control" autocomplete="off" Enabled="False"></asp:TextBox>
                    </div>
                 
                </div>
            </div>

            <!--Forma de Pago-->
            <div class="form-group">
                <asp:Label ID="ComprobatePagoLabel" runat="server" Text="Comprobante:"></asp:Label>
                <asp:DropDownList CssClass="form-control" ID="ComprobanteDropDownList" runat="server">
                    <asp:ListItem>Factura</asp:ListItem>
                    <asp:ListItem>Recibo</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <!--Container-->
        <div class="container-fluid">
            <!--Producto-->
            <div class="form-group">
                <asp:Label ID="ProductoIdLabel" runat="server" Text="Producto:"></asp:Label>
                <div class="row">
                    <div class="col-10 col-sm-4 col-md-2">
                        <asp:TextBox type="number" ID="ProductoIdTextBox" runat="server" CssClass="form-control" autocomplete="off" AutoPostBack="true"></asp:TextBox>
                    </div>
                    <div class="col-0">
                        <asp:Button ID="BuscarProductoButton" runat="server" CssClass="btn btn-secondary" OnClick="BuscarProductoButton_Click" />
                    </div>
                    <div class="col-10 col-sm-6 col-md-4">
                        <asp:TextBox ID="DescripcionProductoTextBox" runat="server" CssClass="form-control" autocomplete="off" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-10 col-sm-4 col-md-2">
                        <asp:TextBox ID="CostoProductoTextBox" runat="server" CssClass="form-control" autocomplete="off" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-10 col-sm-4 col-md-2">
                        <asp:TextBox type="number" ID="CantidadProductoTextBox" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="col-0">
                        <asp:Button ID="AgregarProductoButton" runat="server" CssClass="btn btn-secondary" OnClick="AgregarProductoButton_Click" />
                    </div>
                </div>
            </div>
            <!--Grid Detalle-->
            <div class="form-group">
                <asp:GridView CssClass="table table-responsive table-hover" BorderStyle="None"
                    ID="DetalleGridView" runat="server" GridLines="Horizontal" ShowFooter="true">
                    <HeaderStyle CssClass="bg-secondary text-white" />
                    <FooterStyle CssClass="bg-secondary" />
                </asp:GridView>
            </div>
       
           




        <div class="col-12 col-sm-8 col-md-6 col-lg-5">
            <!--Botones-->
            <div class="text-center">
                <asp:Button ID="NuevoButton" runat="server" CssClass="btn btn-secondary" Text="Nuevo" />
                <asp:Button ID="GuardarButton" runat="server" CssClass="btn btn-secondary" Text="Guardar" />
                <asp:Button ID="EnviarAlModalEliminarButton" CssClass="btn btn-secondary" runat="server" Text="Eliminar" />
            </div>
        </div>
        <!--Modal de confirmacion de eliminar-->
        <div class="modal" id="ModalEliminar">
            <div class="modal-dialog" role="document">
                <div class="modal-content ">
                    <div class="modal-header bg-secondary">
                        <h5 class="modal-title">¡Atencion!</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <p>Esta seguro de eliminar esta factura?</p>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="EliminarButton" runat="server" CssClass="btn btn-secondary" Text="Si" />
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">No</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
