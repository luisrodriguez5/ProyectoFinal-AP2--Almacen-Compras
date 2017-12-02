<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cProveedores.aspx.cs" Inherits="SistemaTechWeb.UI.Consulta.cProveedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="text-center text-capitalize">
        <h1 class="display-1 d-none d-sm-block">SistemTech</h1>
        <h1 class="display-4 d-sm-none">Almacen</h1>
    </header>

    <div class=" container page-header text-left">
        <h1>Consulta Proveedore</h1>
    </div>

    <div class="col-xs-12 col-sm-4 d-inline-block">
        <asp:DropDownList CssClass="form-control" ID="FiltrarDropDownList" runat="server">
            <asp:ListItem>Todos</asp:ListItem>
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Nombre</asp:ListItem>
     
           
        </asp:DropDownList>
    </div>

    <div class="col-xs-12 col-sm-7 d-inline-block">
        <div class="form-group">
            <asp:TextBox CssClass="form-control col-6" ID="FiltrarTextBox" runat="server" autocomplete="off"></asp:TextBox>
        </div>
    </div>

    <div class="col">
        <div class="form-group">
            <asp:CheckBox ID="FiltrarFechaCheckBox" runat="server" />
            <label for="ContentPlaceHolder1_FiltrarFechaCheckBox">Fitrar por fecha</label>
        </div>
    </div>

    <asp:Panel ID="FechasPanel" runat="server">
        <div class="col-xs-12 col-sm-4 d-inline-block">
            <div class="form-group">
                <label for="ContentPlaceHolder1_FechaDesdeTextBox">Desde</label>
                <asp:TextBox type="date" CssClass="form-control col-6" ID="FechaDesdeTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
        </div>

        <div class="col-xs-12 col-sm-5 d-inline-block">
            <div class="form-group">
                <label for="ContentPlaceHolder1_FechaHastaTextBox">Hasta</label>
                <asp:TextBox type="date" CssClass="form-control col-6" ID="FechaHastaTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
        </div>
    </asp:Panel>

    <div class="float-left container">
        <asp:Button CssClass="btn btn-primary  d-flex justify-content-around " ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
    </div>


    <br />
    <br />
    <br />


    <div class="row container">
        <div class="col-12">
            <asp:GridView CssClass="table table-responsive table-hover" BorderStyle="None" AutoGenerateColumns="false" GridLines="Horizontal"
                ID="ProveedorConsulta" DataKeyNames="ProveedorId, Sector_Comercial" ShowFooter="true" runat="server">
                <HeaderStyle CssClass="bg-danger" />
                <Columns>
                    <asp:BoundField DataField="ProveedorId" HeaderText="Id" />
                    <asp:BoundField DataField="Sector_Comercial" HeaderText="Sector Comercial" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />



                    <asp:TemplateField></asp:TemplateField>
                </Columns>
                <FooterStyle CssClass="bg-light" />
            </asp:GridView>
            <div class="float-right">
                <asp:Button CssClass="btn btn-success" ID="ImprimirButton" runat="server" Text="Imprimir" />
            </div>
        </div>
    </div>

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
                    <p>Esta seguro de eliminar este usuario?</p>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="EliminarButton" runat="server" CssClass="btn btn-secondary" Text="Si" />
                    <asp:Button ID="CancelarEliminacionButton" runat="server" CssClass="btn btn-secondary" Text="No" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
